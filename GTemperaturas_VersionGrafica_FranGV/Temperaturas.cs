﻿using GTemperaturas_VersionGrafica_FranGV.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTemperaturas_VersionGrafica_FranGV
{
    public partial class Temperaturas : Form
    {
        public Temperaturas()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            
            Button boton = (Button) sender;

            string MensajeError = "";
            bool esValido = true;

            string NombreCiudad = textBoxCiudad.Text;
            string[] ListaTemperaturas = listBoxTemperaturas.Items.Cast<string>().ToArray();




            try
            {
                switch (boton.Name)
                {
                    case "buttonAgregarCiudad":

                        AgregarCiudad(NombreCiudad);
                        textBoxCiudad.Clear();

                        break;
                    case "buttonAgregarTemperatura":

                        AgregarTemperaturas();
                        break;
                    case "buttonMedia":
                        break;
                    case "buttonGuardarTemp":
                            GuardarTemperaturas();
                            buttonGuardarTemp.Enabled=false;
                        break;
                }
            
            }
            catch(Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) 
                { 
                    API.UI.MostrarError(MensajeError);

                    buttonAgregarTemperatura.Enabled = false;
                    buttonMedia.Enabled = false;
                    textBoxAgregarTemperaturas.Enabled = false;
                    listBoxTemperaturas.Enabled = false;
                    textBoxMediaAnual.Enabled = false;

                }

            }

        }


        // Funciones botones



        private void GuardarTemperaturas()
        {
            string[] ListaTemperaturas = listBoxTemperaturas.Items.Cast<string>().ToArray();


            APIFicheros.AgregarTemperaturas(comboBoxListaCiudades.Text, ListaTemperaturas);
        }





        private void AgregarCiudad(string NombreCiudad)
        {
            // Validar que no agreguemos una ciudad vacía
            if (string.IsNullOrEmpty(NombreCiudad)) throw new Exception("Cadena vacía");

            // Validar que no se repita
            APIFicheros.ValidarRepeticion(NombreCiudad);

            API.APIFicheros.CrearFichero(NombreCiudad);

            // Reseteamos el cb
            comboBoxListaCiudades.Items.Clear();

            // Volvemos a agregar el contenido del fichero
            comboBoxListaCiudades.Items.AddRange(API.APIFicheros.ConsultarDirectorio());
        }

        public void AgregarTemperaturas()
        {


            if (listBoxTemperaturas.Items.Count > 10)
            {
                buttonAgregarTemperatura.Enabled = false;
                buttonGuardarTemp.Enabled = true;
            }


            if (string.IsNullOrEmpty(textBoxAgregarTemperaturas.Text)) throw new Exception("Cadeba Vacía");

            listBoxTemperaturas.Items.Add(textBoxAgregarTemperaturas.Text);

            textBoxAgregarTemperaturas.Clear();

        }



        // Carga Datos

        private void Temperaturas_Load(object sender, EventArgs e)
        {
            // Cargar contenido del directorio
            comboBoxListaCiudades.Items.AddRange(API.APIFicheros.ConsultarDirectorio());


        }

        private void comboBoxListaCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Recursos


            string MensajeError = "";
            bool esValido = true;
            listBoxTemperaturas.Items.Clear();



            // Inicializar Botones
            buttonAgregarTemperatura.Enabled = false;
            buttonMedia.Enabled = false;
            textBoxAgregarTemperaturas.Enabled = true;
            listBoxTemperaturas.Enabled = false;
            textBoxMediaAnual.Enabled = false;

            string[] ListaTemperaturas = listBoxTemperaturas.Items.Cast<string>().ToArray();

            try
            {
                listBoxTemperaturas.Items.AddRange(APIFicheros.ConsultarFichero(comboBoxListaCiudades.Text));
            }
            catch (Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) API.UI.MostrarError(MensajeError);
                else
                {
                    buttonAgregarTemperatura.Enabled = true;
                    buttonMedia.Enabled = true;
                    comboBoxListaCiudades.Enabled = true;
                    textBoxAgregarTemperaturas.Enabled = true;
                    listBoxTemperaturas.Enabled = true;
                    textBoxMediaAnual.Enabled = true;
                }
            }

        }




    }
}

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

            try
            {
                switch (boton.Name)
                {
                    case "buttonAgregarCiudad":
                        break;
                    case "buttonAgregarTemperatura":
                        break;
                    case "buttonMedia":
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
                if(!esValido) API.UI.MostrarError(MensajeError);
            }

        }

        public static void AgregarCiudad()
        {
            // Verificar la existencia de la ciudad

            // Si no existe la ciudad se creará el fichero

            
        }

        private void Temperaturas_Load(object sender, EventArgs e)
        {
            comboBoxListaCiudades.Items.AddRange(API.APIFicheros.ConsultarDirectorio());
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTemperaturas_VersionGrafica_FranGV.API
{
    public static class APIFicheros
    {
        // Recursos
        private const string DIRECTORIO = "Ciudades\\";
        private const string EXTENSION = ".tmp";


        // Privados
        private static void CrearDirectorio()
        {
            Directory.CreateDirectory(DIRECTORIO);
        }


        // Publicos


        public static void ValidarExistencia()
        {
            if(!Directory.Exists(DIRECTORIO)) CrearDirectorio();
        }

        public static void CrearFichero(string nombre)
        {
            // Recursos
            StreamWriter Escritor = null;


            // Validar que no se repita

            if (!File.Exists(DIRECTORIO + nombre + EXTENSION))
            {
                Escritor = File.CreateText(DIRECTORIO + nombre + EXTENSION);

                Escritor.Close();

            }
            else throw new Exception("Nombre repetido");


        }






        public static void AgregarTemperaturas(string nombreFichero, string[]ListaTemp)
        {
            // Recursos
            StreamWriter Escritor = null;

            // Create Text sobreecribe
            Escritor = File.CreateText(DIRECTORIO + nombreFichero + EXTENSION);



            for (int indice = 0; indice < ListaTemp.Length; indice++)
            {
                Escritor.WriteLine(ListaTemp[indice]);
            }
        }

        public static string[] ConsultarDirectorio()
        {
            // Recursos

       
            // Lista de Ficheros
            string[] ListaFicheros = Directory.GetFiles(DIRECTORIO);
            string aux;

            
            // Limpiar nombre, Directorio/nombre.txt --> nombre

            for(int indice = 0; indice < ListaFicheros.Length; indice++)
            {
                aux = ListaFicheros[indice];

                aux = aux.Substring(aux.IndexOf("\\") + 1);
                aux = aux.Substring(0, aux.IndexOf("."));

                ListaFicheros[indice] = aux;
            }

            return ListaFicheros;
            
        }

        public static string[] ConsultarFichero(string nombreFichero)
        {
            // Recursos

            string[] ListaTemperaturas;
            StreamReader Lector;

            Lector = File.OpenText(DIRECTORIO + nombreFichero+ EXTENSION);



            ListaTemperaturas = File.ReadAllLines(DIRECTORIO+nombreFichero+EXTENSION);



            return ListaTemperaturas;
        }

        public static void ValidarRepeticion(string nombre)
        {

            nombre = nombre.Trim().ToLower();
            string ListaDirectorio = "";

            for (int indice = 0; indice < ConsultarDirectorio().Length; indice++)
            {
                 ListaDirectorio = ConsultarDirectorio()[indice];
            }

            ListaDirectorio = ListaDirectorio.Trim().ToLower();

            if (ListaDirectorio.Contains(nombre)) throw new Exception("Nombre repetido");
        }


    }
}

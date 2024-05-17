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

        private static void CrearFichero(string nombre)
        {
            // Recursos
            StreamWriter Escritor = null;

            if (!File.Exists(DIRECTORIO + nombre + EXTENSION))
            {
                Escritor = File.CreateText(DIRECTORIO + nombre + EXTENSION);
            }

            Escritor.Close();
            
        }

        // Agregar 12 temperaturas
        public static void AgregarTemperaturas(string nombreFichero, string[]ListaTemp)
        {
            // Recursos
            StreamWriter Escritor = null;

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
            ValidarExistencia();

            string[] ListaFicheros = Directory.GetFiles(DIRECTORIO);
            string aux;

            
            // Limpiar nombre, Directorio/nombre.txt --> nombre

            for(int indice = 0; indice < ListaFicheros.Length; indice++)
            {
                aux = ListaFicheros[indice];

                aux = aux.Substring(aux.IndexOf("\\") + 1);
                aux = aux.Substring(0, aux.IndexOf(".")+ 1);

                ListaFicheros[indice] = aux;
            }

            return ListaFicheros;
            
        }

    }
}

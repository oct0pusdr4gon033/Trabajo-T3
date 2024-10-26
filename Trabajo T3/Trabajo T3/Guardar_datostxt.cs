using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Trabajo_T3
{
    public class Guardar_datostxt
    {

        public static void GuardarEnTxt(string name, string lastName, string email, string user, string password, string date)
        {
            DateTime fechaActual = DateTime.Now;
            string datos = $"Name: {name} , Last Name: {lastName} , Email: {email} , User: {user} , Password: {password} , Date: {fechaActual}";
            string rutaArchivo = "Registro.txt";

            try
            {
                File.WriteAllText(rutaArchivo, datos);

            }
            catch (Exception ex)
            {

            }
        }
        public static bool ValidarUsuario(string user, string password)
        {
            string rutaArchivo = "Registro.txt";
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string[] contenido = File.ReadAllLines(rutaArchivo);
                    foreach (string linea in contenido)
                    {
                        if (linea.Contains($"User: {user}") && linea.Contains($"Password: {password}"))
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Archivo de registro no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }

            return false;
        }

        public static bool usuario_repetido(string user, string email)
        {

            string path_file="Registro.txt";

            try
            {
                if (File.Exists(path_file))
                {
                    string[] contenido = File.ReadAllLines(path_file);
                    foreach (string linea in contenido)
                    {
                        if (linea.Contains($"User: {user}") || linea.Contains($"E-mail: {email}"))
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false; 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
            return false;
        }




    }
}

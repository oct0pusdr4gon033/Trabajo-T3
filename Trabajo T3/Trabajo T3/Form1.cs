using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Trabajo_T3
{
    public partial class Form1 : Form
    {
        Digrafo grafo = new Digrafo();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txb_email.Text;
            string password = txb_password.Text;

            bool esValido = Guardar_datostxt.ValidarUsuario(email, password);

            if (esValido)
            {
                MessageBox.Show("Login exitoso. ¡Bienvenido!");
                Panel_usuario panel_Usuario = new Panel_usuario();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

            txb_email.Clear();
            txb_password.Clear();

        }
        private void btn_registro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }
       


    }
}

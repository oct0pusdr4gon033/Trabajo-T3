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
   
    public partial class Registro : Form
    {
      
        Digrafo grafo= new Digrafo();
        DateTime fecha = DateTime.Today;
     
        public Registro()
        {
            InitializeComponent();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            string name = txb_name.Text;
            string last_name= txb_last_name.Text;
            string email= txb_email.Text;
            string user= txb_user.Text;
            string password= txb_password.Text;
            string date = fecha.ToString();
            grafo.AgregarUsuario(name,last_name,email,user,password,date);
            Guardar_datostxt.GuardarEnTxt(name, last_name, email, user, password, date);
            txb_name.Clear();
            txb_last_name.Clear();
            txb_email.Clear();
            txb_user.Clear();
            txb_password.Clear();

            Guardar_datostxt.usuario_repetido(user, email); 
        }
    }
}

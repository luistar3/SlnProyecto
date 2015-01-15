using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlnProyecto
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
            txt_Clave_Registrar.PasswordChar = '*';
            txt_Re_Clave_Registar .PasswordChar='*';
        }
        //DECLARACION DE ARREGLOS PARA REGISTRO DE USUARIOS
        public static string[,] g_usuario = new string[20, 20];
        public static int g_usuario_cont=0;

        private void lbl_Condiciones_Click(object sender, EventArgs e)
        {
          MessageBox .Show ("Taknajump!, se reserva el derecho a exigir que cada usuario, acepte y cumpla los términos aquí expresados como condición previa y necesaria para el acceso, y utilización de los servicios y/o contenidos brindados por el Sitio");
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (chk_Condicion_Registro.Checked == true )
            {
                
                if (txt_Clave_Registrar.Text == txt_Re_Clave_Registar.Text)
                {
                    g_usuario[g_usuario_cont, 0] = txtNombre__Registar.Text;
                    g_usuario[g_usuario_cont, 1] = txt_Clave_Registrar.Text;
                    g_usuario[g_usuario_cont, 2] = txt_Email_Registrar.Text;
                    g_usuario_cont++;
                    MessageBox.Show("nombre" + g_usuario[0, 0] + "   pass" + g_usuario[0, 1] + "   email" + g_usuario[0, 2]);
                    MessageBox.Show(""+g_usuario_cont);
                }
                else 
                {
                    lbl_Clave_Comparacion.Visible = true;
                }
                

                
            }

            else
            {
                MessageBox.Show("DEBIDO A LAS POLITICAS DE LA EMPRESA, LA CUAL PIDE ACEPTAR LOS TERMINOS Y CONDICIONES QUE TAKNAJUMP PONE A SUS USUARIOS NO SE PEUDE PROCEDER AL REGISTRO DE SU PERSONA");
            }

        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            lbl_Clave_Comparacion.Visible = false;
        }

        private void btn_Cancelar_Registro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

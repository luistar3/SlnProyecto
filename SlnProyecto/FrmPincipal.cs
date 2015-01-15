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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            //OCULTAR LA CONTRASEÑA
            txt_Clave.PasswordChar = '*';
        }

        // DECLARACION DE ARRAY PARA DATOS DE LOS ADMINISTRADORES

        public static string[,] g_admin = new string[20, 20];
        public static int g_cont;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            g_admin[0, 0] = "123456";
            g_admin[0, 1] = "123456";
            g_admin[0, 2] = "admin01";
            g_cont = 1;

            

        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            for (int li = 0; li <= g_cont; li++)
            {
                if (g_admin[li, 2].Equals(txt_Usuario.Text))
                {
                    if (g_admin[li, 1].Equals(txt_Clave.Text ))
                    {
                        MessageBox.Show("HOLA");
                    //TIENE QUE MOSTRARME EL FORMULARIO PRINCIPAL  CON LAS  MAS OPCIONES 
                        break;
                    }
                }
            }
        }

        private void lbl_Registrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar objFrm = new FrmRegistrar();
            objFrm.Show();
        }

        private void btn_Cancelar_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

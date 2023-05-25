using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oz_Cam.VISTAS;

namespace Oz_Cam.VISTAS
{
    public partial class INICIO : Form
    {

        Clases.Conexion objx = new Clases.Conexion();
        string Estado;
        Oz_Cam.VISTAS.MENU instancia1 = new Oz_Cam.VISTAS.MENU();
        int[] vector = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        public INICIO()
        {
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            Screen[] sMonitores;
            sMonitores = Screen.AllScreens;

            // Posicion del formulario
            this.Left = sMonitores[0].Bounds.Left ;
            this.Top = sMonitores[0].Bounds.Top ;
            objx.establecerConexion();





        }

        private void INICIO_MouseClick(object sender, MouseEventArgs e)
        {

     
            instancia1.Show();

            //  objx.establecerConexion();
            //  Form2 form2 = new Form2();
            //  form2.Show();
        }
    }
}

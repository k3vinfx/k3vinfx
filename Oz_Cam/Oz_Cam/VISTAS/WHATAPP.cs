using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Oz_Cam.VISTAS
{
    public partial class WHATAPP : Form
    {

        Clases.Conexion objz = new Clases.Conexion();
        string Estado;

        int[] miVector;

        private DataSet dt;
        public WHATAPP(int[] vector)
        {
            InitializeComponent();
            miVector = vector;
        }



        public static int ValorRandomico()
        {
            // Crear una instancia de Random para generar valores aleatorios
            Random rnd = new Random();

            // Crear una lista para almacenar los valores generados
            List<int> valoresGenerados = new List<int>();

            // Generar valores aleatorios de 5 dígitos hasta encontrar uno que no se haya generado antes
            int valorAleatorio;
            do
            {
                valorAleatorio = rnd.Next(10000, 99999); // Generar un valor aleatorio de 5 dígitos
            } while (valoresGenerados.Contains(valorAleatorio)); // Verificar si el valor ya ha sido generado

            // Agregar el valor generado a la lista
            valoresGenerados.Add(valorAleatorio);

            // Imprimir el valor generado
            return valorAleatorio;
        }

        private void VerTabla()
        {
            DataSet dsTabla = objz.VerTable();
            dgv_1.DataSource = dsTabla.Tables[0];
        }

        private int rowIndex = 0;

    
        private void WHATAPP_Load(object sender, EventArgs e)
        {
            Oz_Cam.VISTAS.MENU instancia0 = new Oz_Cam.VISTAS.MENU();

   



            // objz.establecerConexion();
            Screen[] sMonitores;
            sMonitores = Screen.AllScreens;

            // Posicion del formulario
            this.Left = sMonitores[0].Bounds.Left;
            this.Top = sMonitores[0].Bounds.Top;
            VerTabla();
            txt1.Text = miVector[0].ToString();
            txt2.Text = miVector[1].ToString();

        }
        public void CerrarFormulario(Form formulario)
        {
            formulario.Close();
        }


        private void btn1_Click(object sender, EventArgs e)
        {

            TxtCEL.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "9";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            TxtCEL.Text += "#";
        }

        public void barrido()
        {
            for(int x = 0; x < 21; x++)
            {
                Convert.ToInt32(miVector[x]);
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            objz.Agregar(TxtCEL.Text.ToString(), txtToken.Text.ToString(), miVector[0].ToString(), miVector[1].ToString(), miVector[2].ToString(), miVector[3].ToString(), miVector[4].ToString(), miVector[5].ToString(), miVector[6].ToString(), miVector[7].ToString()) ;
            VerTabla();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            TxtCEL.Text = " ";
        }

        private void txtToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {

            Oz_Cam.VISTAS.MENU instancia1 = new Oz_Cam.VISTAS.MENU();
            instancia1.Show();
        }
    }
}

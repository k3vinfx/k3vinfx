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

namespace Oz_Cam
{
    public partial class Form1 : Form
    {

        Clases.Conexion objx = new Clases.Conexion();
        string Estado;
 
        private DataSet dt;
        private System.Windows.Forms.Timer timerActualizar1;
        public Form1()
        {
            InitializeComponent();


        }


        private void timerActualizar_Tick(object sender, EventArgs e)
        {
            VerTabla();
        }





    

        private void VerTabla()
        {
            DataSet dsTabla = objx.VerTable();
            dgv_1.DataSource = dsTabla.Tables[0];
            int valorRandom = ValorRandomico();
            // Usa el valor aleatorio generado aquí
            txtToken.Text = Convert.ToString(valorRandom) + "-T";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Clases.Conexion  conexion = new Clases.Conexion();
            conexion.establecerConexion();
            VerTabla();
            UltimoCampos();
        }
        public static int ValorRandomico() {
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
        private void UltimoCampos()
        {
            if (rowIndex < dgv_1.Rows.Count)
            {
                rowIndex++;
            }
            else
            {
                rowIndex = 0; // Vuelve al primer valor
            }

            txtValorActual.Text = dgv_1.Rows[rowIndex - 1].Cells[2].Value.ToString();

        }
        private void LimpiarCampos()
        {
            txtWhatapp.Clear();
            txtFoto1.Clear();
            txtToken.Clear();

        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            //objx.Agregar(Convert.ToInt32(txtWhatapp.Text), txtToken.Text, Convert.ToInt32(txtFoto1.Text));
 
            LimpiarCampos();
            VerTabla();
        }

        private int rowIndex = 0;

        private void btnUltimos_Click(object sender, EventArgs e)
        {
            if (rowIndex < dgv_1.Rows.Count )
            {
                rowIndex++;
            }
            else
            {
                rowIndex = 0; // Vuelve al primer valor
            }

            txtValorActual.Text = dgv_1.Rows[rowIndex-1].Cells[1].Value.ToString();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

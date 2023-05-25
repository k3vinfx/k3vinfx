using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoIt;


namespace Oz_Cam.VISTAS
{
    public partial class QR : Form
    {
        Clases.Conexion objx = new Clases.Conexion();
        string Estado;

        private DataSet dt;
        private System.Windows.Forms.Timer timerActualizar1;
        public QR()
        {
            InitializeComponent();
        }

        private int rowIndex = 0;
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

  

        }
    
        private void QR_Load(object sender, EventArgs e)
        {
            Clases.Conexion conexion = new Clases.Conexion();
            conexion.establecerConexion();
            VerTabla();
           // UltimoCampos();
        }


        private void VerTabla()
        {
            DataSet dsTabla = objx.VerTable_QR();
            dgv_1.DataSource = dsTabla.Tables[0];
           // int valorRandom = ValorRandomico();
            // Usa el valor aleatorio generado aquí
            //txtToken.Text = Convert.ToString(valorRandom) + "-T";
        }

        private void VerTabla2()
        {
            DataSet dsTabla = objx.VerTable();
            dgv_1.DataSource = dsTabla.Tables[0];
            // int valorRandom = ValorRandomico();
            // Usa el valor aleatorio generado aquí
            //txtToken.Text = Convert.ToString(valorRandom) + "-T";
        }


        private void btnUltimos_Click(object sender, EventArgs e)
        {
            int totalFilas = dgv_1.RowCount;
          

            int valor = (totalFilas + 1) - totalFilas;
           // MessageBox.Show("TOTAL:" + valor);
            if (rowIndex >=dgv_1.Rows.Count)
            {
                rowIndex = valor;
            }
       

            txtWhatapp.Text = dgv_1.Rows[totalFilas-1].Cells[1].Value.ToString();
            txtPago.Text = dgv_1.Rows[totalFilas - 1].Cells[2].Value.ToString();
            txtEstado.Text=  dgv_1.Rows[totalFilas - 1].Cells[3].Value.ToString();


            int x = 0;
            for (int y = 4; y < 8; y++)
            {
                x += Convert.ToInt16(dgv_1.Rows[totalFilas - 1].Cells[y].Value);
            }
            x = x * 10;

            txtValor.Text = x.ToString();


            // txtValor.Text = 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtWhatapp.Text);
            int totalFilas = dgv_1.RowCount;

            string a= dgv_1.Rows[totalFilas - 1].Cells[0].Value.ToString();
            string b = dgv_1.Rows[totalFilas - 2].Cells[3].Value.ToString();
            int x = 0;
            for (int y =4; y<8; y++)
            {
                x+= Convert.ToInt16(dgv_1.Rows[totalFilas - 1].Cells[y].Value);
            }
         
            string c_inf1 = "Pendiente QR";
            string c_inf2 = txtValor.Text;

            string resultado = objx.Editar(a, c_inf1,c_inf2);
            //  MessageBox.Show(x.ToString());
            VerTabla();

        



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutoItX.WinWaitActive("Program Manager", "");
           // Thread.Sleep(500); // Pausa de 500 milisegundos (opcional)
            AutoItX.MouseClick("left", 2197, 749, 1);
       
        }
    }
}

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

using System.IO;
using System.Threading;

namespace Oz_Cam.VISTAS
{
    public partial class MENU : Form
    {
        int mostrar = 1;
        int currentImage = 0;
        int totalImages = 8;
        private int contador = 0;

        private int count;
        public int num1 = 0;
        public int num2 = 0;
        public int pos = 0;
        int est_img_1_val = 1;
        int est_img_2_val = 2;
        int est_img_3_val = 3;
        int est_img_4_val = 4;



        int[] vector = new int[] {8, 4, 3, 9, 4, 2, 5, 5 };
        public int posicionActual = 0;
        private int contador_vector = 0;


        private void AddValue_Vector(int posicion ,TextBox texto, int valor)
        {         
                vector[posicion - 1] = valor;     
                MessageBox.Show($"Se agregó el valor  {valor} vector en la posición {texto}");

                texto.Text = vector[posicion - 1].ToString();

            
        }


        private void PosicionValue_Vector_Mem_Der()
        {
            if (posicionActual > 0 && posicionActual <6)
            {
               // MessageBox.Show($"Posicion: {txtPosicion.Text}");
                txtMemoria.Text = vector[posicionActual].ToString();        
            }
         
        }
        private void PosicionValue_Vector_Mem_Izq()
        {
            if (posicionActual > 0 && posicionActual < 6)
            {
                txtMemoria.Text = vector[posicionActual].ToString();        
            }
        }
        private void AddValue_Vector_0()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] =0;

                // MessageBox.Show($"Se agregó el valor 0 al vector en la posición {contador}");
           
            }
        }

        public MENU()
        {
            InitializeComponent();

            AddValue_Vector_0();
        }
        Thread tx;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar el formulario secundario
            this.Close();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            
            
            
            
            tx = new Thread(() =>
            {
                // Crear una nueva instancia de Form3
                Oz_Cam.VISTAS.WHATAPP form3 = new Oz_Cam.VISTAS.WHATAPP(vector);

                // Mostrar Form3 en el hilo de la interfaz de usuario
                form3.ShowDialog();
            });



            Screen[] sMonitores;
            sMonitores = Screen.AllScreens;
            AddValue_Vector_0();
            // Posicion del formulario
            this.Left = sMonitores[0].Bounds.Left;
            this.Top = sMonitores[0].Bounds.Top;
            btnIZQ.Visible = false;
            txtMemoria.Text = vector[0].ToString();
            picbox1.Image = LoadImage(currentImage+1);
            picbox2.Image = LoadImage(currentImage+2);
            picbox3.Image = LoadImage(currentImage+3);
            picbox4.Image = LoadImage(currentImage+4);

            Oz_Cam.VISTAS.INICIO instancia = new Oz_Cam.VISTAS.INICIO();
            instancia.Close();


        }

        private void girar_Der()
        {
            picbox1.Image = LoadImage(currentImage + 1);
            picbox2.Image = LoadImage(currentImage + 2);
            picbox3.Image = LoadImage(currentImage + 3);
            picbox4.Image = LoadImage(currentImage + 4);
        }





        private Image LoadImage(int index)
        {
            string imagePath = Path.Combine(Application.StartupPath, "RECURSOS", $"{index}.jpg");
            return Image.FromFile(imagePath);
        }
        private Image LoadImage2(int index)
        {
            string imagePath = Path.Combine(Application.StartupPath, "HOVER", $"{index}.jpg");
            return Image.FromFile(imagePath);
        }

        private void btnIZQ_Click(object sender, EventArgs e)
        {

            int est_img_1 = 0;
            int est_img_2 = 0;
            int est_img_3 = 0;
            int est_img_4 = 0;

            mostrar--;
            MessageBox.Show("valor:" + mostrar);
            if (mostrar == 1)
            {
                btnIZQ.Visible = false;
                btnDER.Visible = true;
            }
        
            if (mostrar >0)
            {
            
                est_img_1_val = est_img_1_val - 4;
                est_img_2_val = est_img_2_val - 4;
                est_img_3_val = est_img_3_val - 4;
                est_img_4_val = est_img_4_val - 4;



                for (int i =0; i < vector.Length; i++)
                {
             
                            if (i == 0 && vector[i] == 1)
                            {
                                txtval1.Text = "1";
                                picbox1.Image = LoadImage2(est_img_1_val);

                            }
                            else if(i == 0 && vector[i] != 1)
                            {
                                txtval1.Text = "0";
                            picbox1.Image = LoadImage(est_img_1_val);
                            }
                            if (i == 1 && vector[i] == 1)
                            {
                                txtval2.Text = "1";
                                picbox2.Image = LoadImage2(est_img_2_val);
                            }
                            else if (i == 1 && vector[i] != 1)
                            {
                                txtval2.Text = "0";
                                picbox2.Image = LoadImage(est_img_2_val);
                            }
                            if (i == 2 && vector[i] == 1)
                            {
                                txtval3.Text = "1";
                                picbox3.Image = LoadImage2(est_img_3_val);

                            }
                            else if (i == 2 && vector[i] != 1)
                            {
                                txtval3.Text = "0";
                                picbox3.Image = LoadImage(est_img_3_val);

                            }
                            if (i == 3 && vector[i] == 1)
                            {
                                txtval4.Text = "1";
                        
                                picbox4.Image = LoadImage2(est_img_4_val);

                            }
                            else if (i == 3 && vector[i] != 1)
                            {
                                txtval4.Text = "1";
                             
                                picbox4.Image = LoadImage(est_img_4_val);
                           }


                }
            }
            else
            {
                mostrar = 1;
                btnIZQ.Visible = false;
                
            }


            txtPosicion_1.Text = Convert.ToString(est_img_1_val);
            txtPosicion_2.Text = Convert.ToString(est_img_2_val);
            txtPosicion_3.Text = Convert.ToString(est_img_3_val);
            txtPosicion_4.Text = Convert.ToString(est_img_4_val);

            //// q onda 
          



        }

        private void btnDER_Click(object sender, EventArgs e)
        {
     


            int est_img_1 = 0;
            int est_img_2 = 0;
            int est_img_3 = 0;
            int est_img_4 = 0;
            mostrar++;
            if (mostrar == 2)
            {
                btnDER.Visible = false;
                btnIZQ.Visible = true;
            }

            MessageBox.Show("valor:" + mostrar);

            if(mostrar < 3)
            {
                btnIZQ.Visible = true;

                est_img_1_val = est_img_1_val + 4;
                est_img_2_val = est_img_2_val + 4;
                est_img_3_val = est_img_3_val + 4;
                est_img_4_val = est_img_4_val + 4;

          

                for (int i = 0; i < vector.Length; i++)
                {

                    if (i == 4 && vector[i] == 1)
                    {
                        txtval1.Text = "1";
                        picbox1.Image = LoadImage2(est_img_1_val);

                    }
                    else if (i == 4 && vector[i] != 1)
                    {
                        txtval1.Text = "0";
                        picbox1.Image = LoadImage(est_img_1_val);

                    }


                    if (i == 5 && vector[i] == 1)
                    {
                        txtval2.Text = "1";
                        picbox2.Image = LoadImage2(est_img_2_val);

                    }
                    else if (i == 5 && vector[i] != 1)
                    {
                        txtval2.Text = "0";
                        picbox2.Image = LoadImage(est_img_2_val);

                    }


                    if (i == 6 && vector[i] == 1)
                    {
                        txtval3.Text = "1";
                        picbox3.Image = LoadImage2(est_img_3_val);

                    }
                    else if (i == 6 && vector[i] != 1)
                    {
                        txtval3.Text = "0";
                        picbox3.Image = LoadImage(est_img_3_val);

                    }

                    if (i == 7 && vector[i] == 1)
                    {
                        txtval4.Text = "1";
                        picbox4.Image = LoadImage2(est_img_4_val);

                    }
                    else if (i == 7 && vector[i] != 1)
                    {
                        txtval4.Text = "0";
                        picbox4.Image = LoadImage(est_img_4_val);
                    }


                }

            }
            else
            {
                mostrar = 1;
            

            }

                txtPosicion_1.Text = Convert.ToString(est_img_1_val);
                txtPosicion_2.Text = Convert.ToString(est_img_2_val);
                txtPosicion_3.Text = Convert.ToString(est_img_3_val);
                txtPosicion_4.Text = Convert.ToString(est_img_4_val);
            
   
        }

        private void tm_derecha_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 1) // Si el timer ha corrido por 5 segundos
            {
                
                picbox_arr1.Image = Oz_Cam.Properties.Resources.franja_pelicula_estatica;
                picbox_abj1.Image = Oz_Cam.Properties.Resources.franja_pelicula_estatica___inferior;
            }
     

        }

        private void tm_izquierda_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 1) // Si el timer ha corrido por 5 segundos
            {
    
                picbox_arr1.Image = Oz_Cam.Properties.Resources.franja_pelicula_estatica;
                picbox_abj1.Image = Oz_Cam.Properties.Resources.franja_pelicula_estatica___inferior;
            }

        }



        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
        
        }

        private void txtMemoria_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task LoadForm3Async()
        {
            // Mostramos un mensaje al usuario mientras se carga el formulario
           // lblStatus.Text = "Cargando el formulario 3...";
           // lblStatus.Visible = true;

            // Cargamos el formulario en segundo plano utilizando Task.Run()
            await Task.Run(() =>
            {
  
                Oz_Cam.VISTAS.WHATAPP instancia1 = new Oz_Cam.VISTAS.WHATAPP(vector);
                instancia1.ShowDialog();
            });

            // Ocultamos el mensaje al usuario cuando el formulario se ha cargado completamente
           // lblStatus.Visible = false;
        }


       

        private void picbox_Click(object sender, EventArgs e)
        {

            // int valor = 0;
            //int aux = 0;
            // AddValue_Vector();



            if (txtval1.Text == "1")
            {
              
                AddValue_Vector(Convert.ToInt32(txtPosicion_1.Text),  txtval1,0);
                picbox1.Image = LoadImage(Convert.ToInt32(txtPosicion_1.Text));

            }
            else
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_1.Text),  txtval1,1);
                picbox1.Image = LoadImage2(Convert.ToInt32(txtPosicion_1.Text));
            }

        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            if (txtval2.Text == "1")
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_2.Text), txtval2, 0);
                picbox2.Image = LoadImage(Convert.ToInt32(txtPosicion_2.Text));
            }
            else
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_2.Text), txtval2, 1);
                picbox2.Image = LoadImage2(Convert.ToInt32(txtPosicion_2.Text));
            }
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            if (txtval3.Text == "1")
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_3.Text), txtval3, 0);
                picbox3.Image = LoadImage(Convert.ToInt32(txtPosicion_3.Text));
            }
            else
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_3.Text), txtval3, 1);
                picbox3.Image = LoadImage2(Convert.ToInt32(txtPosicion_3.Text));
            }
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            if (txtval4.Text == "1")
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_4.Text), txtval4, 0);
                picbox4.Image = LoadImage(Convert.ToInt32(txtPosicion_4.Text));
            }
            else
            {
                AddValue_Vector(Convert.ToInt32(txtPosicion_4.Text), txtval4, 1);
                picbox4.Image = LoadImage2(Convert.ToInt32(txtPosicion_4.Text));
            }
        }

        private async  void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            await LoadForm3Async();
   
        }
    }
}

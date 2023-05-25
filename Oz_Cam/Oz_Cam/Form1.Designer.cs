namespace Oz_Cam
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtWhatapp = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtFoto1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.timerActualizar = new System.Windows.Forms.Timer(this.components);
            this.txtValorActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWhatapp
            // 
            this.txtWhatapp.Location = new System.Drawing.Point(77, 50);
            this.txtWhatapp.Name = "txtWhatapp";
            this.txtWhatapp.Size = new System.Drawing.Size(100, 20);
            this.txtWhatapp.TabIndex = 0;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(77, 76);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(100, 20);
            this.txtToken.TabIndex = 1;
            // 
            // txtFoto1
            // 
            this.txtFoto1.Location = new System.Drawing.Point(77, 102);
            this.txtFoto1.Name = "txtFoto1";
            this.txtFoto1.Size = new System.Drawing.Size(100, 20);
            this.txtFoto1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Whatapp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Foto 1";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(25, 155);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 6;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(183, 34);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.Size = new System.Drawing.Size(442, 166);
            this.dgv_1.TabIndex = 7;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            // 
            // txtValorActual
            // 
            this.txtValorActual.Location = new System.Drawing.Point(77, 234);
            this.txtValorActual.Name = "txtValorActual";
            this.txtValorActual.Size = new System.Drawing.Size(100, 20);
            this.txtValorActual.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ultimo Valor";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(25, 184);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimos
            // 
            this.btnUltimos.Location = new System.Drawing.Point(102, 184);
            this.btnUltimos.Name = "btnUltimos";
            this.btnUltimos.Size = new System.Drawing.Size(75, 23);
            this.btnUltimos.TabIndex = 11;
            this.btnUltimos.Text = "Ultimo";
            this.btnUltimos.UseVisualStyleBackColor = true;
            this.btnUltimos.Click += new System.EventHandler(this.btnUltimos_Click);
            // 
            // btnUltimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 376);
            this.Controls.Add(this.btnUltimos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorActual);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoto1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtWhatapp);
            this.Name = "btnUltimo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWhatapp;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtFoto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Timer timerActualizar;
        private System.Windows.Forms.TextBox txtValorActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimos;
    }
}


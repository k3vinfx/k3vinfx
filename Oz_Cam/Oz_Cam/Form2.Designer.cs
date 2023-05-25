
namespace Oz_Cam
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUltimos = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorActual = new System.Windows.Forms.TextBox();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoto1 = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.txtWhatapp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUltimos
            // 
            this.btnUltimos.Location = new System.Drawing.Point(106, 162);
            this.btnUltimos.Name = "btnUltimos";
            this.btnUltimos.Size = new System.Drawing.Size(75, 23);
            this.btnUltimos.TabIndex = 23;
            this.btnUltimos.Text = "Ultimo";
            this.btnUltimos.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(29, 162);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ultimo Valor";
            // 
            // txtValorActual
            // 
            this.txtValorActual.Location = new System.Drawing.Point(81, 212);
            this.txtValorActual.Name = "txtValorActual";
            this.txtValorActual.Size = new System.Drawing.Size(100, 20);
            this.txtValorActual.TabIndex = 20;
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(187, 12);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.Size = new System.Drawing.Size(442, 166);
            this.dgv_1.TabIndex = 19;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(29, 133);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 18;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Foto 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Whatapp";
            // 
            // txtFoto1
            // 
            this.txtFoto1.Location = new System.Drawing.Point(81, 80);
            this.txtFoto1.Name = "txtFoto1";
            this.txtFoto1.Size = new System.Drawing.Size(100, 20);
            this.txtFoto1.TabIndex = 14;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(81, 54);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(100, 20);
            this.txtToken.TabIndex = 13;
            // 
            // txtWhatapp
            // 
            this.txtWhatapp.Location = new System.Drawing.Point(81, 28);
            this.txtWhatapp.Name = "txtWhatapp";
            this.txtWhatapp.Size = new System.Drawing.Size(100, 20);
            this.txtWhatapp.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 271);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUltimos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorActual;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoto1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox txtWhatapp;
    }
}
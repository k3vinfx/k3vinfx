namespace Oz_Cam.VISTAS
{
    partial class MENU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tm_derecha = new System.Windows.Forms.Timer(this.components);
            this.tm_izquierda = new System.Windows.Forms.Timer(this.components);
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.txtPosicion_1 = new System.Windows.Forms.TextBox();
            this.picbox4 = new System.Windows.Forms.PictureBox();
            this.picbox3 = new System.Windows.Forms.PictureBox();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDER = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnIZQ = new Bunifu.UI.WinForms.BunifuImageButton();
            this.picbox_abj1 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.picbox_arr1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPosicion_2 = new System.Windows.Forms.TextBox();
            this.txtPosicion_3 = new System.Windows.Forms.TextBox();
            this.txtPosicion_4 = new System.Windows.Forms.TextBox();
            this.txtval4 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_abj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_arr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tm_derecha
            // 
            this.tm_derecha.Interval = 50;
            this.tm_derecha.Tick += new System.EventHandler(this.tm_derecha_Tick);
            // 
            // tm_izquierda
            // 
            this.tm_izquierda.Interval = 50;
            this.tm_izquierda.Tick += new System.EventHandler(this.tm_izquierda_Tick);
            // 
            // txtMemoria
            // 
            this.txtMemoria.Location = new System.Drawing.Point(49, 211);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(100, 20);
            this.txtMemoria.TabIndex = 167;
            this.txtMemoria.Text = "0";
            this.txtMemoria.Visible = false;
            this.txtMemoria.TextChanged += new System.EventHandler(this.txtMemoria_TextChanged);
            // 
            // txtPosicion_1
            // 
            this.txtPosicion_1.Location = new System.Drawing.Point(115, 258);
            this.txtPosicion_1.Name = "txtPosicion_1";
            this.txtPosicion_1.Size = new System.Drawing.Size(22, 20);
            this.txtPosicion_1.TabIndex = 168;
            this.txtPosicion_1.Text = "1";
            this.txtPosicion_1.Visible = false;
            // 
            // picbox4
            // 
            this.picbox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picbox4.Image = global::Oz_Cam.Properties.Resources.b361665e5b4b00ee2eec57c0ceea6ad8;
            this.picbox4.Location = new System.Drawing.Point(986, 554);
            this.picbox4.Name = "picbox4";
            this.picbox4.Size = new System.Drawing.Size(587, 374);
            this.picbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox4.TabIndex = 171;
            this.picbox4.TabStop = false;
            this.picbox4.Click += new System.EventHandler(this.picbox4_Click);
            // 
            // picbox3
            // 
            this.picbox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picbox3.Image = global::Oz_Cam.Properties.Resources.b361665e5b4b00ee2eec57c0ceea6ad8;
            this.picbox3.Location = new System.Drawing.Point(308, 554);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(587, 374);
            this.picbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox3.TabIndex = 170;
            this.picbox3.TabStop = false;
            this.picbox3.Click += new System.EventHandler(this.picbox3_Click);
            // 
            // picbox2
            // 
            this.picbox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picbox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox2.Image = global::Oz_Cam.Properties.Resources.b361665e5b4b00ee2eec57c0ceea6ad8;
            this.picbox2.Location = new System.Drawing.Point(986, 122);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(587, 374);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 169;
            this.picbox2.TabStop = false;
            this.picbox2.Click += new System.EventHandler(this.picbox2_Click);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = false;
            this.bunifuImageButton4.AllowToggling = false;
            this.bunifuImageButton4.AllowZooming = true;
            this.bunifuImageButton4.AllowZoomingOnFocus = false;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = global::Oz_Cam.Properties.Resources.ACEPTAR;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 20;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(208, 118);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(228, 138);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(1643, 735);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = true;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(228, 138);
            this.bunifuImageButton4.TabIndex = 166;
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 20;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::Oz_Cam.Properties.Resources.CANCELAR;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 20;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(208, 118);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(228, 138);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(34, 709);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(228, 138);
            this.bunifuImageButton3.TabIndex = 165;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // btnDER
            // 
            this.btnDER.ActiveImage = null;
            this.btnDER.AllowAnimations = true;
            this.btnDER.AllowBuffering = false;
            this.btnDER.AllowToggling = false;
            this.btnDER.AllowZooming = true;
            this.btnDER.AllowZoomingOnFocus = false;
            this.btnDER.BackColor = System.Drawing.Color.Transparent;
            this.btnDER.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDER.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDER.ErrorImage")));
            this.btnDER.FadeWhenInactive = false;
            this.btnDER.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDER.Image = global::Oz_Cam.Properties.Resources.FLECHA_DERECHA;
            this.btnDER.ImageActive = null;
            this.btnDER.ImageLocation = null;
            this.btnDER.ImageMargin = 20;
            this.btnDER.ImageSize = new System.Drawing.Size(112, 112);
            this.btnDER.ImageZoomSize = new System.Drawing.Size(132, 132);
            this.btnDER.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnDER.InitialImage")));
            this.btnDER.Location = new System.Drawing.Point(1739, 409);
            this.btnDER.Name = "btnDER";
            this.btnDER.Rotation = 0;
            this.btnDER.ShowActiveImage = true;
            this.btnDER.ShowCursorChanges = true;
            this.btnDER.ShowImageBorders = true;
            this.btnDER.ShowSizeMarkers = false;
            this.btnDER.Size = new System.Drawing.Size(132, 132);
            this.btnDER.TabIndex = 164;
            this.btnDER.ToolTipText = "";
            this.btnDER.WaitOnLoad = false;
            this.btnDER.Zoom = 20;
            this.btnDER.ZoomSpeed = 10;
            this.btnDER.Click += new System.EventHandler(this.btnDER_Click);
            // 
            // btnIZQ
            // 
            this.btnIZQ.ActiveImage = null;
            this.btnIZQ.AllowAnimations = true;
            this.btnIZQ.AllowBuffering = false;
            this.btnIZQ.AllowToggling = false;
            this.btnIZQ.AllowZooming = true;
            this.btnIZQ.AllowZoomingOnFocus = false;
            this.btnIZQ.BackColor = System.Drawing.Color.Transparent;
            this.btnIZQ.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIZQ.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnIZQ.ErrorImage")));
            this.btnIZQ.FadeWhenInactive = false;
            this.btnIZQ.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnIZQ.Image = global::Oz_Cam.Properties.Resources.FLECHA_IZQUIERDA;
            this.btnIZQ.ImageActive = null;
            this.btnIZQ.ImageLocation = null;
            this.btnIZQ.ImageMargin = 20;
            this.btnIZQ.ImageSize = new System.Drawing.Size(112, 112);
            this.btnIZQ.ImageZoomSize = new System.Drawing.Size(132, 132);
            this.btnIZQ.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnIZQ.InitialImage")));
            this.btnIZQ.Location = new System.Drawing.Point(34, 409);
            this.btnIZQ.Name = "btnIZQ";
            this.btnIZQ.Rotation = 0;
            this.btnIZQ.ShowActiveImage = true;
            this.btnIZQ.ShowCursorChanges = true;
            this.btnIZQ.ShowImageBorders = true;
            this.btnIZQ.ShowSizeMarkers = false;
            this.btnIZQ.Size = new System.Drawing.Size(132, 132);
            this.btnIZQ.TabIndex = 163;
            this.btnIZQ.ToolTipText = "";
            this.btnIZQ.WaitOnLoad = false;
            this.btnIZQ.Zoom = 20;
            this.btnIZQ.ZoomSpeed = 10;
            this.btnIZQ.Click += new System.EventHandler(this.btnIZQ_Click);
            // 
            // picbox_abj1
            // 
            this.picbox_abj1.BackColor = System.Drawing.Color.Transparent;
            this.picbox_abj1.BackgroundImage = global::Oz_Cam.Properties.Resources.franja_pelicula_estatica___inferior;
            this.picbox_abj1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbox_abj1.Location = new System.Drawing.Point(-355, 989);
            this.picbox_abj1.Name = "picbox_abj1";
            this.picbox_abj1.Size = new System.Drawing.Size(1928, 88);
            this.picbox_abj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_abj1.TabIndex = 162;
            this.picbox_abj1.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picbox1.BackgroundImage = global::Oz_Cam.Properties.Resources.b361665e5b4b00ee2eec57c0ceea6ad8;
            this.picbox1.Location = new System.Drawing.Point(308, 122);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(587, 374);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 161;
            this.picbox1.TabStop = false;
            this.picbox1.Click += new System.EventHandler(this.picbox_Click);
            // 
            // picbox_arr1
            // 
            this.picbox_arr1.BackColor = System.Drawing.Color.Transparent;
            this.picbox_arr1.Image = global::Oz_Cam.Properties.Resources.franja_pelicula_estatica;
            this.picbox_arr1.Location = new System.Drawing.Point(0, 1);
            this.picbox_arr1.Name = "picbox_arr1";
            this.picbox_arr1.Size = new System.Drawing.Size(1177, 90);
            this.picbox_arr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_arr1.TabIndex = 160;
            this.picbox_arr1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Oz_Cam.Properties.Resources.franja_pelicula_estatica;
            this.pictureBox1.Location = new System.Drawing.Point(1171, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1177, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 173;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Oz_Cam.Properties.Resources.franja_pelicula_estatica___inferior;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1220, 989);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1128, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 174;
            this.pictureBox2.TabStop = false;
            // 
            // txtPosicion_2
            // 
            this.txtPosicion_2.Location = new System.Drawing.Point(115, 284);
            this.txtPosicion_2.Name = "txtPosicion_2";
            this.txtPosicion_2.Size = new System.Drawing.Size(22, 20);
            this.txtPosicion_2.TabIndex = 175;
            this.txtPosicion_2.Text = "2";
            this.txtPosicion_2.Visible = false;
            // 
            // txtPosicion_3
            // 
            this.txtPosicion_3.Location = new System.Drawing.Point(115, 310);
            this.txtPosicion_3.Name = "txtPosicion_3";
            this.txtPosicion_3.Size = new System.Drawing.Size(22, 20);
            this.txtPosicion_3.TabIndex = 176;
            this.txtPosicion_3.Text = "3";
            this.txtPosicion_3.Visible = false;
            // 
            // txtPosicion_4
            // 
            this.txtPosicion_4.Location = new System.Drawing.Point(115, 336);
            this.txtPosicion_4.Name = "txtPosicion_4";
            this.txtPosicion_4.Size = new System.Drawing.Size(22, 20);
            this.txtPosicion_4.TabIndex = 177;
            this.txtPosicion_4.Text = "4";
            this.txtPosicion_4.Visible = false;
            // 
            // txtval4
            // 
            this.txtval4.Location = new System.Drawing.Point(144, 336);
            this.txtval4.Name = "txtval4";
            this.txtval4.Size = new System.Drawing.Size(22, 20);
            this.txtval4.TabIndex = 181;
            this.txtval4.Text = "0";
            this.txtval4.Visible = false;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(144, 310);
            this.txtval3.Name = "txtval3";
            this.txtval3.Size = new System.Drawing.Size(22, 20);
            this.txtval3.TabIndex = 180;
            this.txtval3.Text = "0";
            this.txtval3.Visible = false;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(144, 284);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(22, 20);
            this.txtval2.TabIndex = 179;
            this.txtval2.Text = "0";
            this.txtval2.Visible = false;
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(144, 258);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(22, 20);
            this.txtval1.TabIndex = 178;
            this.txtval1.Text = "0";
            this.txtval1.Visible = false;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.txtval4);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.txtPosicion_4);
            this.Controls.Add(this.txtPosicion_3);
            this.Controls.Add(this.txtPosicion_2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picbox4);
            this.Controls.Add(this.picbox3);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.txtPosicion_1);
            this.Controls.Add(this.txtMemoria);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.btnDER);
            this.Controls.Add(this.btnIZQ);
            this.Controls.Add(this.picbox_abj1);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.picbox_arr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_abj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_arr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.PictureBox picbox_arr1;
        private Bunifu.UI.WinForms.BunifuImageButton btnIZQ;
        internal System.Windows.Forms.PictureBox picbox_abj1;
        internal System.Windows.Forms.PictureBox picbox1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton btnDER;
        internal System.Windows.Forms.Timer tm_derecha;
        internal System.Windows.Forms.Timer tm_izquierda;
        private System.Windows.Forms.TextBox txtMemoria;
        private System.Windows.Forms.TextBox txtPosicion_1;
        internal System.Windows.Forms.PictureBox picbox4;
        internal System.Windows.Forms.PictureBox picbox3;
        internal System.Windows.Forms.PictureBox picbox2;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPosicion_4;
        private System.Windows.Forms.TextBox txtPosicion_3;
        private System.Windows.Forms.TextBox txtPosicion_2;
        private System.Windows.Forms.TextBox txtval4;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval1;
    }
}
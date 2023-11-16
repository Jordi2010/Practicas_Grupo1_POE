namespace LoginC_
{
    partial class VistaLogin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaLogin2));
            pictureCerrarVista = new PictureBox();
            pictureMinimizarVista = new PictureBox();
            lblNotificacion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureCerrarVista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMinimizarVista).BeginInit();
            SuspendLayout();
            // 
            // pictureCerrarVista
            // 
            pictureCerrarVista.BackColor = Color.White;
            pictureCerrarVista.Image = (Image)resources.GetObject("pictureCerrarVista.Image");
            pictureCerrarVista.Location = new Point(759, 10);
            pictureCerrarVista.Name = "pictureCerrarVista";
            pictureCerrarVista.Size = new Size(32, 30);
            pictureCerrarVista.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureCerrarVista.TabIndex = 10;
            pictureCerrarVista.TabStop = false;
            pictureCerrarVista.Click += pictureCerrarVista_Click;
            // 
            // pictureMinimizarVista
            // 
            pictureMinimizarVista.BackColor = Color.White;
            pictureMinimizarVista.Image = (Image)resources.GetObject("pictureMinimizarVista.Image");
            pictureMinimizarVista.Location = new Point(721, 10);
            pictureMinimizarVista.Name = "pictureMinimizarVista";
            pictureMinimizarVista.Size = new Size(32, 30);
            pictureMinimizarVista.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureMinimizarVista.TabIndex = 9;
            pictureMinimizarVista.TabStop = false;
            // 
            // lblNotificacion
            // 
            lblNotificacion.AutoSize = true;
            lblNotificacion.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotificacion.ForeColor = SystemColors.HighlightText;
            lblNotificacion.Location = new Point(218, 191);
            lblNotificacion.Name = "lblNotificacion";
            lblNotificacion.Size = new Size(316, 39);
            lblNotificacion.TabIndex = 8;
            lblNotificacion.Text = "Hola usuario nuevo";
            // 
            // VistaLogin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureCerrarVista);
            Controls.Add(pictureMinimizarVista);
            Controls.Add(lblNotificacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaLogin2";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaLogin2";
            ((System.ComponentModel.ISupportInitialize)pictureCerrarVista).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMinimizarVista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureCerrarVista;
        private PictureBox pictureMinimizarVista;
        private Label lblNotificacion;
    }
}
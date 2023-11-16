namespace LoginC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIniciar = new Button();
            linkRecuperar = new LinkLabel();
            pictureBoxMinimizar = new PictureBox();
            pictureBoxCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(418, 39);
            label1.Name = "label1";
            label1.Size = new Size(147, 39);
            label1.TabIndex = 1;
            label1.Text = "Mi Login";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveCaptionText;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(306, 106);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(395, 19);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.InactiveCaptionText;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(306, 210);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(395, 19);
            txtPass.TabIndex = 3;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(64, 64, 64);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.LightGray;
            btnIniciar.Location = new Point(434, 297);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(147, 40);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "INICIAR SESIÓN";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // linkRecuperar
            // 
            linkRecuperar.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkRecuperar.AutoSize = true;
            linkRecuperar.LinkColor = Color.DimGray;
            linkRecuperar.Location = new Point(428, 383);
            linkRecuperar.Name = "linkRecuperar";
            linkRecuperar.Size = new Size(161, 15);
            linkRecuperar.TabIndex = 5;
            linkRecuperar.TabStop = true;
            linkRecuperar.Text = "¿Has olvidado tu contraseña?";
            linkRecuperar.LinkClicked += linkRecuperar_LinkClicked;
            // 
            // pictureBoxMinimizar
            // 
            pictureBoxMinimizar.BackColor = Color.White;
            pictureBoxMinimizar.Image = (Image)resources.GetObject("pictureBoxMinimizar.Image");
            pictureBoxMinimizar.Location = new Point(724, 6);
            pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            pictureBoxMinimizar.Size = new Size(32, 30);
            pictureBoxMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimizar.TabIndex = 6;
            pictureBoxMinimizar.TabStop = false;
            pictureBoxMinimizar.Click += pictureBoxMinimizar_Click;
            // 
            // pictureBoxCerrar
            // 
            pictureBoxCerrar.BackColor = Color.White;
            pictureBoxCerrar.Image = (Image)resources.GetObject("pictureBoxCerrar.Image");
            pictureBoxCerrar.Location = new Point(762, 6);
            pictureBoxCerrar.Name = "pictureBoxCerrar";
            pictureBoxCerrar.Size = new Size(32, 30);
            pictureBoxCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrar.TabIndex = 7;
            pictureBoxCerrar.TabStop = false;
            pictureBoxCerrar.Click += pictureBoxCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxCerrar);
            Controls.Add(pictureBoxMinimizar);
            Controls.Add(linkRecuperar);
            Controls.Add(btnIniciar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIniciar;
        private LinkLabel linkRecuperar;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxMinimizar;
        private PictureBox pictureBoxCerrar;
    }
}
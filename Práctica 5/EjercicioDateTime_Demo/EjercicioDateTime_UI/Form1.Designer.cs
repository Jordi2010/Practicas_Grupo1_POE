namespace EjercicioDateTime_UI
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(301, 24);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Verificación de edad";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(215, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(367, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(322, 123);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular edad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(322, 184);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(155, 21);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "validación de edad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label lblResultado;
    }
}
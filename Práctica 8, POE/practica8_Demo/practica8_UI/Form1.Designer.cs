namespace practica8_UI
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            dataGridViewDato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDato).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 26);
            label1.Name = "label1";
            label1.Size = new Size(314, 25);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de clientes UNIVO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 95);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 145);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 196);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 249);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 4;
            label5.Text = "Dirección:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(22, 316);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(101, 36);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(170, 316);
            button2.Name = "button2";
            button2.Size = new Size(83, 36);
            button2.TabIndex = 6;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(291, 316);
            button3.Name = "button3";
            button3.Size = new Size(105, 36);
            button3.TabIndex = 7;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtId.Location = new Point(137, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(259, 33);
            txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(137, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 33);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(137, 188);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(259, 33);
            txtApellido.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(137, 241);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(259, 33);
            txtDireccion.TabIndex = 11;
            // 
            // dataGridViewDato
            // 
            dataGridViewDato.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewDato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDato.Location = new Point(429, 87);
            dataGridViewDato.Name = "dataGridViewDato";
            dataGridViewDato.ReadOnly = true;
            dataGridViewDato.RowTemplate.Height = 25;
            dataGridViewDato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDato.Size = new Size(345, 265);
            dataGridViewDato.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDato);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button button2;
        private Button button3;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private DataGridView dataGridViewDato;
    }
}
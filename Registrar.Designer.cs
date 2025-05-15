namespace El_Cafetal_APP
{
    partial class Registrar
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
            btnRegistrar = new Button();
            label4 = new Label();
            comboRol = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            txtId = new TextBox();
            linkInicio = new LinkLabel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Silver;
            btnRegistrar.Location = new Point(173, 302);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 37);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(224, 18);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 16;
            label4.Text = "Rol";
            // 
            // comboRol
            // 
            comboRol.FormattingEnabled = true;
            comboRol.Items.AddRange(new object[] { "Supervisor", "Agricultor", "Proveedor" });
            comboRol.Location = new Point(173, 36);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(121, 23);
            comboRol.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 253);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 14;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 196);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 13;
            label2.Text = "Correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 145);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(184, 253);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 11;
            txtClave.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(184, 196);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 95);
            label5.Name = "label5";
            label5.Size = new Size(28, 19);
            label5.TabIndex = 19;
            label5.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(184, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 18;
            // 
            // linkInicio
            // 
            linkInicio.AutoSize = true;
            linkInicio.Location = new Point(239, 360);
            linkInicio.Name = "linkInicio";
            linkInicio.Size = new Size(75, 15);
            linkInicio.TabIndex = 20;
            linkInicio.TabStop = true;
            linkInicio.Text = "Iniciar sesión";
            linkInicio.LinkClicked += linkInicio_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(126, 360);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 21;
            label6.Text = "¿Ya tienes cuenta?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.planta;
            pictureBox1.Location = new Point(357, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 175, 80);
            ClientSize = new Size(478, 404);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(linkInicio);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(comboRol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Name = "Registrar";
            Text = "Registrar";
            Load += Registrar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label label4;
        private ComboBox comboRol;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtId;
        private LinkLabel linkInicio;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
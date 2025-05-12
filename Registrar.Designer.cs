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
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(335, 305);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 37);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 6);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 16;
            label4.Text = "Rol";
            // 
            // comboRol
            // 
            comboRol.FormattingEnabled = true;
            comboRol.Items.AddRange(new object[] { "Supervisor", "Agricultor", "Proveedor" });
            comboRol.Location = new Point(315, 24);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(121, 23);
            comboRol.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 250);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 14;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 190);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 13;
            label2.Text = "Correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 139);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(346, 247);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 11;
            txtClave.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(346, 190);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(346, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 89);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 19;
            label5.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(346, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 18;
            // 
            // linkInicio
            // 
            linkInicio.AutoSize = true;
            linkInicio.Location = new Point(400, 354);
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
            label6.Location = new Point(288, 354);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 21;
            label6.Text = "¿Ya tienes cuenta?";
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
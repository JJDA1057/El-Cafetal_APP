namespace El_Cafetal_APP
{
    partial class Login
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
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(202, 57);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(112, 23);
            txtCorreo.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(205, 142);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(112, 23);
            txtClave.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(205, 229);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(109, 49);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 65);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Correo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 145);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(499, 388);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Cursor = Cursors.Default;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtClave;
        private Button btnIniciar;
        private Label label1;
        private Label label2;
    }
}
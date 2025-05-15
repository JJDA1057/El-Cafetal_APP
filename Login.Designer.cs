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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(225, 181);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(112, 23);
            txtCorreo.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(225, 244);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(112, 23);
            txtClave.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Silver;
            btnIniciar.Location = new Point(225, 305);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 32);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 181);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 3;
            label1.Text = "Correo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 244);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.planta_de_cafe;
            pictureBox1.Location = new Point(186, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 175, 80);
            ClientSize = new Size(488, 388);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtClave;
        private Button btnIniciar;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
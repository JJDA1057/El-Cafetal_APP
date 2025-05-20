namespace El_Cafetal_APP
{
    partial class AgregarCultivo
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
            btnCultivo = new Button();
            btnLote = new Button();
            btnPlanta = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCultivo
            // 
            btnCultivo.BackColor = Color.Silver;
            btnCultivo.Location = new Point(198, 59);
            btnCultivo.Margin = new Padding(3, 4, 3, 4);
            btnCultivo.Name = "btnCultivo";
            btnCultivo.Size = new Size(149, 51);
            btnCultivo.TabIndex = 0;
            btnCultivo.Text = "Agregar cultivo";
            btnCultivo.UseVisualStyleBackColor = false;
            btnCultivo.Click += btnCultivo_Click;
            // 
            // btnLote
            // 
            btnLote.BackColor = Color.Silver;
            btnLote.Location = new Point(198, 160);
            btnLote.Margin = new Padding(3, 4, 3, 4);
            btnLote.Name = "btnLote";
            btnLote.Size = new Size(149, 51);
            btnLote.TabIndex = 1;
            btnLote.Text = "Agregar lote";
            btnLote.UseVisualStyleBackColor = false;
            // 
            // btnPlanta
            // 
            btnPlanta.BackColor = Color.Silver;
            btnPlanta.Location = new Point(198, 267);
            btnPlanta.Margin = new Padding(3, 4, 3, 4);
            btnPlanta.Name = "btnPlanta";
            btnPlanta.Size = new Size(149, 51);
            btnPlanta.TabIndex = 2;
            btnPlanta.Text = "Agregar planta";
            btnPlanta.UseVisualStyleBackColor = false;
            btnPlanta.Click += btnPlanta_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(229, 115, 115);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(422, 28);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.los_granos_de_cafe;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(198, 356);
            button1.Name = "button1";
            button1.Size = new Size(149, 45);
            button1.TabIndex = 5;
            button1.Text = "Pedidos";
            button1.UseVisualStyleBackColor = false;
            // 
            // AgregarCultivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(533, 428);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnPlanta);
            Controls.Add(btnLote);
            Controls.Add(btnCultivo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarCultivo";
            Text = "AgregarCultivo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCultivo;
        private Button btnLote;
        private Button btnPlanta;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
namespace El_Cafetal_APP
{
    partial class NuevoCultivo
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtUbi = new TextBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIdUsuario = new TextBox();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(139, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtUbi
            // 
            txtUbi.Location = new Point(139, 153);
            txtUbi.Name = "txtUbi";
            txtUbi.Size = new Size(100, 23);
            txtUbi.TabIndex = 2;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(139, 216);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(100, 23);
            txtFechaInicio.TabIndex = 3;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(139, 285);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(100, 23);
            txtFechaFin.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.Location = new Point(329, 330);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 6;
            label1.Text = "id: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 7;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 153);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 8;
            label3.Text = "Ubicación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 220);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 9;
            label4.Text = "Fecha de inicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 289);
            label5.Name = "label5";
            label5.Size = new Size(115, 19);
            label5.TabIndex = 10;
            label5.Text = "Fecha del final: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 345);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 12;
            label6.Text = "Id encargado: ";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(139, 341);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(229, 115, 115);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(402, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.planta_cafe_2;
            pictureBox1.Location = new Point(308, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // NuevoCultivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(491, 397);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(label6);
            Controls.Add(txtIdUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtUbi);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "NuevoCultivo";
            Text = "NuevoCultivo";
            Load += NuevoCultivo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtUbi;
        private TextBox txtFechaInicio;
        private TextBox txtFechaFin;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtIdUsuario;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
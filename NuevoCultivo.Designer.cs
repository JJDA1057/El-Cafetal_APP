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
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(220, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(220, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtUbi
            // 
            txtUbi.Location = new Point(220, 190);
            txtUbi.Name = "txtUbi";
            txtUbi.Size = new Size(100, 23);
            txtUbi.TabIndex = 2;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(220, 253);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(100, 23);
            txtFechaInicio.TabIndex = 3;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(220, 322);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(100, 23);
            txtFechaFin.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(463, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Crear";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 67);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 6;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 134);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 198);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 8;
            label3.Text = "ubicacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 256);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 9;
            label4.Text = "fecha_inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 325);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 10;
            label5.Text = "fecha fin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 381);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 12;
            label6.Text = "id usuario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(220, 378);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 11;
            // 
            // NuevoCultivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
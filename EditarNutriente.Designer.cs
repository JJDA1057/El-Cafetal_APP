namespace El_Cafetal_APP
{
    partial class EditarNutriente
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            Ccantidad = new TextBox();
            Ctipo = new TextBox();
            Cid_proveedor = new TextBox();
            Cnombre = new TextBox();
            Cid_insumo = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(151, 306);
            label8.Name = "label8";
            label8.Size = new Size(167, 27);
            label8.TabIndex = 15;
            label8.Text = "Fecha Entrega";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(186, 265);
            label7.Name = "label7";
            label7.Size = new Size(93, 17);
            label7.TabIndex = 16;
            label7.Text = "Cantidad";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 11F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(178, 214);
            label6.Name = "label6";
            label6.Size = new Size(129, 22);
            label6.TabIndex = 17;
            label6.Text = "Proveedor ID";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(186, 168);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 18;
            label5.Text = "Tipo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(192, 117);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 19;
            label4.Text = "Nombre";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(200, 62);
            label2.Name = "label2";
            label2.Size = new Size(66, 27);
            label2.TabIndex = 20;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(126, 335);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 14;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // Ccantidad
            // 
            Ccantidad.BackColor = SystemColors.AppWorkspace;
            Ccantidad.BorderStyle = BorderStyle.FixedSingle;
            Ccantidad.Font = new Font("Segoe UI", 11F);
            Ccantidad.Location = new Point(126, 284);
            Ccantidad.Margin = new Padding(3, 2, 3, 2);
            Ccantidad.Name = "Ccantidad";
            Ccantidad.Size = new Size(219, 27);
            Ccantidad.TabIndex = 10;
            // 
            // Ctipo
            // 
            Ctipo.BackColor = SystemColors.AppWorkspace;
            Ctipo.BorderStyle = BorderStyle.FixedSingle;
            Ctipo.Font = new Font("Segoe UI", 11F);
            Ctipo.Location = new Point(126, 188);
            Ctipo.Margin = new Padding(3, 2, 3, 2);
            Ctipo.Name = "Ctipo";
            Ctipo.Size = new Size(219, 27);
            Ctipo.TabIndex = 11;
            // 
            // Cid_proveedor
            // 
            Cid_proveedor.BackColor = SystemColors.AppWorkspace;
            Cid_proveedor.BorderStyle = BorderStyle.FixedSingle;
            Cid_proveedor.Font = new Font("Segoe UI", 11F);
            Cid_proveedor.Location = new Point(126, 238);
            Cid_proveedor.Margin = new Padding(3, 2, 3, 2);
            Cid_proveedor.Name = "Cid_proveedor";
            Cid_proveedor.Size = new Size(219, 27);
            Cid_proveedor.TabIndex = 12;
            // 
            // Cnombre
            // 
            Cnombre.BackColor = SystemColors.AppWorkspace;
            Cnombre.BorderStyle = BorderStyle.FixedSingle;
            Cnombre.Font = new Font("Segoe UI", 11F);
            Cnombre.Location = new Point(126, 142);
            Cnombre.Margin = new Padding(3, 2, 3, 2);
            Cnombre.Name = "Cnombre";
            Cnombre.Size = new Size(219, 27);
            Cnombre.TabIndex = 13;
            // 
            // Cid_insumo
            // 
            Cid_insumo.BackColor = SystemColors.AppWorkspace;
            Cid_insumo.BorderStyle = BorderStyle.FixedSingle;
            Cid_insumo.Font = new Font("Segoe UI", 11F);
            Cid_insumo.Location = new Point(126, 91);
            Cid_insumo.Margin = new Padding(3, 2, 3, 2);
            Cid_insumo.Name = "Cid_insumo";
            Cid_insumo.Size = new Size(219, 27);
            Cid_insumo.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(74, 74, 74);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(433, 214);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(151, 68);
            button2.TabIndex = 23;
            button2.Text = "Volver a Nutriente";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(74, 74, 74);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(433, 117);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 68);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(236, 14);
            label1.Name = "label1";
            label1.Size = new Size(226, 41);
            label1.TabIndex = 21;
            label1.Text = "Editar Nutriente";
            // 
            // EditarNutriente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(777, 395);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(Ccantidad);
            Controls.Add(Ctipo);
            Controls.Add(Cid_proveedor);
            Controls.Add(Cnombre);
            Controls.Add(Cid_insumo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarNutriente";
            Text = "EditarNutriente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private TextBox Ccantidad;
        private TextBox Ctipo;
        private TextBox Cid_proveedor;
        private TextBox Cnombre;
        private TextBox Cid_insumo;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}
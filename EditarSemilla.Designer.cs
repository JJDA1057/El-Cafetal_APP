namespace El_Cafetal_APP
{
    partial class EditarSemilla
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
            Cid_insumo = new TextBox();
            Cnombre = new TextBox();
            Cid_proveedor = new TextBox();
            Ctipo = new TextBox();
            Ccantidad = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // Cid_insumo
            // 
            Cid_insumo.BackColor = SystemColors.AppWorkspace;
            Cid_insumo.BorderStyle = BorderStyle.FixedSingle;
            Cid_insumo.Font = new Font("Segoe UI", 11F);
            Cid_insumo.Location = new Point(87, 79);
            Cid_insumo.Margin = new Padding(3, 2, 3, 2);
            Cid_insumo.Name = "Cid_insumo";
            Cid_insumo.Size = new Size(219, 27);
            Cid_insumo.TabIndex = 0;
            // 
            // Cnombre
            // 
            Cnombre.BackColor = SystemColors.AppWorkspace;
            Cnombre.BorderStyle = BorderStyle.FixedSingle;
            Cnombre.Font = new Font("Segoe UI", 11F);
            Cnombre.Location = new Point(87, 130);
            Cnombre.Margin = new Padding(3, 2, 3, 2);
            Cnombre.Name = "Cnombre";
            Cnombre.Size = new Size(219, 27);
            Cnombre.TabIndex = 1;
            // 
            // Cid_proveedor
            // 
            Cid_proveedor.BackColor = SystemColors.AppWorkspace;
            Cid_proveedor.BorderStyle = BorderStyle.FixedSingle;
            Cid_proveedor.Font = new Font("Segoe UI", 11F);
            Cid_proveedor.Location = new Point(87, 226);
            Cid_proveedor.Margin = new Padding(3, 2, 3, 2);
            Cid_proveedor.Name = "Cid_proveedor";
            Cid_proveedor.Size = new Size(219, 27);
            Cid_proveedor.TabIndex = 1;
            // 
            // Ctipo
            // 
            Ctipo.BackColor = SystemColors.AppWorkspace;
            Ctipo.BorderStyle = BorderStyle.FixedSingle;
            Ctipo.Font = new Font("Segoe UI", 11F);
            Ctipo.Location = new Point(87, 176);
            Ctipo.Margin = new Padding(3, 2, 3, 2);
            Ctipo.Name = "Ctipo";
            Ctipo.Size = new Size(219, 27);
            Ctipo.TabIndex = 1;
            // 
            // Ccantidad
            // 
            Ccantidad.BackColor = SystemColors.AppWorkspace;
            Ccantidad.BorderStyle = BorderStyle.FixedSingle;
            Ccantidad.Font = new Font("Segoe UI", 11F);
            Ccantidad.Location = new Point(87, 272);
            Ccantidad.Margin = new Padding(3, 2, 3, 2);
            Ccantidad.Name = "Ccantidad";
            Ccantidad.Size = new Size(219, 27);
            Ccantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(275, 7);
            label1.Name = "label1";
            label1.Size = new Size(208, 41);
            label1.TabIndex = 3;
            label1.Text = "Editar Semillas";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(74, 74, 74);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(483, 94);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 68);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(74, 74, 74);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(483, 191);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(151, 68);
            button2.TabIndex = 5;
            button2.Text = "Volver a Semillas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(87, 323);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(161, 50);
            label2.Name = "label2";
            label2.Size = new Size(66, 27);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(153, 105);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 11F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(147, 156);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 8;
            label5.Text = "Tipo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 11F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(138, 202);
            label6.Name = "label6";
            label6.Size = new Size(129, 22);
            label6.TabIndex = 8;
            label6.Text = "Proveedor ID";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(147, 253);
            label7.Name = "label7";
            label7.Size = new Size(93, 17);
            label7.TabIndex = 8;
            label7.Text = "Cantidad";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 11F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(112, 294);
            label8.Name = "label8";
            label8.Size = new Size(167, 27);
            label8.TabIndex = 8;
            label8.Text = "Fecha Entrega";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditarSemilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(780, 370);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Ccantidad);
            Controls.Add(Ctipo);
            Controls.Add(Cid_proveedor);
            Controls.Add(Cnombre);
            Controls.Add(Cid_insumo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarSemilla";
            Text = "EditarSemilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Cid_insumo;
        private TextBox Cnombre;
        private TextBox Cid_proveedor;
        private TextBox Ctipo;
        private TextBox Ccantidad;
        private Label label1;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
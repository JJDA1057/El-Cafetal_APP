namespace El_Cafetal_APP
{
    partial class AgregarInsumo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Cid = new TextBox();
            Cnombre = new TextBox();
            Ctipo = new TextBox();
            Cprov = new TextBox();
            Ccantidad = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(262, 7);
            label1.Name = "label1";
            label1.Size = new Size(249, 45);
            label1.TabIndex = 0;
            label1.Text = "Agregar Insumo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(115, 61);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(115, 114);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(115, 164);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(85, 219);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 4;
            label5.Text = "#ID Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(115, 271);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 5;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(115, 324);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha Entrega";
            // 
            // Cid
            // 
            Cid.Location = new Point(44, 92);
            Cid.Margin = new Padding(3, 2, 3, 2);
            Cid.Name = "Cid";
            Cid.Size = new Size(219, 23);
            Cid.TabIndex = 7;
            // 
            // Cnombre
            // 
            Cnombre.Location = new Point(44, 142);
            Cnombre.Margin = new Padding(3, 2, 3, 2);
            Cnombre.Name = "Cnombre";
            Cnombre.Size = new Size(219, 23);
            Cnombre.TabIndex = 8;
            // 
            // Ctipo
            // 
            Ctipo.Location = new Point(44, 191);
            Ctipo.Margin = new Padding(3, 2, 3, 2);
            Ctipo.Name = "Ctipo";
            Ctipo.Size = new Size(219, 23);
            Ctipo.TabIndex = 9;
            // 
            // Cprov
            // 
            Cprov.Location = new Point(44, 242);
            Cprov.Margin = new Padding(3, 2, 3, 2);
            Cprov.Name = "Cprov";
            Cprov.Size = new Size(219, 23);
            Cprov.TabIndex = 10;
            // 
            // Ccantidad
            // 
            Ccantidad.Location = new Point(44, 302);
            Ccantidad.Margin = new Padding(3, 2, 3, 2);
            Ccantidad.Name = "Ccantidad";
            Ccantidad.Size = new Size(219, 23);
            Ccantidad.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 347);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(74, 74, 74);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(390, 101);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 64);
            button1.TabIndex = 13;
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
            button2.Location = new Point(390, 248);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 64);
            button2.TabIndex = 14;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AgregarInsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 412);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(Ccantidad);
            Controls.Add(Cprov);
            Controls.Add(Ctipo);
            Controls.Add(Cnombre);
            Controls.Add(Cid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarInsumo";
            Text = "AgregarInsumo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Cid;
        private TextBox Cnombre;
        private TextBox Ctipo;
        private TextBox Cprov;
        private TextBox Ccantidad;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}
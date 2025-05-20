namespace El_Cafetal_APP
{
    partial class AgregarPlanta
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Cid_planta = new TextBox();
            Cobservacion = new TextBox();
            Cestado = new TextBox();
            Cid_lote = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(156, 102, 68);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(564, 298);
            button2.Name = "button2";
            button2.Size = new Size(173, 90);
            button2.TabIndex = 8;
            button2.Text = "Volver a Plantas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 102, 68);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(564, 169);
            button1.Name = "button1";
            button1.Size = new Size(173, 90);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(315, 30);
            label1.Name = "label1";
            label1.Size = new Size(266, 50);
            label1.TabIndex = 6;
            label1.Text = "Agregar Planta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(171, 106);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 9;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(124, 385);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 10;
            label3.Text = "Fecha Plantacion";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(137, 314);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 11;
            label4.Text = "Observacion";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(155, 245);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 12;
            label5.Text = "Estado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(155, 179);
            label6.Name = "label6";
            label6.Size = new Size(74, 28);
            label6.TabIndex = 13;
            label6.Text = "ID Lote";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cid_planta
            // 
            Cid_planta.Location = new Point(75, 149);
            Cid_planta.Name = "Cid_planta";
            Cid_planta.Size = new Size(250, 27);
            Cid_planta.TabIndex = 14;
            // 
            // Cobservacion
            // 
            Cobservacion.Location = new Point(75, 355);
            Cobservacion.Name = "Cobservacion";
            Cobservacion.Size = new Size(250, 27);
            Cobservacion.TabIndex = 15;
            // 
            // Cestado
            // 
            Cestado.Location = new Point(75, 276);
            Cestado.Name = "Cestado";
            Cestado.Size = new Size(250, 27);
            Cestado.TabIndex = 16;
            // 
            // Cid_lote
            // 
            Cid_lote.Location = new Point(75, 210);
            Cid_lote.Name = "Cid_lote";
            Cid_lote.Size = new Size(250, 27);
            Cid_lote.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 416);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // AgregarPlanta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 137, 104);
            ClientSize = new Size(936, 518);
            Controls.Add(dateTimePicker1);
            Controls.Add(Cid_lote);
            Controls.Add(Cestado);
            Controls.Add(Cobservacion);
            Controls.Add(Cid_planta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "AgregarPlanta";
            Text = "AgregarPlanta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Cid_planta;
        private TextBox Cobservacion;
        private TextBox Cestado;
        private TextBox Cid_lote;
        private DateTimePicker dateTimePicker1;
    }
}
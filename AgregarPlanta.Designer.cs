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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(74, 74, 74);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(413, 41);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(101, 34);
            button2.TabIndex = 8;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(74, 74, 74);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(278, 41);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(301, -2);
            label1.Name = "label1";
            label1.Size = new Size(213, 41);
            label1.TabIndex = 6;
            label1.Text = "Agregar Planta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(96, 76);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 9;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(54, 285);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 10;
            label3.Text = "Fecha Plantacion";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(66, 232);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 11;
            label4.Text = "Observacion";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(82, 180);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 12;
            label5.Text = "Estado";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(82, 130);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 13;
            label6.Text = "ID Lote";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cid_planta
            // 
            Cid_planta.Location = new Point(12, 108);
            Cid_planta.Margin = new Padding(3, 2, 3, 2);
            Cid_planta.Name = "Cid_planta";
            Cid_planta.Size = new Size(219, 23);
            Cid_planta.TabIndex = 14;
            // 
            // Cobservacion
            // 
            Cobservacion.Location = new Point(12, 262);
            Cobservacion.Margin = new Padding(3, 2, 3, 2);
            Cobservacion.Name = "Cobservacion";
            Cobservacion.Size = new Size(219, 23);
            Cobservacion.TabIndex = 15;
            // 
            // Cestado
            // 
            Cestado.Location = new Point(12, 203);
            Cestado.Margin = new Padding(3, 2, 3, 2);
            Cestado.Name = "Cestado";
            Cestado.Size = new Size(219, 23);
            Cestado.TabIndex = 16;
            // 
            // Cid_lote
            // 
            Cid_lote.Location = new Point(12, 154);
            Cid_lote.Margin = new Padding(3, 2, 3, 2);
            Cid_lote.Name = "Cid_lote";
            Cid_lote.Size = new Size(219, 23);
            Cid_lote.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 308);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 108);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(515, 223);
            dataGridView1.TabIndex = 19;
            // 
            // AgregarPlanta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(819, 388);
            Controls.Add(dataGridView1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarPlanta";
            Text = "AgregarPlanta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}
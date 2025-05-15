namespace El_Cafetal_APP
{
    partial class GeneroReporte
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnNuevo = new Button();
            button2 = new Button();
            button3 = new Button();
            btnLimpiar = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            lblReportes = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(lblReportes);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 89);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnNuevo);
            panel2.Location = new Point(-2, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 100);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Peru;
            btnNuevo.Location = new Point(60, 41);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(89, 33);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Location = new Point(201, 41);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 1;
            button2.Text = "Reportar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Location = new Point(357, 41);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SaddleBrown;
            btnLimpiar.Location = new Point(514, 41);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 33);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Peru;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(309, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 307);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(371, 180);
            dataGridView1.TabIndex = 0;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReportes.Location = new Point(206, 26);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(229, 25);
            lblReportes.TabIndex = 0;
            lblReportes.Text = "Generacion de Reportes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 7);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Reportes:";
            // 
            // GeneroReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(680, 501);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GeneroReporte";
            Text = "GeneroReporte";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLimpiar;
        private Button button3;
        private Button button2;
        private Button btnNuevo;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label lblReportes;
        private Label label1;
    }
}
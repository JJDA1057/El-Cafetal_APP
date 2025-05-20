namespace El_Cafetal_APP
{
    partial class Nutrientes
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(788, 316);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(156, 102, 68);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(-10, -5);
            button2.Name = "button2";
            button2.Size = new Size(108, 44);
            button2.TabIndex = 7;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 50);
            label1.TabIndex = 6;
            label1.Text = "NUTRIENTES";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 102, 68);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(131, 87);
            button1.Name = "button1";
            button1.Size = new Size(165, 44);
            button1.TabIndex = 5;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(156, 102, 68);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(355, 87);
            button4.Name = "button4";
            button4.Size = new Size(165, 44);
            button4.TabIndex = 8;
            button4.Text = "Consumo Por Lote";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(156, 102, 68);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 16F);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(566, 87);
            button5.Name = "button5";
            button5.Size = new Size(165, 44);
            button5.TabIndex = 9;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Nutrientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 137, 104);
            ClientSize = new Size(902, 502);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Nutrientes";
            Text = "Nutrientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}
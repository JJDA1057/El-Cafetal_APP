namespace El_Cafetal_APP
{
    partial class Plantas
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
            label1 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(156, 102, 68);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(-10, -4);
            button2.Name = "button2";
            button2.Size = new Size(108, 44);
            button2.TabIndex = 7;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(365, -4);
            label1.Name = "label1";
            label1.Size = new Size(190, 39);
            label1.TabIndex = 6;
            label1.Text = "PLANTAS";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(156, 102, 68);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 16F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(77, 79);
            button3.Name = "button3";
            button3.Size = new Size(165, 44);
            button3.TabIndex = 4;
            button3.Text = "Nueva";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 314);
            dataGridView1.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(156, 102, 68);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 16F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(504, 79);
            button4.Name = "button4";
            button4.Size = new Size(165, 44);
            button4.TabIndex = 9;
            button4.Text = "Borrar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Plantas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 137, 104);
            ClientSize = new Size(949, 544);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button3);
            Name = "Plantas";
            Text = "Plantas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
    }
}
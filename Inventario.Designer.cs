namespace El_Cafetal_APP
{
    partial class Inventario
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 102, 68);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(151, 151);
            button1.Name = "button1";
            button1.Size = new Size(240, 56);
            button1.TabIndex = 0;
            button1.Text = "Semillas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(156, 102, 68);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(151, 286);
            button2.Name = "button2";
            button2.Size = new Size(240, 56);
            button2.TabIndex = 1;
            button2.Text = "Plantas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(156, 102, 68);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 16F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(151, 422);
            button3.Name = "button3";
            button3.Size = new Size(240, 56);
            button3.TabIndex = 2;
            button3.Text = "Nutrientes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(110, 44, 46);
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, -2);
            label1.Name = "label1";
            label1.Size = new Size(1064, 73);
            label1.TabIndex = 3;
            label1.Text = "INVENTARIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 137, 104);
            ClientSize = new Size(1054, 567);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Inventario";
            Text = "Inventario";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}
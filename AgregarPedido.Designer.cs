namespace El_Cafetal_APP
{
    partial class AgregarPedido
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
            Cid = new TextBox();
            Cmaterial = new TextBox();
            Cnombre = new TextBox();
            Ccontacto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 50);
            label1.TabIndex = 0;
            label1.Text = "Agregar Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(144, 117);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(134, 197);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(127, 278);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 3;
            label4.Text = "Contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(127, 360);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 4;
            label5.Text = "Materiales";
            // 
            // Cid
            // 
            Cid.Location = new Point(90, 148);
            Cid.Name = "Cid";
            Cid.Size = new Size(183, 27);
            Cid.TabIndex = 5;
            // 
            // Cmaterial
            // 
            Cmaterial.Location = new Point(90, 400);
            Cmaterial.Name = "Cmaterial";
            Cmaterial.Size = new Size(183, 27);
            Cmaterial.TabIndex = 6;
            // 
            // Cnombre
            // 
            Cnombre.Location = new Point(90, 248);
            Cnombre.Name = "Cnombre";
            Cnombre.Size = new Size(183, 27);
            Cnombre.TabIndex = 7;
            // 
            // Ccontacto
            // 
            Ccontacto.Location = new Point(90, 330);
            Ccontacto.Name = "Ccontacto";
            Ccontacto.Size = new Size(183, 27);
            Ccontacto.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 102, 68);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(517, 158);
            button1.Name = "button1";
            button1.Size = new Size(146, 92);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(156, 102, 68);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(517, 296);
            button2.Name = "button2";
            button2.Size = new Size(146, 92);
            button2.TabIndex = 10;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AgregarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 137, 104);
            ClientSize = new Size(925, 528);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Ccontacto);
            Controls.Add(Cnombre);
            Controls.Add(Cmaterial);
            Controls.Add(Cid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarPedido";
            Text = "AgregarPedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Cid;
        private TextBox Cmaterial;
        private TextBox Cnombre;
        private TextBox Ccontacto;
        private Button button1;
        private Button button2;
    }
}
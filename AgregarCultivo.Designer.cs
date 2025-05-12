namespace El_Cafetal_APP
{
    partial class AgregarCultivo
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
            btnCultivo = new Button();
            btnLote = new Button();
            btnPlanta = new Button();
            SuspendLayout();
            // 
            // btnCultivo
            // 
            btnCultivo.Location = new Point(166, 85);
            btnCultivo.Name = "btnCultivo";
            btnCultivo.Size = new Size(130, 38);
            btnCultivo.TabIndex = 0;
            btnCultivo.Text = "Agregar cultivo";
            btnCultivo.UseVisualStyleBackColor = true;
            btnCultivo.Click += btnCultivo_Click;
            // 
            // btnLote
            // 
            btnLote.Location = new Point(166, 161);
            btnLote.Name = "btnLote";
            btnLote.Size = new Size(130, 38);
            btnLote.TabIndex = 1;
            btnLote.Text = "Agregar lote";
            btnLote.UseVisualStyleBackColor = true;
            // 
            // btnPlanta
            // 
            btnPlanta.Location = new Point(166, 241);
            btnPlanta.Name = "btnPlanta";
            btnPlanta.Size = new Size(130, 38);
            btnPlanta.TabIndex = 2;
            btnPlanta.Text = "Agregar planta";
            btnPlanta.UseVisualStyleBackColor = true;
            // 
            // AgregarCultivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 421);
            Controls.Add(btnPlanta);
            Controls.Add(btnLote);
            Controls.Add(btnCultivo);
            Name = "AgregarCultivo";
            Text = "AgregarCultivo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCultivo;
        private Button btnLote;
        private Button btnPlanta;
    }
}
namespace El_Cafetal_APP
{
    partial class Lote
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
            lblLotes = new Label();
            dataGridView1 = new DataGridView();
            btnBorrar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblLotes
            // 
            lblLotes.AutoSize = true;
            lblLotes.Font = new Font("Segoe UI", 22F);
            lblLotes.ForeColor = Color.Black;
            lblLotes.Location = new Point(311, 9);
            lblLotes.Name = "lblLotes";
            lblLotes.Size = new Size(89, 41);
            lblLotes.TabIndex = 2;
            lblLotes.Text = "Lotes";
            lblLotes.TextAlign = ContentAlignment.MiddleCenter;
            lblLotes.Click += this.label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 139);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(717, 244);
            dataGridView1.TabIndex = 3;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(74, 74, 74);
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.Font = new Font("Segoe UI", 16F);
            btnBorrar.ForeColor = SystemColors.ControlLightLight;
            btnBorrar.Location = new Point(588, 87);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 33);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(74, 74, 74);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 16F);
            btnVolver.ForeColor = SystemColors.ControlLightLight;
            btnVolver.Location = new Point(2, -1);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 33);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // Lote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(785, 419);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            Controls.Add(dataGridView1);
            Controls.Add(lblLotes);
            Name = "Lote";
            Text = "Lote";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLotes;
        private DataGridView dataGridView1;
        private Button btnBorrar;
        private Button btnVolver;
    }
}
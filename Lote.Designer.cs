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
            dataGridViewLotes = new DataGridView();
            btnBorrar = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLotes).BeginInit();
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
            // 
            // dataGridViewLotes
            // 
            dataGridViewLotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLotes.Location = new Point(21, 139);
            dataGridViewLotes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewLotes.Name = "dataGridViewLotes";
            dataGridViewLotes.RowHeadersWidth = 51;
            dataGridViewLotes.Size = new Size(752, 244);
            dataGridViewLotes.TabIndex = 3;
            dataGridViewLotes.CellContentClick += dataGridViewLotes_CellContentClick;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(74, 74, 74);
            btnBorrar.FlatStyle = FlatStyle.Popup;
            btnBorrar.Font = new Font("Segoe UI", 16F);
            btnBorrar.ForeColor = SystemColors.ControlLightLight;
            btnBorrar.Location = new Point(629, 87);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 33);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click_1;
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
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(229, 115, 115);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(690, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 25);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Lote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            ClientSize = new Size(785, 419);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            Controls.Add(dataGridViewLotes);
            Controls.Add(lblLotes);
            Name = "Lote";
            Text = "Lote";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLotes;
        private DataGridView dataGridViewLotes;
        private Button btnBorrar;
        private Button btnVolver;
        private Button btnSalir;
    }
}
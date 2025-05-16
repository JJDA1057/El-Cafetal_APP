namespace El_Cafetal_APP
{
    partial class btnEliminar
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
            btnHome = new Button();
            btn = new Button();
            button2 = new Button();
            dataviewDatos = new DataGridView();
            tbl_ID = new DataGridViewTextBoxColumn();
            tblNombre = new DataGridViewTextBoxColumn();
            tblFecha = new DataGridViewTextBoxColumn();
            tblEstado = new DataGridViewTextBoxColumn();
            tblObservar = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblLote = new Label();
            lblPlanta = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegistrar = new Button();
            txtLote = new TextBox();
            txtPlanta_name = new TextBox();
            txtFecha = new TextBox();
            txtEstado = new TextBox();
            txtObserva = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataviewDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataviewDatos);
            panel1.Location = new Point(288, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 450);
            panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkRed;
            btnHome.Location = new Point(416, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(126, 50);
            btnHome.TabIndex = 10;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += button1_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.DarkRed;
            btn.Location = new Point(321, 326);
            btn.Name = "btn";
            btn.Size = new Size(126, 38);
            btn.TabIndex = 9;
            btn.Text = "Eliminar";
            btn.UseVisualStyleBackColor = false;
            btn.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Location = new Point(73, 326);
            button2.Name = "button2";
            button2.Size = new Size(126, 38);
            button2.TabIndex = 8;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataviewDatos
            // 
            dataviewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewDatos.Columns.AddRange(new DataGridViewColumn[] { tbl_ID, tblNombre, tblFecha, tblEstado, tblObservar });
            dataviewDatos.Location = new Point(1, 56);
            dataviewDatos.Name = "dataviewDatos";
            dataviewDatos.Size = new Size(543, 150);
            dataviewDatos.TabIndex = 0;
            dataviewDatos.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // tbl_ID
            // 
            tbl_ID.HeaderText = "ID:";
            tbl_ID.Name = "tbl_ID";
            // 
            // tblNombre
            // 
            tblNombre.HeaderText = "Nombre:";
            tblNombre.Name = "tblNombre";
            // 
            // tblFecha
            // 
            tblFecha.HeaderText = "Fecha Siembra:";
            tblFecha.Name = "tblFecha";
            // 
            // tblEstado
            // 
            tblEstado.HeaderText = "Estado:";
            tblEstado.Name = "tblEstado";
            // 
            // tblObservar
            // 
            tblObservar.HeaderText = "Observaciones";
            tblObservar.Name = "tblObservar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 23);
            label1.TabIndex = 1;
            label1.Text = "Añadir Una Nueva Planta: ";
            label1.Click += label1_Click;
            // 
            // lblLote
            // 
            lblLote.AutoSize = true;
            lblLote.Location = new Point(8, 57);
            lblLote.Name = "lblLote";
            lblLote.Size = new Size(33, 15);
            lblLote.TabIndex = 2;
            lblLote.Text = "Lote:";
            lblLote.Click += label2_Click;
            // 
            // lblPlanta
            // 
            lblPlanta.AutoSize = true;
            lblPlanta.Location = new Point(8, 130);
            lblPlanta.Name = "lblPlanta";
            lblPlanta.Size = new Size(93, 15);
            lblPlanta.TabIndex = 3;
            lblPlanta.Text = "Nombre Planta: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 192);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Siembra: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 262);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 312);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 6;
            label6.Text = "Observaciones: ";
            label6.Click += label6_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SandyBrown;
            btnRegistrar.Location = new Point(147, 391);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 38);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtLote
            // 
            txtLote.Location = new Point(60, 59);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(213, 23);
            txtLote.TabIndex = 8;
            // 
            // txtPlanta_name
            // 
            txtPlanta_name.Location = new Point(107, 130);
            txtPlanta_name.Name = "txtPlanta_name";
            txtPlanta_name.Size = new Size(166, 23);
            txtPlanta_name.TabIndex = 9;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(120, 192);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(153, 23);
            txtFecha.TabIndex = 10;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(60, 259);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(213, 23);
            txtEstado.TabIndex = 11;
            // 
            // txtObserva
            // 
            txtObserva.Location = new Point(95, 306);
            txtObserva.Multiline = true;
            txtObserva.Name = "txtObserva";
            txtObserva.Size = new Size(178, 73);
            txtObserva.TabIndex = 12;
            // 
            // btnEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(832, 450);
            Controls.Add(txtObserva);
            Controls.Add(txtEstado);
            Controls.Add(txtFecha);
            Controls.Add(txtPlanta_name);
            Controls.Add(txtLote);
            Controls.Add(btnRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPlanta);
            Controls.Add(lblLote);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "btnEliminar";
            Text = "AñadirPlantas";
            Load += AñadirPlantas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataviewDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataviewDatos;
        private Label label1;
        private Button btn;
        private Button button2;
        private DataGridViewTextBoxColumn tbl_ID;
        private DataGridViewTextBoxColumn tblNombre;
        private DataGridViewTextBoxColumn tblFecha;
        private DataGridViewTextBoxColumn tblEstado;
        private DataGridViewTextBoxColumn tblObservar;
        private Label lblLote;
        private Label lblPlanta;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegistrar;
        private TextBox txtLote;
        private TextBox txtPlanta_name;
        private TextBox txtFecha;
        private TextBox txtEstado;
        private TextBox txtObserva;
        private Button btnHome;
    }
}
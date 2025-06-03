
namespace El_Cafetal_APP
{
    partial class AgregarLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarLote));
            txtId = new TextBox();
            txtIDuser = new TextBox();
            txtEstado = new TextBox();
            txtArea = new TextBox();
            txtCant_plant = new TextBox();
            txtObserv = new TextBox();
            txtId_Cultivo = new TextBox();
            lblID = new Label();
            lbl_iduser = new Label();
            lblFechaInit = new Label();
            lblEstado = new Label();
            lblFechaFinal = new Label();
            lblArea = new Label();
            lblPlantas = new Label();
            lblObserva = new Label();
            lblCultivo = new Label();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFinal = new DateTimePicker();
            pictureBox1 = new PictureBox();
            btnAgregar = new Button();
            btnVolver_Cultivos = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(115, 23);
            txtId.TabIndex = 1;
            // 
            // txtIDuser
            // 
            txtIDuser.Location = new Point(133, 59);
            txtIDuser.Name = "txtIDuser";
            txtIDuser.Size = new Size(115, 23);
            txtIDuser.TabIndex = 2;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(133, 150);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(115, 23);
            txtEstado.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(133, 232);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(115, 23);
            txtArea.TabIndex = 6;
            // 
            // txtCant_plant
            // 
            txtCant_plant.Location = new Point(133, 284);
            txtCant_plant.Name = "txtCant_plant";
            txtCant_plant.Size = new Size(115, 23);
            txtCant_plant.TabIndex = 7;
            // 
            // txtObserv
            // 
            txtObserv.Location = new Point(133, 329);
            txtObserv.Name = "txtObserv";
            txtObserv.Size = new Size(115, 23);
            txtObserv.TabIndex = 8;
            // 
            // txtId_Cultivo
            // 
            txtId_Cultivo.Location = new Point(133, 380);
            txtId_Cultivo.Name = "txtId_Cultivo";
            txtId_Cultivo.Size = new Size(115, 23);
            txtId_Cultivo.TabIndex = 9;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(97, 12);
            lblID.Name = "lblID";
            lblID.Size = new Size(30, 19);
            lblID.TabIndex = 10;
            lblID.Text = "id: ";
            // 
            // lbl_iduser
            // 
            lbl_iduser.AutoSize = true;
            lbl_iduser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_iduser.Location = new Point(17, 59);
            lbl_iduser.Name = "lbl_iduser";
            lbl_iduser.Size = new Size(110, 19);
            lbl_iduser.TabIndex = 11;
            lbl_iduser.Text = "id del Usuario: ";
            // 
            // lblFechaInit
            // 
            lblFechaInit.AutoSize = true;
            lblFechaInit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInit.Location = new Point(32, 107);
            lblFechaInit.Name = "lblFechaInit";
            lblFechaInit.Size = new Size(95, 19);
            lblFechaInit.TabIndex = 12;
            lblFechaInit.Text = "Fecha Inicio:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(67, 150);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(60, 19);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFinal.Location = new Point(2, 200);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(136, 19);
            lblFechaFinal.TabIndex = 14;
            lblFechaFinal.Text = "Fecha Finalizacion:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(80, 232);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(47, 19);
            lblArea.TabIndex = 15;
            lblArea.Text = "Area:";
            // 
            // lblPlantas
            // 
            lblPlantas.AutoSize = true;
            lblPlantas.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblPlantas.Location = new Point(-13, 284);
            lblPlantas.Name = "lblPlantas";
            lblPlantas.Size = new Size(145, 17);
            lblPlantas.TabIndex = 16;
            lblPlantas.Text = "Cantidad De Plantas:";
            // 
            // lblObserva
            // 
            lblObserva.AutoSize = true;
            lblObserva.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObserva.Location = new Point(17, 329);
            lblObserva.Name = "lblObserva";
            lblObserva.Size = new Size(113, 19);
            lblObserva.TabIndex = 17;
            lblObserva.Text = "Observaciones:";
            // 
            // lblCultivo
            // 
            lblCultivo.AutoSize = true;
            lblCultivo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCultivo.Location = new Point(30, 380);
            lblCultivo.Name = "lblCultivo";
            lblCultivo.Size = new Size(102, 19);
            lblCultivo.TabIndex = 18;
            lblCultivo.Text = "id del Cultivo:";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(133, 107);
            dateTimePickerInicio.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(218, 23);
            dateTimePickerInicio.TabIndex = 19;
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.Location = new Point(132, 197);
            dateTimePickerFinal.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(219, 23);
            dateTimePickerFinal.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(363, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 229);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Silver;
            btnAgregar.Location = new Point(407, 373);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 34);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver_Cultivos
            // 
            btnVolver_Cultivos.BackColor = Color.Silver;
            btnVolver_Cultivos.Location = new Point(407, 322);
            btnVolver_Cultivos.Name = "btnVolver_Cultivos";
            btnVolver_Cultivos.Size = new Size(123, 34);
            btnVolver_Cultivos.TabIndex = 23;
            btnVolver_Cultivos.Text = "Volver";
            btnVolver_Cultivos.UseVisualStyleBackColor = false;
            btnVolver_Cultivos.Click += btnVolver_Cultivos_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(229, 115, 115);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(491, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 25);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // AgregarLote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(197, 225, 165);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(588, 430);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver_Cultivos);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePickerFinal);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(lblCultivo);
            Controls.Add(lblObserva);
            Controls.Add(lblPlantas);
            Controls.Add(lblArea);
            Controls.Add(lblFechaFinal);
            Controls.Add(lblEstado);
            Controls.Add(lblFechaInit);
            Controls.Add(lbl_iduser);
            Controls.Add(lblID);
            Controls.Add(txtId_Cultivo);
            Controls.Add(txtObserv);
            Controls.Add(txtCant_plant);
            Controls.Add(txtArea);
            Controls.Add(txtEstado);
            Controls.Add(txtIDuser);
            Controls.Add(txtId);
            Name = "AgregarLote";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtIDuser;
        private TextBox txtEstado;
        private TextBox txtArea;
        private TextBox txtCant_plant;
        private TextBox txtObserv;
        private TextBox txtId_Cultivo;
        private Label lblID;
        private Label lbl_iduser;
        private Label lblFechaInit;
        private Label lblEstado;
        private Label lblFechaFinal;
        private Label lblArea;
        private Label lblPlantas;
        private Label lblObserva;
        private Label lblCultivo;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFinal;
        private PictureBox pictureBox1;
        private Button btnAgregar;
        private Button btnVolver_Cultivos;
        private Button btnSalir;
    }
}
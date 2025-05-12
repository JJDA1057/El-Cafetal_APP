namespace El_Cafetal_APP
{
    partial class Admin
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
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            txtRol = new TextBox();
            txtEstado = new TextBox();
            btnConsultar = new Button();
            btnConsultarTodos = new Button();
            btnBorrar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnLimpiar = new Button();
            btnCrearUsuario = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(151, 142);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(151, 196);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 3;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(151, 253);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(100, 23);
            txtRol.TabIndex = 4;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(151, 308);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 6;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(336, 22);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(138, 42);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnConsultarTodos
            // 
            btnConsultarTodos.Location = new Point(336, 78);
            btnConsultarTodos.Name = "btnConsultarTodos";
            btnConsultarTodos.Size = new Size(138, 42);
            btnConsultarTodos.TabIndex = 8;
            btnConsultarTodos.Text = "Consultar Todos";
            btnConsultarTodos.UseVisualStyleBackColor = true;
            btnConsultarTodos.Click += btnConsultarTodos_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(336, 131);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(138, 42);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(336, 182);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 42);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(518, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(66, 29);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 31);
            label1.Name = "label1";
            label1.Size = new Size(30, 22);
            label1.TabIndex = 13;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 140);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 15;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 196);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 16;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 253);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 17;
            label5.Text = "Id rol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 306);
            label6.Name = "label6";
            label6.Size = new Size(124, 22);
            label6.TabIndex = 18;
            label6.Text = "Estado usuario:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(134, 351);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 32);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(336, 239);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(138, 42);
            btnCrearUsuario.TabIndex = 20;
            btnCrearUsuario.Text = "Crear usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(596, 401);
            Controls.Add(btnCrearUsuario);
            Controls.Add(btnLimpiar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnBorrar);
            Controls.Add(btnConsultarTodos);
            Controls.Add(btnConsultar);
            Controls.Add(txtEstado);
            Controls.Add(txtRol);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private TextBox txtRol;
        private TextBox txtEstado;
        private Button btnConsultar;
        private Button btnConsultarTodos;
        private Button btnBorrar;
        private Button btnActualizar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnLimpiar;
        private Button btnCrearUsuario;
    }
}
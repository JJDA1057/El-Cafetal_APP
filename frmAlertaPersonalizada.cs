using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Cafetal_APP
{
    using System.Drawing;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.IO;

    public partial class frmAlertaPersonalizada : Form
    {
        public frmAlertaPersonalizada(string titulo, string mensaje, Color colorFondo, Image icono)
        {
            InitializeComponent();
            ConfigurarFormulario(titulo, mensaje, colorFondo, icono);
            this.Load += (s, e) => this.Activate();
        }

        private void ConfigurarFormulario(string titulo, string mensaje, Color colorFondo, Image icono)
        {
            // Configuración básica ajustada
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = colorFondo;
            this.Padding = new Padding(2);

            // Panel principal mejorado
            var panelContenido = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(20),
                ColumnCount = 2,
                RowCount = 2,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            panelContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // icono
            panelContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // texto
            panelContenido.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panelContenido.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            

            var pbIcono = new PictureBox
            {
                Image = icono,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 10, 10, 10)
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = colorFondo,
                AutoSize = true,
                Dock = DockStyle.Top
            };

            var lblMensaje = new Label
            {
                Text = mensaje,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.DimGray,
                AutoSize = true,
                MaximumSize = new Size(400, 0),
                Dock = DockStyle.Fill
            };
            panelContenido.Controls.Add(pbIcono, 0, 0);
            panelContenido.SetRowSpan(pbIcono, 2); // icono ocupa dos filas

            panelContenido.Controls.Add(lblTitulo, 1, 0);
            panelContenido.Controls.Add(lblMensaje, 1, 1);


            // Botón de cierre mejorado
            var panelBoton = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 60,
                Padding = new Padding(0, 10, 20, 10)
            };

            var btnCerrar = new Button
            {
                Text = "CERRAR",
                FlatStyle = FlatStyle.Flat,
                BackColor = colorFondo,
                ForeColor = Color.White,
                Size = new Size(120, 40),
                Anchor = AnchorStyles.Right,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Click += (s, e) => this.Close();

            panelBoton.Controls.Add(btnCerrar);
            panelBoton.Controls.SetChildIndex(btnCerrar, 0);
            panelContenido.Controls.Add(panelBoton);
            this.Controls.Add(panelContenido);

            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Click += (s, e) => this.Close();

            // Cálculo dinámico del tamaño
            int alturaNecesaria = lblMensaje.Bottom + 70;
            this.Size = new Size(600, Math.Max(alturaNecesaria, 200));

            // Agregar controles
            panelContenido.Controls.AddRange(new Control[] { pbIcono, lblTitulo, lblMensaje, btnCerrar });
            this.Controls.Add(panelContenido);

            // Animación de entrada mejorada
            this.Opacity = 0;
            var timer = new Timer { Interval = 10 };
            timer.Tick += (s, e) => {
                if ((this.Opacity += 0.05) >= 1) timer.Stop();
            };
            timer.Start();
        }

        // Bordes redondeados mejorados
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int radius = 15;

            // Crear el path dentro del using
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, Width, Height);

                // Crear forma redondeada
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Aplicar región
                this.Region = new Region(path);

                // Dibujar borde
                using (Pen pen = new Pen(this.BackColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // Permitir arrastrar el formulario
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
        }
    }
}

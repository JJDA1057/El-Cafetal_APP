using API_CAFETAL.Interface;
using El_Cafetal_APP.Clases;
using El_Cafetal_APP.Enums;
using El_Cafetal_APP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Cafetal_APP
{
    public partial class Inventario : Form, IInventarioObserver
    {
        private System.Windows.Forms.Timer _timerInventario;

        private MonitorInventario _monitor;
        private List<IInventarioObserver> _observadores = new List<IInventarioObserver> ();
        public Inventario()
        {
            InitializeComponent();
            this.Load += Inventario_Load;
        }

       


        private async void Inventario_Load(object sender, EventArgs e)
        {
            var insumoService = new InsumoServices();
            _monitor = new MonitorInventario(insumoService);
            _monitor.AgregarObservador(this);

            await _monitor.VerificarInventario();

            // Iniciar Timer
            _timerInventario = new System.Windows.Forms.Timer();
            _timerInventario.Interval = 120000; // 60,000 milisegundos = 60 segundos
            _timerInventario.Tick += Timer_Tick;
            _timerInventario.Start();
        }
        private async void Timer_Tick(object sender, EventArgs e)
        {
              await _monitor.VerificarInventario(); // esto notificará si encuentra insumos en alerta
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _timerInventario?.Stop();
            _timerInventario?.Dispose();
            base.OnFormClosing(e);
        }




        public void Actualizar(clsInsumo insumo, TipoAlerta tipoAlerta)
        {
            string mensaje = $"⚠ El insumo '{insumo.nombre}' con ID: #{insumo.id_insumo} tiene un nivel de alerta: {tipoAlerta.ToString().ToUpper()}...Cantidad restante: {insumo.cantidad}";

            // Verificar carga de imágenes
            string rutaImagenes = Path.Combine(Application.StartupPath, "Imagenes");

            var (titulo, color, icono) = tipoAlerta switch
            {
                TipoAlerta.Critica => (
                    "🚨 ALERTA CRÍTICA",
                    Color.FromArgb(231, 76, 60),  // Rojo vibrante
                    CargarImagenSegura(Path.Combine(rutaImagenes, "CriticalIcon.png"))
                ),
                TipoAlerta.Baja => (
                    "⚠ ALERTA BAJA",
                    Color.FromArgb(241, 196, 15),  // Amarillo oscuro
                    CargarImagenSegura(Path.Combine(rutaImagenes, "WarningIcon.png"))
                ),
                _ => (
                    "📌 NOTIFICACIÓN",
                    Color.FromArgb(52, 152, 219),  // Azul claro
                    CargarImagenSegura(Path.Combine(rutaImagenes, "InfoIcon.png"))
                )
            };

            var alerta = new frmAlertaPersonalizada(titulo, mensaje, color, icono ?? SystemIcons.Warning.ToBitmap());
            alerta.Show();
        }

        private Image CargarImagenSegura(string ruta)
        {
            try
            {
                return File.Exists(ruta) ? Image.FromFile(ruta) : null;
            }
            catch
            {
                return null; // Imagen por defecto si falla
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Semillas semillas = new Semillas())
                {
                    this.Hide(); // Oculta Inventario
                    semillas.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (Plantas plantas = new Plantas())
                {
                    this.Hide(); // Oculta Inventario
                    plantas.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (Nutrientes nutri = new Nutrientes())
                {
                    this.Hide(); // Oculta Inventario
                    nutri.ShowDialog(); // Muestra Semillas como modal
                    this.Show(); // Al cerrar Semillas, vuelve a mostrar Inventario
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

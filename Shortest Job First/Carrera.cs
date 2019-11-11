using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using WMPLib;

namespace Shortest_Job_First
{
    public partial class Carrera : MaterialForm
    {
        // Data.
        /* Un delegate es un tipo que representa referencias a métodos con una lista de parámetros determinada y un tipo de valor devuelto.
         * Los delegados pueden usarse para definir métodos callback.
         * Un delegado me permite enviar un método como parámetro a otro método.
         */
        delegate void dele(PictureBox pb, int laY, int vel);

        // Cola.
        Queue<string> cola = new Queue<string>();

        // ListViewItem.
        ListViewItem pos = new ListViewItem();

        // Música.
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        // Constructor.
        public Carrera()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema 1.
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);

            // Reiniciar botón.
            this.btnReiniciar.Enabled = false;

            // Música a reproducir.
            player.URL = "Obertura.mp3";
            player.controls.stop();
        }

        // Form.
        private void Carrera_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        // Iniciar el juego.
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.btnIniciar.Enabled = false;
            this.btnReiniciar.Enabled = false;
            this.btnSalir.Enabled = false;
            player.controls.play();

            Thread[] hilos = new Thread[5];
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i] = new Thread(Metodo);
                hilos[i].Name = "caballo" + i;
                hilos[i].Start();
            }
        }

        // Método a enviar al Hilo.
        public void Metodo()
        {
            int num = 10;
            dele elDelegado = new dele(Mover);

            if (Thread.CurrentThread.Name.Equals("caballo0"))
            {
                elDelegado.Invoke(pbCaballo1, pbCaballo1.Location.Y, num);
                cola.Enqueue("Caballo 1");
            }
            else if (Thread.CurrentThread.Name.Equals("caballo1"))
            {
                elDelegado.Invoke(pbCaballo2, pbCaballo2.Location.Y, num);
                cola.Enqueue("Caballo 2");
            }
            else if (Thread.CurrentThread.Name.Equals("caballo2"))
            {
                elDelegado.Invoke(pbCaballo3, pbCaballo3.Location.Y, num);
                cola.Enqueue("Caballo 3");
            }
            else if (Thread.CurrentThread.Name.Equals("caballo3"))
            {
                elDelegado.Invoke(pbCaballo4, pbCaballo4.Location.Y, num);
                cola.Enqueue("Caballo 4");
            }
            else if (Thread.CurrentThread.Name.Equals("caballo4"))
            {
                elDelegado.Invoke(pbCaballo5, pbCaballo5.Location.Y, num);
                cola.Enqueue("Caballo 5");
            }
            else
            {
                // No hay más hilos.
            }

            string[] ca = cola.ToArray();
            foreach(var i in ca)
            {
                pos = lvLugares.Items.Add(i);
            }

            cola.Clear();
            this.btnReiniciar.Enabled = true;
        }

        // Mover caballos.
        public void Mover(PictureBox pb, int laY, int velocidad)
        {
            Random rd = new Random();
            int num1, num2, num3, num4, num5;
            int meta = this.Width - pbCaballo1.Width - 20;

            for (int i = 0; i < meta; i++)
            {
                pb.Location = new Point(i, laY);
                num1 = rd.Next(40);
                num2 = rd.Next(40);
                num3 = rd.Next(40);
                num4 = rd.Next(40);
                num5 = rd.Next(40);

                if (Thread.CurrentThread.Name.Equals("caballo0"))
                {
                    Thread.Sleep(num1);
                }
                else if (Thread.CurrentThread.Name.Equals("caballo1"))
                {
                    Thread.Sleep(num2);
                }
                else if (Thread.CurrentThread.Name.Equals("caballo2"))
                {
                    Thread.Sleep(num3);
                }
                else if (Thread.CurrentThread.Name.Equals("caballo3"))
                {
                    Thread.Sleep(num4);
                }
                else if (Thread.CurrentThread.Name.Equals("caballo4"))
                {
                    Thread.Sleep(num5);
                }
                else
                {
                    // No hay más hilos.
                }
            }
        }

        // Reiniciar el juego.
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            pbCaballo1.Left = 12;
            pbCaballo2.Left = 12;
            pbCaballo3.Left = 12;
            pbCaballo4.Left = 12;
            pbCaballo5.Left = 12;

            player.controls.stop();
            this.lvLugares.Items.Clear();
            this.btnIniciar.Enabled = true;
            this.btnSalir.Enabled = true;
        }

        // Salir del sistema.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Cerrar el sistema y terminar procesos.
        private void Carrera_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

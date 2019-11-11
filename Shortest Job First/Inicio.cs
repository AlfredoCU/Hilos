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

namespace Shortest_Job_First
{
    public partial class Inicio : MaterialForm
    {
        // Constructor.
        public Inicio()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema 1.
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        // Abrir ventana del juego.
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Carrera abrir = new Carrera();
            this.Hide();
            abrir.ShowDialog();
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
    }
}

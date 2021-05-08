using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SITE
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            //se cierra la ventana actual
            this.Hide();
            //se abre la pantalla de historial
            Historial historial = new Historial();
            historial.Show();
        }
    }
}

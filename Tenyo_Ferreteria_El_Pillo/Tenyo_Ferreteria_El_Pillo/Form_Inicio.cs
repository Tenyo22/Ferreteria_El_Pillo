using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenyo_Ferreteria_El_Pillo
{
    public partial class Form_Inicio : Form
    {

        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form_Registros ventRegistrar = new Form_Registros();
            ventRegistrar.Show();
            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Form_Venta_Tenyo ventVenta = new Form_Venta_Tenyo();
            ventVenta.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form_Ver_Datos_Tenyo ventBuscar = new Form_Ver_Datos_Tenyo();
            ventBuscar.Show();
        }

        private void Form_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

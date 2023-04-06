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
    public partial class Form_Buscar : Form
    {
        public Form_Buscar()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridView1, "EXEC buscar_producto_tenyo '" + textBox1.Text + "'");
            Conexion_Maestra_Tenyo.Grid(dataGridView2, "EXEC buscar_producto_tenyo '" + textBox1.Text + "'");
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            // Saber el valor que pulso. El 13 es enter en codigo ascci
            // Es lo mismo que hace el codigo de barras, es un enter o salto de linea
            if(e.KeyValue == 13)
            {
                MessageBox.Show("Funciona: " + e.KeyValue);
            }
        }
    }
}

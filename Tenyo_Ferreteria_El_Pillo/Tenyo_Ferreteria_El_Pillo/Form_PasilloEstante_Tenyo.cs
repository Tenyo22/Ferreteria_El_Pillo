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
    public partial class Form_PasilloEstante_Tenyo : Form
    {
        public Form_PasilloEstante_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_PasilloEstante_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridViewPasillo, "EXEC select_pasillo_tenyo");
            Conexion_Maestra_Tenyo.Grid(dataGridViewEstante, "EXEC select_estante_tenyo");
        }

        private void btnAgregarPasillo_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNumPasillo.Text) || String.IsNullOrWhiteSpace(txtNumPasillo.Text))
            {
                MessageBox.Show("Por Favor, Ingrese un Pasillo Valido", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtNumPasillo.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_pasillo_tenyo '" + txtNumPasillo.Text.Trim() + "'");
                Conexion_Maestra_Tenyo.Grid(dataGridViewPasillo, "EXEC select_pasillo_tenyo");
                txtNumPasillo.Clear();
                txtNumPasillo.Focus();
            }
        }

        private void btnAgregarEstante_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtEstante.Text) || String.IsNullOrWhiteSpace(txtEstante.Text))
            {
                MessageBox.Show("Por Favor, Ingresa un Valor de Estante Valido", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtEstante.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_estante_tenyo '" + txtEstante.Text + "'");
                Conexion_Maestra_Tenyo.Grid(dataGridViewEstante, "EXEC select_estante_tenyo");
                txtEstante.Clear();
                txtEstante.Focus();
            }
        }
    }
}

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
    public partial class Form_Marca_Tenyo : Form
    {
        public Form_Marca_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_Marca_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridViewMarca, "EXEC select_marca_tenyo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNombreMarca.Text) || String.IsNullOrWhiteSpace(txtNombreMarca.Text))
            {
                MessageBox.Show("Por Favor, Ingresa una Marca Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtNombreMarca.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_marca_tenyo '" + txtNombreMarca.Text.Trim() + "'");
                txtNombreMarca.Clear();
                txtNombreMarca.Focus();
                Conexion_Maestra_Tenyo.Grid(dataGridViewMarca, "EXEC select_marca_tenyo");
            }
        }
    }
}

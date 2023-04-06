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
    public partial class Form_Material_Tenyo : Form
    {
        public Form_Material_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_Material_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridViewMaterial, "EXEC select_material_tenyo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDescripcionMaterial.Text) || String.IsNullOrWhiteSpace(txtDescripcionMaterial.Text))
            {
                MessageBox.Show("Por Favor, Ingrese un Material Valido", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtDescripcionMaterial.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_material_tenyo '" + txtDescripcionMaterial.Text + "'");
                txtDescripcionMaterial.Clear();
                txtDescripcionMaterial.Focus();
                Conexion_Maestra_Tenyo.Grid(dataGridViewMaterial, "EXEC select_material_tenyo");
            }
        }
    }
}

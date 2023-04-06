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
    public partial class Form_Categoria_Tenyo : Form
    {
        public Form_Categoria_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_Categoria_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridViewCategoria, "EXEC select_categoria_tenyo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNombreCategoria.Text.Trim()) || String.IsNullOrWhiteSpace(txtNombreCategoria.Text.Trim()))
            {
                MessageBox.Show("Por Favor, Ingrese una categoria valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtNombreCategoria.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_categoria_tenyo '" + txtNombreCategoria.Text.Trim() + "'");
                Conexion_Maestra_Tenyo.Grid(dataGridViewCategoria, "EXEC select_categoria_tenyo");
            }
        }
    }
}

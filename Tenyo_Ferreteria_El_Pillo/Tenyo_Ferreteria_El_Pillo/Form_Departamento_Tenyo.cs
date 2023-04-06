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
    public partial class Form_Departamento_Tenyo : Form
    {
        public Form_Departamento_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_Departamento_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridViewDepartamento, "EXEC select_departamento_tenyo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDepartamento.Text.Trim()) || String.IsNullOrWhiteSpace(txtDepartamento.Text.Trim())){
                MessageBox.Show("Por Favor, Ingrese un Departamento Valido", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtDepartamento.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_departamento_tenyo '" + txtDepartamento.Text.Trim() + "'");
                txtDepartamento.Clear();
                txtDepartamento.Focus();
                Conexion_Maestra_Tenyo.Grid(dataGridViewDepartamento, "EXEC select_departamento_tenyo");
            }
        }
    }
}

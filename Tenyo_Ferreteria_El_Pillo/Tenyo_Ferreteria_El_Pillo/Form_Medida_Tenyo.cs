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
    public partial class Form_Medida_Tenyo : Form
    {
        public Form_Medida_Tenyo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNombreMedida.Text) || String.IsNullOrWhiteSpace(txtNombreMedida.Text))
            {
                MessageBox.Show("Por Favor, Ingresa una Medida Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtNombreMedida.Focus();
            }else if(String.IsNullOrEmpty(txtAbrevMedida.Text) || String.IsNullOrWhiteSpace(txtAbrevMedida.Text))
            {
                MessageBox.Show("Por Favor, Ingresa una Abreviatura Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtAbrevMedida.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_medida_tenyo '" + txtNombreMedida.Text +"', '" + txtAbrevMedida.Text + "'");
                txtNombreMedida.Clear();
                txtAbrevMedida.Clear();
                txtNombreMedida.Focus();
            }
        }
    }
}

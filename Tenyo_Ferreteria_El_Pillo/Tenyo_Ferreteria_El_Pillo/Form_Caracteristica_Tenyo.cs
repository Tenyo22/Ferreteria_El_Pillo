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
    public partial class Form_Caracteristica_Tenyo : Form
    {
        public Form_Caracteristica_Tenyo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtClaveCar.Text) || String.IsNullOrWhiteSpace(txtClaveCar.Text))
            {
                MessageBox.Show("Por Favor, Ingresa una Clave Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtClaveCar.Focus();
            }else if(String.IsNullOrEmpty(txtNombreCar.Text) || String.IsNullOrWhiteSpace(txtNombreCar.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una Caracteristica Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtNombreCar.Focus();
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_caracteristica_tenyo '" +
                    txtClaveCar.Text.Trim() + "', '" +
                    txtNombreCar.Text.Trim() + "'");
                txtClaveCar.Clear();
                txtNombreCar.Clear();
                txtClaveCar.Focus();
            }
        }
    }
}

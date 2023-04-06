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
    public partial class Form_Empleado_Tenyo : Form
    {
        public Form_Empleado_Tenyo()
        {
            InitializeComponent();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Por Favor, Ingrese solo Numeros", "VALOR INVALIDO!", MessageBoxButtons.OK);
                txtTelefono.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtClaveEmpleado.Text) || String.IsNullOrWhiteSpace(txtClaveEmpleado.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una Clave Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtClaveEmpleado.Focus();
            }else if(String.IsNullOrEmpty(txtNombreEmpleado.Text) || String.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                MessageBox.Show("Por Favor, Ingrese el Nombre del Empleado", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtNombreEmpleado.Focus();
            }else if(String.IsNullOrEmpty(txtApellido1.Text) || String.IsNullOrWhiteSpace(txtApellido1.Text))
            {
                MessageBox.Show("Por Favor, Ingrese el Apellido del Empleado", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtApellido1.Focus();
            }else if(String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por Favor, Ingrese un Numero Telefonico", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtTelefono.Focus();
            }
            else
            {
                /*MessageBox.Show("EXEC insertar_empleado_tenyo '" + 
                    txtClaveEmpleado.Text + "', '" + 
                    txtNombreEmpleado.Text + "', '" +
                    txtApellido1.Text + "', '" +
                    txtApellido2.Text + "', '" +
                    txtTelefono.Text + "'");*/
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_empleado_tenyo '" +
                    txtClaveEmpleado.Text + "', '" +
                    txtNombreEmpleado.Text + "', '" +
                    txtApellido1.Text + "', '" +
                    txtApellido2.Text + "', '" +
                    txtTelefono.Text + "'");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClaveEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtTelefono.Clear();
            txtClaveEmpleado.Focus();
        }
    }
}

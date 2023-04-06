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
    public partial class Form_Proveedor_Tenyo : Form
    {
        public Form_Proveedor_Tenyo()
        {
            InitializeComponent();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)){
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Por Favor, Ingrese solo numeros" ,"CAMPO INVALIDO!", MessageBoxButtons.OK);
                txtTelefono.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtClaveProv.Text) || String.IsNullOrWhiteSpace(txtClaveProv.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una Clave Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtClaveProv.Focus();
            }else if(String.IsNullOrEmpty(txtRazonSocial.Text) || String.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una Razon Social Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtRazonSocial.Focus();
            }else if(String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una Direccion Valida", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtDireccion.Focus();
            }else if(String.IsNullOrEmpty(txtTelefono.Text) || String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por Favor, Ingrese un Telefono Valido", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtTelefono.Focus();
            }else if(String.IsNullOrEmpty(txtContacto.Text) || String.IsNullOrWhiteSpace(txtContacto.Text))
            {
                MessageBox.Show("Por Favor, Ingrese un Contacto Valido", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtContacto.Focus();
            }
            else
            {
                /*MessageBox.Show("EXEC insertar_proveedor_tenyo '" +
                    txtClaveProv.Text + "', '" +
                    txtRazonSocial.Text + "', '" +
                    txtDireccion.Text + "', '" +
                    txtTelefono.Text + "', '" +
                    txtContacto.Text + "'");*/
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_proveedor_tenyo '" +
                    txtClaveProv.Text.Trim() + "', '" +
                    txtRazonSocial.Text.Trim() + "', '" +
                    txtDireccion.Text.Trim() + "', '" +
                    txtTelefono.Text.Trim() + "', '" +
                    txtContacto.Text.Trim() + "'");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClaveProv.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtContacto.Clear();
            txtClaveProv.Focus();
        }
    }
}

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
    public partial class Form_Registros : Form
    {
        bool bandera = false;

        public Form_Registros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Abrir_Conexion_Tenyo();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form_Producto_Tenyo ventanaProductos = new Form_Producto_Tenyo();

            ventanaProductos.Show();

            this.Hide();
        }

        private void Form_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bandera == false)
            {
                Application.Exit();
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Form_Categoria_Tenyo ventCategoria = new Form_Categoria_Tenyo();
            ventCategoria.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            Form_Departamento_Tenyo ventDepartamento = new Form_Departamento_Tenyo();
            ventDepartamento.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Form_Empleado_Tenyo ventEmpleado = new Form_Empleado_Tenyo();
            ventEmpleado.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            Form_Proveedor_Tenyo ventProveedor = new Form_Proveedor_Tenyo();
            ventProveedor.Show();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Form_Marca_Tenyo ventMarca = new Form_Marca_Tenyo();
            ventMarca.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Form_Material_Tenyo ventMaterial = new Form_Material_Tenyo();
            ventMaterial.Show();
        }

        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            Form_Caracteristica_Tenyo ventCaracteristicas = new Form_Caracteristica_Tenyo();
            ventCaracteristicas.Show();
        }

        private void btnPasilloEstante_Click(object sender, EventArgs e)
        {
            Form_PasilloEstante_Tenyo ventPasilloEstante = new Form_PasilloEstante_Tenyo();
            ventPasilloEstante.Show();
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            Form_Medida_Tenyo ventMedida = new Form_Medida_Tenyo();
            ventMedida.Show();
        }

        private void btnFichaTecnica_Click(object sender, EventArgs e)
        {
            Form_Ficha_Tecnica_Tenyo ventFicha = new Form_Ficha_Tecnica_Tenyo();
            ventFicha.Show();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            Form_Descuento_Tenyo ventDescuento = new Form_Descuento_Tenyo();
            ventDescuento.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form_Inicio ventHome = new Form_Inicio();
            ventHome.Show();
            bandera = true;
            this.Close();
        }
    }
}

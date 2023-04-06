using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Tenyo_Ferreteria_El_Pillo
{
    public partial class Form_Producto_Tenyo : Form
    {
        bool bandera = false;
        public Form_Producto_Tenyo()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form_Registros ventanaInicio = new Form_Registros();

            ventanaInicio.Show();
            bandera = true;
            this.Close();
        }

        private void Form_Producto_Tenyo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bandera == false)
            {
                Application.Exit();
            }
        }

        private void cmbDepartamento_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_departamento_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbDepartamento, SQL);
            //MessageBox.Show(SQL);
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDepartamento.SelectedIndex == 0)
            {
                //MessageBox.Show(cmbDepartamento.SelectedItem.ToString());
                Form_Departamento_Tenyo vent = new Form_Departamento_Tenyo();
                vent.Show();
                cmbDepartamento.SelectedIndex = -1;
            }
        }

        private void cmbMarca_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_marca_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbMarca, SQL);
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMarca.SelectedIndex == 0)
            {
                Form_Marca_Tenyo vent = new Form_Marca_Tenyo();
                vent.Show();
                cmbCategoria.SelectedIndex = -1;
            }
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_categoria_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbCategoria, SQL);
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategoria.SelectedIndex == 0)
            {
                Form_Categoria_Tenyo vent = new Form_Categoria_Tenyo();
                vent.Show();
                cmbCategoria.SelectedIndex = -1;
            }
        }

        private void cmbMaterial_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_material_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbMaterial, SQL);
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMaterial.SelectedIndex == 0)
            {
                Form_Material_Tenyo vent = new Form_Material_Tenyo();
                vent.Show();
                cmbMaterial.SelectedIndex = -1;
            }
        }

        private void cmbDescuento_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_descuento_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbDescuento, SQL);
        }

        private void cmbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDescuento.SelectedIndex == 0)
            {
                Form_Descuento_Tenyo vent = new Form_Descuento_Tenyo();
                vent.Show();
                cmbDescuento.SelectedIndex = -1;
            }
        }

        private void cmbPasillo_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_pasillo_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbPasillo, SQL);
        }

        private void cmbPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPasillo.SelectedIndex == 0)
            {
                Form_PasilloEstante_Tenyo vent = new Form_PasilloEstante_Tenyo();
                vent.Show();
                cmbPasillo.SelectedIndex = -1;
            }
        }

        private void cmbEstante_Click(object sender, EventArgs e)
        {
            String SQL = "EXEC select_estante_tenyo";
            Conexion_Maestra_Tenyo.Llenar_Combo_Tenyo(cmbEstante, SQL);
        }

        private void cmbEstante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstante.SelectedIndex == 0)
            {
                Form_PasilloEstante_Tenyo vent = new Form_PasilloEstante_Tenyo();
                vent.Show();
                cmbEstante.SelectedIndex = -1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCodigoProd.Text) || String.IsNullOrWhiteSpace(txtCodigoProd.Text))
            {
                MessageBox.Show("Por Favor, Ingrese un Codigo de Producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtCodigoProd.Focus();
            }else if(String.IsNullOrEmpty(txtClaveProducto.Text) || String.IsNullOrWhiteSpace(txtClaveProducto.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una Clave de Producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                txtClaveProducto.Focus();
            }else if(cmbDepartamento.SelectedIndex == -1 || cmbDepartamento.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, Selecciona un Departamento al que pertenece el producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
            }else if(spnNivelCompetencia.Value < 0){
                MessageBox.Show("Por Favor, Ingrese el Nivel Competencia", "CAMPO FALTANTE!", MessageBoxButtons.OK);
                spnNivelCompetencia.Focus();
            }
            else if(cmbPasillo.SelectedIndex == -1 || cmbPasillo.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, Seleccione un Pasillo donde estará el producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
            }else if(cmbEstante.SelectedIndex == -1 || cmbEstante.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, Seleccione un Estante donde estará el producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
            }else if(cmbCategoria.SelectedIndex == -1 || cmbCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, Seleccione la Categoria a la que pertenece el Producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
            }else if(cmbMaterial.SelectedIndex == -1 || cmbMaterial.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, Seleccione el Material del Producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
            }else if(spnCantidad.Value <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese una Cantidad Valida", "CAMPO INVALIDO!", MessageBoxButtons.OK);
                spnCantidad.Focus();
            }else if(spnStockMin.Value <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese una Cantidad Valida", "CAMPO INVALIDO!", MessageBoxButtons.OK);
                spnStockMin.Focus();
            }else if(spnStockMax.Value <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese una Cantidad Valida", "CAMPO INVALIDO!", MessageBoxButtons.OK);
                spnStockMax.Focus();
            }else if(spnExistencias.Value <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese una Cantidad Valida", "CAMPO INVALIDO!", MessageBoxButtons.OK);
                spnExistencias.Focus();
            }else if(spnPrecioMayoreo.Value <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese una Cantidad Valida", "CAMPO INVALIDO!", MessageBoxButtons.OK);
                spnPrecioMayoreo.Focus();
            }else if(spnPrecioPublico.Value <= 0)
            {
                MessageBox.Show("Por Favor, Ingrese una Cantidad Valida", "CAMPO INVALIDO!", MessageBoxButtons.OK);
                spnPrecioPublico.Focus();
            }else if(cmbDescuento.SelectedIndex == -1 || cmbDescuento.SelectedIndex == 0)
            {
                MessageBox.Show("Por Favor, Seleccione el Descuento del Producto", "CAMPO FALTANTE!", MessageBoxButtons.OK);
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_producto_tenyo '" +
                    txtClaveProducto.Text.Trim() + "', '" +
                    txtCodigoProd.Text.Trim() + "', '" +
                    cmbDepartamento.SelectedItem + "', '" +
                    cmbMarca.SelectedItem + "', '" +
                    cmbCategoria.SelectedItem + "', '" +
                    cmbPasillo.SelectedItem + "', '" +
                    cmbEstante.SelectedItem + "', '" +
                    cmbMaterial.SelectedItem + "', " +
                    spnNivelCompetencia.Value + ", " +
                    spnCantidad.Value + ", " +
                    spnExistencias.Value + ", " +
                    spnStockMin.Value + ", " +
                    spnStockMax.Value + ", " +
                    spnPrecioMayoreo.Value + ", " +
                    spnPrecioPublico.Value + ", '" +
                    cmbDescuento.SelectedItem + "'");
                String nombre = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                //MessageBox.Show(nombre);
                //MessageBox.Show(openFileDialog1.ToString());
                if (File.Exists(openFileDialog1.FileName))
                {
                    //MessageBox.Show(nombre);
                    FileSystem.FileCopy(openFileDialog1.FileName, @"C:\Users\emate\source\repos\Tenyo_Ferreteria_El_Pillo\Tenyo_Ferreteria_El_Pillo\bin\Debug\IMG\PRODUCTOS\" + txtClaveProducto.Text.Trim() + ".png");
                }
            }
        }

        private void ptbImagen_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCodigoProd.Text) || String.IsNullOrWhiteSpace(txtCodigoProd.Text))
            {
                MessageBox.Show("Por Favor, Ingrese una clave de producto primero", "CAMPO NECESARIO!", MessageBoxButtons.OK);
                txtClaveProducto.Focus();
            }
            else
            {
                //openFileDialog1.InitialDirectory = "C:\\";
                openFileDialog1.Filter = "PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                //openFileDialog1.RestoreDirectory = true;
                DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    ptbImagen.Image = Image.FromFile(openFileDialog1.FileName);
                    ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    //MessageBox.Show(openFileDialog1.FileName);
                    //String nombre = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    //MessageBox.Show(nombre);
                    //FileSystem.FileCopy(openFileDialog1.FileName, @"C:\Users\emate\source\repos\Tenyo_Ferreteria_El_Pillo\Tenyo_Ferreteria_El_Pillo\bin\Debug\IMG\PRODUCTOS\" + txtCodigoProd.Text.Trim() + ".png");
                }
            }
        }
    }
}

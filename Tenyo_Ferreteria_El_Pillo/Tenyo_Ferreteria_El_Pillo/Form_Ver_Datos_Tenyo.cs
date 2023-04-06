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
    public partial class Form_Ver_Datos_Tenyo : Form
    {
        public Form_Ver_Datos_Tenyo()
        {
            InitializeComponent();
        }

        private void txtConsultar_KeyUp(object sender, KeyEventArgs e)
        {
            if(cmbOpcion.SelectedIndex != 0)
            {
                switch (cmbOpcion.SelectedIndex)
                {
                    case 1:
                        //MessageBox.Show(cmbOpcion.SelectedItem.ToString());
                        Conexion_Maestra_Tenyo.Grid(dataGridViewDatos, "EXEC buscar_producto_tenyo '" + txtConsultar.Text + "'");
                        break;
                    case 2:
                        Conexion_Maestra_Tenyo.Grid(dataGridViewDatos, "EXEC buscar_medida_tenyo '" + txtConsultar.Text + "'");
                        break;
                    case 3:
                        Conexion_Maestra_Tenyo.Grid(dataGridViewDatos, "EXEC buscar_caracteristica_tenyo '" + txtConsultar.Text + "'");
                        break;
                    case 4:
                        Conexion_Maestra_Tenyo.Grid(dataGridViewDatos, "EXEC buscar_proveedor_tenyo '" + txtConsultar.Text + "'");
                        break;
                    case 5:
                        Conexion_Maestra_Tenyo.Grid(dataGridViewDatos, "EXEC buscar_empleado_tenyo '" + txtConsultar.Text +"'");
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form_Ver_Datos_Tenyo_Load(object sender, EventArgs e)
        {
            cmbOpcion.SelectedIndex = 0;
        }
    }
}

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
    public partial class Form_Descuento_Tenyo : Form
    {
        public Form_Descuento_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_Descuento_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Grid(dataGridViewDescuento, "EXEC select_descuento_tenyo");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_descuento_tenyo " + spnDescuento.Value + "");
            Conexion_Maestra_Tenyo.Grid(dataGridViewDescuento, "EXEC select_descuento_tenyo");
        }
    }
}

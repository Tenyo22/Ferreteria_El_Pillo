using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Tenyo_Ferreteria_El_Pillo
{

    public partial class Form_Venta_Tenyo : Form
    {
        public bool bandera;
        private Worksheet hoja;
        private DialogResult dialog;

        public Form_Venta_Tenyo()
        {
            InitializeComponent();
        }

        private void Form_Venta_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC select_empleado_tenyo");
            while (Conexion_Maestra_Tenyo.leer_tenyo.Read())
            {
                Crear_Btn_Empleado(Conexion_Maestra_Tenyo.leer_tenyo[0].ToString(), Conexion_Maestra_Tenyo.leer_tenyo[1].ToString());
            }
            Conexion_Maestra_Tenyo.leer_tenyo.Close();
            Conexion_Maestra_Tenyo.conectar_tenyo.Close();
            bandera = true;
        }

        private void Crear_Btn_Empleado(string clave, string nombre)
        {
            //throw new NotImplementedException();
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Tag = clave;
            btn.Text = nombre;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.Width = 150;
            btn.Height = 150;
            btn.BackgroundImage = imageList1.Images[0];
            btn.Click += new EventHandler(btn_Empleado_Click);
            flowLayoutPanelProductos.Controls.Add(btn);
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            toolStripStatusLabelClave.Text = btn.Tag.ToString();

            DateTime fecha = DateTime.Now;
            toolStripStatusLabelFolio.Text = fecha.ToString("ddMMyyyyhhmmssf");
            flowLayoutPanelProductos.Controls.Clear();
            Mostrar_TextBox();
        }

        public void Mostrar_TextBox()
        {
            System.Windows.Forms.TextBox txtBuscarProducto = new System.Windows.Forms.TextBox();
            txtBuscarProducto.CharacterCasing = CharacterCasing.Upper;
            txtBuscarProducto.MaxLength = 100;
            txtBuscarProducto.Size = new System.Drawing.Size(300, 35);
            txtBuscarProducto.TabIndex = 1;
            txtBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(txtBuscarProducto_KeyDown);
            flowLayoutPanelBuscar.Controls.Add(txtBuscarProducto);
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
            if(e.KeyValue == 13)
            {
                flowLayoutPanelProductos.Controls.Clear();
                System.Windows.Forms.TextBox txtProducto = sender as System.Windows.Forms.TextBox;
                //MessageBox.Show(txtProducto.Text);
                Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC buscar_producto_tenyo '" + txtProducto.Text + "'");
                while (Conexion_Maestra_Tenyo.leer_tenyo.Read())
                {
                    Crear_Btn_Producto(Conexion_Maestra_Tenyo.leer_tenyo[0].ToString(), Conexion_Maestra_Tenyo.leer_tenyo[1].ToString());
                }
                Conexion_Maestra_Tenyo.leer_tenyo.Close();
                Conexion_Maestra_Tenyo.conectar_tenyo.Close();
            }
        }

        private void Crear_Btn_Producto(string clave, string codigo)
        {
            //throw new NotImplementedException();
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Tag = clave;
            btn.Text = codigo;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.Width = 150;
            btn.Height = 150;
            String name = AppDomain.CurrentDomain.BaseDirectory + @"IMG\PRODUCTOS\" + clave + ".PNG";
            if (File.Exists(name))
            {
                btn.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"IMG\PRODUCTOS\" + clave + ".PNG");
            }
            else
            {
                btn.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"IMG\PRODUCTOS\noImage.PNG");
            }
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Click += new EventHandler(btn_Producto_Click);
            flowLayoutPanelProductos.Controls.Add(btn);
        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            //MessageBox.Show(btn.Text);
            if (bandera)
            {
                dialog = MessageBox.Show("La Venta sera por Mayoreo?", "TIPO DE VENTA", MessageBoxButtons.YesNo);
                DataGridViewTextBoxColumn clave = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn codigo = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn precioM = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn precioP = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                DataGridView datos = new DataGridView();

                // COLUMNAS
                clave.HeaderText = "CLAVE";
                clave.Name = "clave";
                datos.Columns.Add(clave);

                codigo.HeaderText = "CODIGO";
                codigo.Name = "codigo";
                datos.Columns.Add(codigo);
                if (dialog == DialogResult.Yes)
                {
                    precioM.HeaderText = "PRECIO MAYOREO";
                    precioM.Name = "precio";
                    datos.Columns.Add(precioM);
                }
                else
                {
                    precioP.HeaderText = "PRECIO PUBLICO";
                    precioP.Name = "precio";
                    datos.Columns.Add(precioP);
                }
                cantidad.HeaderText = "CANTIDAD";
                cantidad.Name = "cantidad";
                datos.Columns.Add(cantidad);

                // MessageBox.Show("No existe");

                // BUSQUEDA DEL PRODUCTO
                Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC buscar_producto_tenyo '" + btn.Text + "'");
                if (Conexion_Maestra_Tenyo.leer_tenyo.Read())
                {
                    // FILAS
                    datos.Rows.Add();
                    datos.Rows[datos.Rows.Count - 2].Cells[0].Value = btn.Tag.ToString();
                    datos.Rows[datos.Rows.Count - 2].Cells[0].ReadOnly = true;
                    datos.Rows[datos.Rows.Count - 2].Cells[1].Value = btn.Text;
                    datos.Rows[datos.Rows.Count - 2].Cells[1].ReadOnly = true;
                    if (dialog == DialogResult.Yes)
                    {
                        datos.Rows[datos.Rows.Count - 2].Cells[2].Value = Conexion_Maestra_Tenyo.leer_tenyo[13].ToString();
                        datos.Rows[datos.Rows.Count - 2].Cells[3].Value = 20;
                    }
                    else
                    {
                        datos.Rows[datos.Rows.Count - 2].Cells[2].Value = Conexion_Maestra_Tenyo.leer_tenyo[14].ToString();
                        datos.Rows[datos.Rows.Count - 2].Cells[3].Value = 1;
                    }
                }
                Conexion_Maestra_Tenyo.leer_tenyo.Close();
                Conexion_Maestra_Tenyo.conectar_tenyo.Close();

                // DETALLE DE DATAGRIDVIEW
                datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datos.Width = 500;
                datos.Height = 250;
                datos.AllowUserToAddRows = false;
                datos.Name = "dataGridViewDetalleVenta";

                // AGREGAR AL FLOWLAYOUTPANEL
                flowLayoutPanelDV.Controls.Add(datos);
                bandera = false;

                // BOTON NUEVA VENTA
                System.Windows.Forms.Button btnNuevaVenta = new System.Windows.Forms.Button();
                btnNuevaVenta.Text = "Nueva Venta";
                btnNuevaVenta.TextAlign = ContentAlignment.MiddleCenter;
                btnNuevaVenta.Width = 100;
                btnNuevaVenta.BackColor = SystemColors.Control;
                btnNuevaVenta.Click += new EventHandler(btn_NuevaVenta_Click);
                flowLayoutPanelNuevaVenta.Controls.Add(btnNuevaVenta);

                // BOTON DE CERRAR VENTA
                System.Windows.Forms.Button btnCerrarVenta = new System.Windows.Forms.Button();
                //btnCerrarVenta.Tag = clave;
                btnCerrarVenta.Text = "Cerrar Venta";
                btnCerrarVenta.TextAlign = ContentAlignment.MiddleCenter;
                btnCerrarVenta.Width = 78;
                btnCerrarVenta.Height = 28;
                btnCerrarVenta.BackColor = SystemColors.Control;
                //btnCerrarVenta.BackgroundImage = imageList1.Images[0];
                btnCerrarVenta.Click += new EventHandler(btn_CerrarVenta_Click);
                flowLayoutPanelBtnVender.Controls.Add(btnCerrarVenta);
            }
            else
            {
                Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC buscar_producto_tenyo '" + btn.Text + "'");
                if (Conexion_Maestra_Tenyo.leer_tenyo.Read())
                {
                    foreach(Control objeto in flowLayoutPanelDV.Controls)
                    {
                        if(objeto is DataGridView)
                        {
                            bool band = true;
                            int fila = 0;
                            DataGridView grid = objeto as DataGridView;
                            for(int x = 0; x < grid.RowCount; x++)
                            {
                                if (grid.Rows[x].Cells[1].Value.ToString().Equals(btn.Text))
                                {
                                    // MessageBox.Show(grid.Rows[x].Cells[1].Value.ToString());
                                    // MessageBox.Show(btn.Text);
                                    band = false;
                                    fila = x;
                                }
                            }
                            if (band)
                            {
                                grid.Rows.Add();
                                // MessageBox.Show(grid.Rows[grid.Rows.Count - 1].ToString());
                                grid.Rows[grid.Rows.Count - 1].Cells[0].Value = btn.Tag.ToString();
                                grid.Rows[grid.Rows.Count - 1].Cells[0].ReadOnly = true;
                                grid.Rows[grid.Rows.Count - 1].Cells[1].Value = btn.Text;
                                grid.Rows[grid.Rows.Count - 1].Cells[1].ReadOnly = true;
                                if (dialog == DialogResult.Yes)
                                {
                                    grid.Rows[grid.Rows.Count - 1].Cells[2].Value = Conexion_Maestra_Tenyo.leer_tenyo[13].ToString();
                                    grid.Rows[grid.Rows.Count - 1].Cells[3].Value = 20;
                                }
                                else
                                {
                                    grid.Rows[grid.Rows.Count - 1].Cells[2].Value = Conexion_Maestra_Tenyo.leer_tenyo[14].ToString();
                                    grid.Rows[grid.Rows.Count - 1].Cells[3].Value = 1;
                                }
                                flowLayoutPanelDV.Controls.Add(grid);
                            }
                            else
                            {
                                grid.Rows[fila].Cells[3].Value = Convert.ToInt32(grid.Rows[fila].Cells[3].Value) + 1;
                            }
                            
                        }
                    }
                }
                Conexion_Maestra_Tenyo.leer_tenyo.Close();
                Conexion_Maestra_Tenyo.conectar_tenyo.Close();
            }

            /*foreach(Control objeto in flowLayoutPanelDV.Controls)
            {
                if(objeto is DataGridView)
                {
                    MessageBox.Show("Ya existe un DataGrid");
                    MessageBox.Show(objeto.Text);
                }
            }*/
        }

        private void btn_NuevaVenta_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Form_Venta_Tenyo vent = new Form_Venta_Tenyo();
            vent.Show();
        }

        private void btn_CerrarVenta_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            // CREACION DE VENTA
            //MessageBox.Show("EXEC insert_venta_tenyo '" + toolStripStatusLabelFolio + "', '" + toolStripStatusLabelClave);
            Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insert_venta_tenyo '" + toolStripStatusLabelFolio + "', '" + toolStripStatusLabelClave + "'");
            Conexion_Maestra_Tenyo.leer_tenyo.Close();
            Conexion_Maestra_Tenyo.conectar_tenyo.Close();
            //MessageBox.Show("Cerrando Venta");
            
            // CREACION DEL DETALLE VENTA
            foreach(Control objeto in flowLayoutPanelDV.Controls)
            {
                int i;
                DataGridView grid = objeto as DataGridView;
                for(i = 0; i < grid.RowCount; i++)
                {
                    /*MessageBox.Show("EXEC insert_detVenta_tenyo '" +
                        toolStripStatusLabelFolio.ToString() + "', '" +
                        grid.Rows[i].Cells[0].Value.ToString() + "', '" +
                        grid.Rows[i].Cells[2].Value.ToString() + "', '" +
                        grid.Rows[i].Cells[3].Value.ToString() + "'");*/
                    Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insert_detVenta_tenyo '" +
                        toolStripStatusLabelFolio.ToString() + "', '" +
                        grid.Rows[i].Cells[0].Value.ToString() + "', '" +
                        grid.Rows[i].Cells[2].Value.ToString() + "', '" +
                        grid.Rows[i].Cells[3].Value.ToString() + "'");
                }
            }
            Conexion_Maestra_Tenyo.leer_tenyo.Close();
            Conexion_Maestra_Tenyo.conectar_tenyo.Close();

            // CERRANDO VENTA
            Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC cerrar_venta_tenyo '" + toolStripStatusLabelFolio.ToString() + "'");
            Conexion_Maestra_Tenyo.leer_tenyo.Close();
            Conexion_Maestra_Tenyo.conectar_tenyo.Close();

            // BOTON DE FACTURA
            System.Windows.Forms.Button btnFactura = new System.Windows.Forms.Button();
            //btnCerrarVenta.Tag = clave;
            btnFactura.Text = "Crear Factura";
            btnFactura.TextAlign = ContentAlignment.MiddleCenter;
            btnFactura.Width = 87;
            btnFactura.Height = 28;
            btnFactura.BackColor = SystemColors.Control;
            //btnCerrarVenta.BackgroundImage = imageList1.Images[0];
            btnFactura.Click += new EventHandler(btn_CrearFactura_Click);
            flowLayoutPanelFactura.Controls.Add(btnFactura);
        }

        private void btn_CrearFactura_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("Creando Factura");

            // OBJETO
            Excel.Application aplicacion = new Excel.Application();
            Workbook libro = aplicacion.Workbooks.Add("VentaTenyoEmanuel");

            // EXCEL SE EJECUTA EN SEGUNDO PLANO
            aplicacion.Visible = true;
            // ABRIR LA HOJA
            hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);
            // TODO SE VUELVE UNA MATRIZ, ENTRE CORCHETES SE MANEJA COMO MATRIZ
            hoja.Cells[3, 5] = toolStripStatusLabelFolio.ToString();
            hoja.Cells[4, 5] = DateTime.Now.ToString("dd/MM/yyyy");
            foreach (Control objeto in flowLayoutPanelDV.Controls)
            {
                int x;
                int y = 13;
                DataGridView grid = objeto as DataGridView;
                for (x = 0; x < grid.RowCount; x++)
                {
                    hoja.Cells[y, 2] = grid.Rows[x].Cells[1].Value.ToString();
                    hoja.Cells[y, 3] = grid.Rows[x].Cells[2].Value.ToString();
                    hoja.Cells[y, 4] = grid.Rows[x].Cells[3].Value.ToString();
                    hoja.Cells[y, 5] = Convert.ToInt32(grid.Rows[x].Cells[2].Value) * Convert.ToInt32(grid.Rows[x].Cells[3].Value);
                    y++;
                }

            }
            //hoja.Cells[5, 3] = "Lo hicimos";
            //libro.PrintPreview();
            try
            {
                //libro.SaveAs("C:\\Documentos\\Archivo1_Venta.xlsx");
                aplicacion.Quit();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                aplicacion.Quit();
            }
        }

        /*private void btnCrearExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toolStripStatusLabelFolio.ToString());
            // Objeto
            Excel.Application aplicacion = new Excel.Application();
            Workbook libro = aplicacion.Workbooks.Add("VentaTenyoEmanuel");

            // Excel se ejecuta en segundo plano
            aplicacion.Visible = true;
            // Abrir la hoja
            hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);
            // Todo se vuelve una matriz, entre corchetes se maneja como matriz
            hoja.Cells[3, 5] = toolStripStatusLabelFolio.ToString();
            hoja.Cells[4, 5] = "=HOY()" + 13;
            hoja.Cells[5, 3] = "Lo hicimos";
            hoja.Cells[2, 3] = "Codigo Producto";
            hoja.Cells[2, 4] = "Cantidad";
            hoja.Cells[2, 5] = "Precio";
            hoja.Cells[9, 4] = "Subtotal";
            hoja.Cells[9, 5] = "$";
            hoja.Cells[10, 4] = "Impuesto (IVA)";
            hoja.Cells[10, 5] = "$";
            hoja.Cells[11, 4] = "Total";
            libro.PrintPreview();
            try
            {
                libro.SaveAs("C:\\Documentos\\Archivo1_Venta.xlsx");
                aplicacion.Quit();
            } catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                aplicacion.Quit();
            }
        }*/
    }
}

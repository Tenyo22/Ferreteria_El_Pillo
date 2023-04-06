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

namespace Tenyo_Ferreteria_El_Pillo
{
    public partial class Form_Ficha_Tecnica_Tenyo : Form
    {
        public Form_Ficha_Tecnica_Tenyo()
        {
            InitializeComponent();
        }
        String claveProd;

        private void Form_Ficha_Tecnica_Tenyo_Load(object sender, EventArgs e)
        {
            Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC select_producto_tenyo");
            while (Conexion_Maestra_Tenyo.leer_tenyo.Read())
            {
                //MessageBox.Show(Conexion_Maestra_Tenyo.leer_tenyo[0].ToString());
                //MessageBox.Show(Conexion_Maestra_Tenyo.leer_tenyo[1].ToString());
                Crear_Btn_FichaTecnica(Conexion_Maestra_Tenyo.leer_tenyo[0].ToString(), Conexion_Maestra_Tenyo.leer_tenyo[1].ToString());
            }
            Conexion_Maestra_Tenyo.leer_tenyo.Close();
            Conexion_Maestra_Tenyo.conectar_tenyo.Close();
        }

        private void Crear_Btn_FichaTecnica(String clave, String codigo)
        {
            //throw new NotImplementedException();
            Button btn = new Button();
            btn.Tag = clave;
            btn.Text = codigo;
            btn.TextAlign = ContentAlignment.BottomCenter;
            // Ancho y Alto:
            btn.Width = 150;
            btn.Height = 150;
            // Imagen:
            String name = AppDomain.CurrentDomain.BaseDirectory + @"IMG\PRODUCTOS\" + clave + ".PNG";
            if (File.Exists(name))
            {
                btn.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"IMG\PRODUCTOS\" + clave + ".PNG");
            }
            else
            {
                btn.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"IMG\PRODUCTOS\noImage.PNG");
            }
            // Acomodar la imagen:
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Click += new EventHandler(boton_Producto_Click);
            flowLayoutPanel1.Controls.Add(btn);
        }

        private void boton_Producto_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button btn = sender as Button;
            DataGridViewCheckBoxColumn chek = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn carac = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn valor = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn cmbMedida = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn detalleExtra = new DataGridViewTextBoxColumn();
            DataGridView datos = new DataGridView();
            claveProd = btn.Tag.ToString();

            // Creacion de las Columnas:
            chek.HeaderText = "AGREGAR";
            chek.Name = "Agregar";
            datos.Columns.Add(chek);
            //chek.DataGridView.CellClick += new DataGridViewCellEventHandler(check_CellClick);

            carac.HeaderText = "CARACTERISTICA";
            carac.Name = "Caracteristica";
            datos.Columns.Add(carac);

            valor.HeaderText = "VALOR";
            valor.Name = "Valor";
            datos.Columns.Add(valor);

            cmbMedida.HeaderText = "MEDIDA";
            cmbMedida.Name = "cmbMedida";
            datos.Columns.Add(cmbMedida);

            detalleExtra.HeaderText = "DETALLE EXTRA";
            detalleExtra.Name = "detalleExtra";
            datos.Columns.Add(detalleExtra);

            // Consulta Caracteristicas
            Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC select_caracteristica_tenyo");

            // Creacion de las Filas Caracteristicas
            while (Conexion_Maestra_Tenyo.leer_tenyo.Read())
            {
                datos.Rows.Add();
                datos.Rows[datos.Rows.Count - 2].Cells[1].Value = Conexion_Maestra_Tenyo.leer_tenyo[1].ToString();
                //row["Caracteristica"] = Conexion_Maestra_Tenyo.leer_tenyo[1].ToString();
            }
            Conexion_Maestra_Tenyo.leer_tenyo.Close();

            // Llenar combo de Medida
            cmbMedida.Items.Clear();
            Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC select_medida_tenyo");
            while (Conexion_Maestra_Tenyo.leer_tenyo.Read())
            {
                cmbMedida.Items.Add(Conexion_Maestra_Tenyo.leer_tenyo[1].ToString());
            }
            Conexion_Maestra_Tenyo.conectar_tenyo.Close();

            // Detalles del DataGridView
            datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datos.Width = 750;
            datos.Height = 300;
            datos.AllowUserToAddRows = false;
            datos.Name = "dataGridViewFichaTecnica";

            // Agregar Tabla al Flow
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(datos);

            //MessageBox.Show("Pulsaste " + btn.Text);

            //Boton de Agregar
            Button btn2 = new Button();
            btn2.Text = "Agregar";
            btn2.Name = "btnAgregar";
            btn2.Click += new EventHandler(boton_AgregrarProducto_Click);
            flowLayoutPanel2.Controls.Add(btn2);
            ActivarCaracteristicas();
        }

        public void ActivarCaracteristicas()
        {
            foreach(Control objeto in this.flowLayoutPanel1.Controls)
            {
                if (objeto is DataGridView)
                {
                    //String[] caracteristicas = Array.Empty<String>();
                    List<string> caracteristicas = new List<string>();
                    List<string> valor = new List<string>();
                    List<string> medida = new List<string>();
                    List<string> observacion = new List<string>();
                    DataGridView grid = objeto as DataGridView;

                    //MessageBox.Show(claveProd);
                    Conexion_Maestra_Tenyo.Ejecutar_Query_Tenyo("EXEC buscar_ficha_tecnica_tenyo '" + claveProd + "'");
                    while (Conexion_Maestra_Tenyo.leer_tenyo.Read())
                    {
                        caracteristicas.Add(Conexion_Maestra_Tenyo.leer_tenyo[0].ToString());
                        valor.Add(Conexion_Maestra_Tenyo.leer_tenyo[1].ToString());
                        medida.Add(Conexion_Maestra_Tenyo.leer_tenyo[2].ToString());
                        observacion.Add(Conexion_Maestra_Tenyo.leer_tenyo[3].ToString());
                    }
                    Conexion_Maestra_Tenyo.conectar_tenyo.Close();
                    //MessageBox.Show(String.Join(" ",caracteristicas));
                    //MessageBox.Show(caracteristicas[0]);

                    int i = 0;
                    for (int x = 0; x < grid.RowCount; x++)
                    {
                        if(i < caracteristicas.Count)
                        {
                            if (grid.Rows[x].Cells[1].Value.ToString() == caracteristicas[i])
                            {
                                grid.Rows[x].Cells[0].Value = true;
                                grid.Rows[x].Cells[2].Value = valor[i];
                                grid.Rows[x].Cells[3].Value = medida[i];
                                grid.Rows[x].Cells[4].Value = observacion[i];
                                i++;
                            }
                        }
                    }
                }
            }
        }

        private void boton_AgregrarProducto_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // Regresa un 
            foreach (Control objeto in this.flowLayoutPanel1.Controls)
            {
                if (objeto is DataGridView)
                {
                    DataGridView grid = objeto as DataGridView;
                    int x;
                    for (x = 0; x < grid.RowCount; x++)
                    {
                        if (grid.Rows[x].Cells[0].Value != null)
                        {
                            if (grid.Rows[x].Cells[0].Value.Equals(true))
                            {
                                if(grid.Rows[x].Cells[2].Value != null)
                                {
                                    if (!String.IsNullOrEmpty(grid.Rows[x].Cells[2].Value.ToString()) || !String.IsNullOrWhiteSpace(grid.Rows[x].Cells[2].Value.ToString()))
                                    {
                                        if(grid.Rows[x].Cells[3].Value != null)
                                        {
                                            if(!String.IsNullOrEmpty(grid.Rows[x].Cells[3].Value.ToString()) || !String.IsNullOrWhiteSpace(grid.Rows[x].Cells[3].Value.ToString()))
                                            {
                                                //button1.Text += grid.Rows[x].Cells[1].Value.ToString();
                                                /*MessageBox.Show(claveProd +
                                                    "\n" + grid.Rows[x].Cells[1].Value.ToString() +
                                                    "\n" + grid.Rows[x].Cells[2].Value.ToString() +
                                                    "\n" + grid.Rows[x].Cells[3].Value.ToString() +
                                                    "\n" + grid.Rows[x].Cells[4].Value?.ToString());*/
                                                Conexion_Maestra_Tenyo.Ejecutar_ProcAlm_Tenyo("EXEC insertar_ficha_tecnica_tenyo '" +
                                                    claveProd + "', '" +
                                                    grid.Rows[x].Cells[1].Value.ToString() + "', '" +
                                                    grid.Rows[x].Cells[2].Value.ToString() + "', '" +
                                                    grid.Rows[x].Cells[3].Value.ToString() + "', '" +
                                                    grid.Rows[x].Cells[4].Value?.ToString() + "'");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            // Regresa un 
            foreach(Control objeto in this.flowLayoutPanel1.Controls)
            {
                if (objeto is DataGridView)
                {
                    DataGridView grid = objeto as DataGridView;
                    int x;
                    for(x=0; x<grid.RowCount; x++)
                    {
                        if(grid.Rows[x].Cells[0].Value != null)
                        {
                            if (grid.Rows[x].Cells[0].Value.Equals(true))
                            {
                                button1.Text += grid.Rows[x].Cells[1].Value.ToString();
                                MessageBox.Show(grid.Rows[x].Cells[1].Value.ToString());
                            }
                        }
                    }
                }
            }
        }*/
    }
}

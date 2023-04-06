using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tenyo_Ferreteria_El_Pillo
{
    class Conexion_Maestra_Tenyo
    {
        static String servidor_tenyo = @"PC1\CITADEL";
        static String usuario_tenyo = @"Emanuel";
        static String contrasena_tenyo = "Tenchoman22";
        static String database_tenyo = "Tenyo_Ferreteria";

        static String cadena_conexion_tenyo = "data source = " +
            servidor_tenyo + "; initial catalog = " +
            database_tenyo + "; user id = " +
            usuario_tenyo + "; password = " +
            contrasena_tenyo;

        public static SqlConnection conectar_tenyo = new SqlConnection(cadena_conexion_tenyo);
        public static SqlCommand consulta_tenyo = new SqlCommand();
        public static SqlDataReader leer_tenyo;


        public static void Abrir_Conexion_Tenyo()
        {
            if(conectar_tenyo.State == ConnectionState.Closed)
            {
                conectar_tenyo.Open();
                //MessageBox.Show("Conexion Exitosa!");
            }
        }

        public static void Ejecutar_Query_Tenyo(String query)
        {
            Abrir_Conexion_Tenyo();

            consulta_tenyo.Connection = conectar_tenyo;
            consulta_tenyo.CommandType = System.Data.CommandType.Text;
            consulta_tenyo.CommandText = query;

            leer_tenyo = consulta_tenyo.ExecuteReader();
        }

        public static void Llenar_Combo_Tenyo(ComboBox cmb, String SQL)
        {
            Ejecutar_Query_Tenyo(SQL);

            cmb.Items.Clear();
            cmb.Items.Add("AGREGAR");
            while (leer_tenyo.Read())
            {
                cmb.Items.Add(leer_tenyo[0]);
            }
            leer_tenyo.Close();
            conectar_tenyo.Close();
        }

        public static void Ejecutar_ProcAlm_Tenyo(String SQL)
        {
            Ejecutar_Query_Tenyo(SQL);
            if (leer_tenyo.Read())
            {
                MessageBox.Show(leer_tenyo[0].ToString(), "MENSAJE!", MessageBoxButtons.OK);
            }
            leer_tenyo.Close();
            conectar_tenyo.Close();
        }

        public static void Grid(DataGridView tabla, String SQL)
        {
            Ejecutar_Query_Tenyo(SQL);
            leer_tenyo.Close();
            DataSet cuadricula = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_tenyo);
            adaptador.Fill(cuadricula, "Datos");
            tabla.DataSource = cuadricula;
            tabla.DataMember = "Datos";
            cuadricula.AcceptChanges();
            conectar_tenyo.Close();
        }

    }
}

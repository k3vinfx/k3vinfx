using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Oz_Cam.Clases
{
    class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();
      //  string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={password};";


        string CadenaConexion = "Server=localhost;Port=3306;Database=ozcam;Uid=root;Pwd=;";

     //   string CadenaConexion = "SERVER=151.106.96.1;PORT=3306;DATABASE=u532654912_oz_cam ;UID=u532654912_oz_cam;PASSWORD=0ySAY2t:$W@";



        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                MessageBox.Show("Conectado");
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
            return conexion;
        }
        public string Agregar (string wp,string token,string foto1, string foto2, string foto3, string foto4, string foto5, string foto6, string foto7, string foto8)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
           // string comando = "INSERT INTO clientes_camoz values (@id_cliente, @whatapp, @token, @foto_01, @foto_02, @foto_03, @foto_04, @foto_05, @foto_06, @foto_07, @foto_08)";
            string comando = "INSERT INTO clientes_camoz values (@id_cliente, @whatapp, @token, @foto_01, @foto_02, @foto_03, @foto_04, @foto_05, @foto_06, @foto_07, @foto_08)";

            MySqlCommand cmd = new MySqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@id_cliente", "");
            cmd.Parameters.AddWithValue("@whatapp", wp);
            cmd.Parameters.AddWithValue("@token", token);
           // cmd.Parameters.AddWithValue("@foto_01", foto1);
          //  cmd.Parameters.AddWithValue("@foto_02", foto2);
          //  cmd.Parameters.AddWithValue("@foto_03", foto3);
          //  cmd.Parameters.AddWithValue("@foto_04", foto4);
          //  cmd.Parameters.AddWithValue("@foto_05", foto5);
          //  cmd.Parameters.AddWithValue("@foto_06", foto6);
          //  cmd.Parameters.AddWithValue("@foto_07", foto7);
           // cmd.Parameters.AddWithValue("@foto_08", foto8);

            cmd.ExecuteNonQuery();
            conexion.Close();
            return "agregado con exito";


        }
        public DataSet VerTable()
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            string comando = "Select * from clientes_camoz ORDER BY id_cliente DESC";
            MySqlCommand cmd = new MySqlCommand(comando, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conexion.Close();
            return dt;

        }


        public DataSet VerTable_QR()
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            string comando = "Select * from clientes_camoz Where pago = 'QR' and confirmacion_pago = 'No'  ORDER BY id_cliente DESC";
            MySqlCommand cmd = new MySqlCommand(comando, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
            DataSet dt = new DataSet();
            da.Fill(dt);
            conexion.Close();
            return dt;

        }


        public string Editar(string idCliente,  string conf_pago, string monto)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            string comando = "UPDATE clientes_camoz SET confirmacion_pago = @conf_pago , monto = @monto  WHERE id_cliente = @idCliente";

            MySqlCommand cmd = new MySqlCommand(comando, conexion);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@conf_pago", conf_pago);
            cmd.Parameters.AddWithValue("@monto", monto);
            cmd.ExecuteNonQuery();
            conexion.Close();
            return "editado con éxito";
        }





    }
}

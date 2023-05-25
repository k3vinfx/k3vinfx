using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Oz_Cam
{
     class ConectorConector
    {

        MySqlConnection conexion = new MySqlConnection();
        string CadenaConexion = "SERVER=151.106.96.1;PORT=3306;DATABASE=u532654912_vinetasbdml;UID=u532654912_vinetasbdml;PASSWORD=gtaV19921963";

    

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
                MessageBox.Show("Error"+ex.ToString());
            }
            return conexion;
        }
  



    }


}

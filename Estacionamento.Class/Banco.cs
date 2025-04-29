using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Estacionamento.Class
{
    public class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            string strconn = @"server=127.0.0.1;database=estacionamentodb;user=root;password=";

            MySqlConnection cn = new(strconn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cmd;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    class KetNoiCSDL
    {
        public static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["dataPatch"] + "");
        public static void moKetNoi()
        {
            connect.Open();
        }
        public static void dongKetNoi()
        {
            connect.Close();
        }
    }
}

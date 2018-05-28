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
            try
            {
                connect.Open();
            }
            catch(Exception ex){ }
        }
        public static void dongKetNoi()
        {

            try
            {
                connect.Close();
            }
            catch (Exception ex) { }
        }
    }
}

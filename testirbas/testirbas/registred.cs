using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace testirbas
{
    class registred
    {
        public string login(string password, string login)
        {
            using (SqlConnection con = new SqlConnection(testirbas.Properties.Settings.Default.Setting))
            {
                string zap = @"select prioritet from users where login =" + login + " and password" + password + ";";
                try
                {
                    SqlCommand com = new SqlCommand(zap, con);
                    con.Open();
                    return com.ExecuteScalar().ToString();
                }
                catch(Exception ex)
                {
                    return "0";
                }
            }
        }
    }
}

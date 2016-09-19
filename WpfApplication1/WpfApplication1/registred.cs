using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WpfApplication1
{
    class registred
    {
        public string login(string password, string login)
        {
            using (SqlConnection con = new SqlConnection(WpfApplication1.Properties.Settings.Default.Setting))
            {
                string zap = @"select prioritet from users where login ='" + login + "' and password='" + password + "';";
                SqlCommand com = new SqlCommand(zap, con);
                con.Open();
                try
                {
                    string result = com.ExecuteScalar().ToString();
                    return result;
                }
                catch (Exception ex)
                {
                    
                    return "0";
                }
                con.Close();
            }
        }
    }
}

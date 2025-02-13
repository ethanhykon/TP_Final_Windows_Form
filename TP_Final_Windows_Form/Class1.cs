using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_Windows_Form
{
    public class Class1
    {
        public static DataTable Reload()
        {

            
                string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\repos\\TP_Final_Windows_Form\\Database1.mdf;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(stringconnection))
                {
                    // ouverture de la connexion
                    conn.Open();
                    // requet sql
                    string dmd = "SELECT * FROM Jeux";
                    //package nuget qui permet d'intéragire avc la bdd
                    SqlDataAdapter da = new SqlDataAdapter(dmd, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }

        }
            
  
            



    }
}

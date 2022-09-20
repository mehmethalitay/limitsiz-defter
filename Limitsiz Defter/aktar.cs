using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
namespace Limitsiz_Defter
{

   public class aktar
    {
        public  SQLiteConnection con;
        public void baglanti() {
            con = new SQLiteConnection("@Data Source = limitsizdefter; Version = 3;");
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }

        }
    
    }
}

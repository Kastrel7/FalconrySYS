using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FalconrySYS
{

    public class DBConnect
    {
        public static String connection = "Data Source = studentoracle:1521/orcl; User ID = USERNAME; Password = PASSWORD;";

        public static void setConnection(String username, String password)
        {
            connection = String.Format("Data Source = studentoracle:1521/orcl; User ID = {0}; Password = {1};", username, password);
        }
    }

}

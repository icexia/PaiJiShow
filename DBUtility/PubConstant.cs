using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public class PubConstant
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["SqlConnectionString"];
            }
        }

        public static string GetConnectionString(string configName)
        {
            return ConfigurationManager.AppSettings[configName];
        }
    }
}

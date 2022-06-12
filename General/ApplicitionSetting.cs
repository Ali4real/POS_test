using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApp1.General
{
    public class ApplicitionSetting
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}

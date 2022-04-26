using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Helper
    {
        public Helper()
        {

        }
        public string Directory()
        {
            string curdirect = Environment.CurrentDirectory;
            string direct = curdirect.Substring(0, curdirect.Length - 9) + "Images/";
            return direct;
        }
    }
}

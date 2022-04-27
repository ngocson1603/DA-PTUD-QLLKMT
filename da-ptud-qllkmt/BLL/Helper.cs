using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void LoadChildForm(Form frm, Panel pnl)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnl.Controls.Add(frm);
            pnl.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace PROJ_BPCL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (CheckApplication() == true)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Form2());
                Application.Exit();
            }
        }

        private static Boolean CheckApplication()
        {
            bool _result = false;
            DBAccess dbAccessLayer = null;
            try
            {
                dbAccessLayer = new DBAccess();
                DataTable dtTemp = dbAccessLayer.GetProductKey();
                if (dtTemp != null && dtTemp.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        string sEncKey = Convert.ToString(dr["sKeyText"]);
                        string sDecriptedKey = Encryption.DecryptFromBase64String(sEncKey);
                        string sCurrentKey = System.Environment.MachineName.ToUpper() + "-admin123";
                        if (sDecriptedKey == sCurrentKey)
                        {
                            _result = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _result = false;
                MessageBox.Show("Error loading form data: " + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }

            return _result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DBLayer;

namespace PROJ_BPCL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CheckConnectionString();
        }

        private void CheckConnectionString()
        {
            //if (Convert.ToString(System.Configuration.ConfigurationManager.ConnectionStrings["BPCL"]) == "")
            //{
            //    rdServerWindows.Checked = true;
            //    txtMachineName.Enabled = false;
            //    txtPassword.Enabled = false;
            //}
            //else
            //{
            //    txtMachineName.Text = Environment.MachineName;
            //    if (txtMachineName.Text.Trim() != "")
            //    {
            //        txtPassword.Select();
            //        txtPassword.Focus();
            //    }
            //}
            txtMachineName.Text = Environment.MachineName;
            if (txtMachineName.Text.Trim() != "")
            {
                txtPassword.Select();
                txtPassword.Focus();
            }
        }
        DBAccess dbAccessLayer = null;
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtMachineName.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim().ToString() == "admin123")
                {
                    dbAccessLayer = new DBAccess();
                    string sInputKey = Convert.ToString(txtMachineName.Text.Trim().ToUpper()) + "-" + Convert.ToString(txtPassword.Text.Trim());
                    string sEncryptedKey = Encryption.EncryptToBase64String(sInputKey);
                    if (InsertEncryptedKeyInDB(sEncryptedKey))
                    {
                        MessageBox.Show(string.Format("{0} is register with product and able to use the product.", Convert.ToString(txtMachineName.Text.Trim())), "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Re-start the application", "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Application.Exit();
                        SendEmailMessage(Convert.ToString(txtMachineName.Text.Trim().ToUpper()));
                        this.ShowInTaskbar = false;
                        this.Hide();
                        Form1 ofrmSearch = new Form1();
                        ofrmSearch.WindowState = FormWindowState.Maximized;
                        ofrmSearch.ShowDialog(this);
                        ofrmSearch.Dispose();
                        Application.Exit();

                    }
                    else
                        MessageBox.Show(string.Format("Either \"{0} is already register with product\" Or \"Error occured in {0} register process with product\".\nContact your application vendor.", Convert.ToString(txtMachineName.Text.Trim())), "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(string.Format("You have not provided the password or password you have enterd doesn't match. Contact your application vendor."), "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format("Machine Name is required."), "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendEmailMessage(string sMachineName)
        {
            try
            {
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST
                // Get the IP
                string sIPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                string sEmailBody = string.Format("Hello Sir,\n\t\tCONGRATULATIONS\nNew client is added to BPCL network. Following are the details\n\t Machine Name: {0}\n\t Machine IP Address: {1}.\n\n\nThank You", sMachineName, sIPAddress);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("installujwala@gmail.com");
                mail.To.Add("installujwala@gmail.com");
                mail.Subject = "New BPCL client is added";
                mail.Body = sEmailBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("installujwala@gmail.com", "!nstallUjwala9");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in product registration process: " + ex.Message, "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertEncryptedKeyInDB(string sEncryptedKey)
        {
            bool _result = false;
            try
            {
                _result = dbAccessLayer.InsertProductKey(sEncryptedKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in product registration: " + ex.Message, "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

            return _result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMachineName.Clear();
            txtPassword.Clear();
        }

        private void rdServerWindows_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableTextbox();
        }

        private void rdServerSQL_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableTextbox();
        }

        private void EnableDisableTextbox()
        {
            if (rdServerWindows.Checked)
            {
                txtUsername.Enabled = false;
                txtPwd.Enabled = false;
            }
            else if (rdServerSQL.Checked)
            {
                txtUsername.Enabled = true;
                txtPwd.Enabled = true;
            }
        }

        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            string sqlConStr = string.Empty;
            string sqlServerDB = string.Empty;
            string sqlUserPwd = string.Empty;
            if (txtServer.Text.Trim() != "")
            {
                if (txtDB.Text.Trim() != "")
                {
                    sqlServerDB = string.Format("Data Source={0};Initial Catalog={1};", txtServer.Text.Trim(), txtDB.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Enter Database", "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (rdServerSQL.Checked)
                {
                    if (txtUsername.Text.Trim() != "")
                    {
                        if (txtPwd.Text.Trim() != "")
                        {
                            sqlUserPwd = string.Format("User ID={0};Password={1};", txtUsername.Text.Trim(), txtPwd.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("Enter Password", "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter UserName", "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (sqlServerDB!="")
                {
                    if (rdServerWindows.Checked)
                    {
                        sqlConStr = sqlServerDB + "Integrated Security=True;Connection Timeout=0";
                    }
                    else if (rdServerSQL.Checked)
                    {
                        sqlConStr = sqlServerDB + ";Persist Security Info=True;" + sqlUserPwd + ";Connection Timeout=0";
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Server", "Key Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (sqlConStr!=null)
            {
                UpdateAppConfig(sqlConStr);
                CheckConnectionString();
            }
        }

        private void UpdateAppConfig(string sqlConStr)
        {
            System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["BPCL"].ConnectionString = sqlConStr;
            config.Save(System.Configuration.ConfigurationSaveMode.Modified, true);
            System.Configuration.ConfigurationManager.RefreshSection("BPCL");
                
                
            //    Manager.ConnectionStrings["BPCL"].ConnectionString = sqlConStr;
            //System.Configuration.
            
            //XmlDocument xmlDoc = new XmlDocument();

            //xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            //foreach (XmlElement xElement in xmlDoc.DocumentElement)
            //{
            //    if (xElement.Name=="connectionStrings")
            //    {
            //        xElement.FirstChild.Attributes[1].Value = sqlConStr;
            //    }
            //}
            //xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void btnServerClear_Click(object sender, EventArgs e)
        {
            txtServer.Clear();
            txtDB.Clear();
            txtUsername.Clear();
            txtPwd.Clear();

        }
    }
}

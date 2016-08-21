using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using System.Net;
using System.Net.Mail;

namespace PROJ_BPCL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
                if (txtPassword.Text.Trim().ToString()=="admin123")
                {
                    dbAccessLayer = new DBAccess();
                    string sInputKey = Convert.ToString(txtMachineName.Text.Trim().ToUpper()) + "-"+Convert.ToString(txtPassword.Text.Trim());
                    string sEncryptedKey=Encryption.EncryptToBase64String(sInputKey);
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
                string sEmailBody=string.Format("Hello Sir,\n\t\tCONGRATULATIONS\nNew client is added to BPCL network. Following are the details\n\t Machine Name: {0}\n\t Machine IP Address: {1}.\n\n\nThank You",sMachineName,sIPAddress);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("From Email Address");
                mail.To.Add("To Email Address");
                mail.Subject = "New BPCL client is added";
                mail.Body = sEmailBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("Username", "Password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private bool InsertEncryptedKeyInDB(string sEncryptedKey)
        {
            bool _result = false;
            try
            {
                _result= dbAccessLayer.InsertProductKey(sEncryptedKey);
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
    }
}

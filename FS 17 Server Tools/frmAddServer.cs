using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS_17_Server_Tools
{
    public partial class frmAddServer : Form
    {
        public frmAddServer()
        {
            InitializeComponent();
        }

        private void chkAnonDownload_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAnonDownload.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnCancelAddServer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string ValidateAddNewServerForm()
        {
            string strErrorMessage = string.Empty;
            int intPortNum = 0;

            if (txtHostName.Text.Length < 1)
            {
                strErrorMessage += "You must specify a host name or IP address.\n";
            }

            if (txtPortNum.Text.Length > 0)
            {
                try
                {
                    int.TryParse(txtPortNum.Text, out intPortNum);
                }
                catch
                {
                    strErrorMessage += "Web server port number must be an integer between 1 - 65,545\n";
                }

                if ((intPortNum > 65545) || (intPortNum < 1))
                {
                    strErrorMessage += "Web server port number must be an integer between 1 - 65,545\n";
                }
            }

            if (chkAnonDownload.Checked == false)
            {
                if (txtUsername.Text.Length < 1)
                {
                    strErrorMessage += "A username is required if not attempting an anonymous download.\n";
                }

                if (txtPassword.Text.Length < 1)
                {
                    strErrorMessage += "A password is required if not attempting an anonymous download.\n";
                }
            }

            return strErrorMessage;
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            // test settings and then add to xml file

            FS_17_Server_Tools.FsServer toAdd = new FsServer();
            string strResults = ValidateAddNewServerForm();

            if (strResults.Length > 0)
            {
                MessageBox.Show(strResults);
            }
            else
            {
                // values are potentially correct so try to make a network connection
                
                if(rbtHTTP.Checked)
                {
                    toAdd.WebServerProtocol = "http://";

                    if(txtPortNum.Text.Length == 0)
                    {
                        toAdd.WebServerPort = 80;
                    }
                }
                else
                {
                    toAdd.WebServerProtocol = "https://";

                    if (txtPortNum.Text.Length == 0)
                    {
                        toAdd.WebServerPort = 443;
                    }
                }

                if(txtPortNum.Text.Length > 0)
                {
                    toAdd.WebServerPort = int.Parse(txtPortNum.Text);
                }

                toAdd.WebServerHostName = txtHostName.Text;

                if(chkAnonDownload.Checked)
                {
                    toAdd.UserName = string.Empty;
                    toAdd.Password = string.Empty;
                }
                else
                {
                    toAdd.UserName = txtUsername.Text;
                    toAdd.Password = txtPassword.Text;
                }

                if(txtWebApiCode.Text.Length > 0)
                {
                    toAdd.WebApiCode = txtWebApiCode.Text;
                }
                else
                {
                    toAdd.WebApiCode = string.Empty;
                }

                if(toAdd.TestConnectionInfo())
                {
                    if(toAdd.SyncInfoWithServer())
                    {
                        FileInfo xmlFile = new FileInfo("Servers.xml");

                        toAdd.SaveToFile(xmlFile);
                    }
                }
            }

            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // validate data on the form and attempt to connect to the specified server
            // if web API code is present attempt to access the web service xml data
            // if username and password are specified attempt to login to website
            // if no username / password and no web api then attempt to access the mod download page


            string strResults = ValidateAddNewServerForm();

            if(strResults.Length > 0)
            {
                MessageBox.Show(strResults);
            }
            else
            {
                // values are potentially valid so try to make a network connection
                string strProtocol = string.Empty;
                int intPort = int.Parse(txtPortNum.Text);
                string strWebDocument = string.Empty;
                string strWebApiCode = string.Empty;
                UriBuilder builder;
                WebRequest wreq;
                HttpWebResponse wresponse;

                if (rbtHTTP.Checked)
                {
                    strProtocol = "http";
                }
                else
                {
                    strProtocol = "https";
                }

                if (txtWebApiCode.Text.Length > 0)
                {
                    // try to access the web api xml
                    strWebDocument = ConfigurationManager.AppSettings["WebApiUrl"].ToString();
                    strWebApiCode = "?code=" + txtWebApiCode.Text;
                    builder = new UriBuilder(strProtocol, txtHostName.Text, intPort, strWebDocument, strWebApiCode);
                }
                else
                {
                    // request mod download page and make sure it has proper return code
                    strWebDocument = ConfigurationManager.AppSettings["DownloadList"].ToString();
                    builder = new UriBuilder(strProtocol, txtHostName.Text, intPort, strWebDocument);
                }

                if (chkAnonDownload.Checked)
                {
                    wreq = WebRequest.Create(builder.Uri);
                    wreq.Method = "GET";

                    try
                    {
                        wresponse = (HttpWebResponse)wreq.GetResponse();
                        MessageBox.Show("Server replies with status code: " + wresponse.StatusDescription);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error connecting to server: " + ex.Message);
                    }
                }
                else
                {
                    // login
                    wreq = WebRequest.Create(builder.Uri);
                    wreq.Method = "GET";
                    wresponse = (HttpWebResponse)wreq.GetResponse();

                    // logout
                }
            }
        }

        private void txtHostName_Leave(object sender, EventArgs e)
        {
            txtHostName.Text = txtHostName.Text.ToLower().Trim();
            txtHostName.Text = txtHostName.Text.Trim('/');

            string strHttps = "https://";
            string strHttp = "http://";
            Regex objPortRegex = new Regex("^*:([0-9]{1,4}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$");

            if (txtHostName.Text.StartsWith(strHttps))
            {
                txtHostName.Text = txtHostName.Text.Substring(strHttps.Length);
                rbtHTTPS.Checked = true;
            }

            if(txtHostName.Text.StartsWith(strHttp))
            {
                txtHostName.Text = txtHostName.Text.Substring(strHttp.Length);
                rbtHTTP.Checked = true;
            }

            if(objPortRegex.IsMatch(txtHostName.Text))
            {
                Match objPortMatch = objPortRegex.Match(txtHostName.Text);
                txtPortNum.Text = objPortMatch.ToString().Trim(':');
                txtHostName.Text = txtHostName.Text.Substring(0, txtHostName.Text.LastIndexOf(':'));
            }
        }
    }
}

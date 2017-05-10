using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS_17_Server_Tools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string strServersXmlFile = "Servers.xml";
            ServersDataSet.ReadXml(strServersXmlFile);
            cmbCurrentServer.DataSource = ServersDataSet;
            //cmbCurrentServer.ValueMember = "Hostname";
            //cmbCurrentServer.DisplayMember = "Name";
        }

        private void cmbCurrentServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            FS_17_Server_Tools.frmAddServer frmToAdd = new frmAddServer();
            frmToAdd.Show();
        }

        private void btnEditServer_Click(object sender, EventArgs e)
        {

        }
    }
}

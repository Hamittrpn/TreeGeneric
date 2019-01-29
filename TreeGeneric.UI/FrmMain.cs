using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeGeneric.UI
{
    public partial class FrmMain : Form
    {
        private readonly ILifetimeScope scope;
        public FrmMain(ILifetimeScope scope)
        {
            InitializeComponent();
            this.scope = scope;
        }

        private void tbtnHome_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlDonation.Visible = false;
            pnlPlanting.Visible = false;
            pnlUser.Visible = false;
        }

        private void tbtnDonation_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlDonation.Visible = true;
            pnlPlanting.Visible = false;
            pnlUser.Visible = false;
        }

        private void tbtnPlanting_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlDonation.Visible = false;
            pnlPlanting.Visible = true;
            pnlUser.Visible = false;
        }

        private void tbtnUser_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlDonation.Visible = false;
            pnlPlanting.Visible = false;
            pnlUser.Visible = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bölgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegions frmRegions = new FrmRegions(scope);
            frmRegions.Show();
        }
    }
}

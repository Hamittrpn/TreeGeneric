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
using TreeGeneric.BusinessLogic;

namespace TreeGeneric.UI
{
    public partial class FrmRegions : Form
    {
        private readonly ILifetimeScope scope;
        private readonly IRegionService regionService;
        public FrmRegions(ILifetimeScope scope)
        {
            InitializeComponent();
            this.scope = scope;
            this.regionService = scope.Resolve<IRegionService>();
        }

        private void FrmRegions_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmRegion frmRegion = new FrmRegion(regionService, this, null);
            frmRegion.Show();
        }
        public void RefreshGrid()
        {
            this.dataGridView1.DataSource = regionService.GetAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                FrmRegion frmRegion = new FrmRegion(regionService, this, id);
                frmRegion.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                regionService.Delete(id);
                RefreshGrid();
            }
        }
    }
}

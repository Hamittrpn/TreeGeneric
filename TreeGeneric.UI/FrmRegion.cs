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
    public partial class FrmRegion : Form
    {
        private readonly IRegionService regionService;
        private readonly FrmRegions frmRegions;
        private readonly int? id;

        public FrmRegion(IRegionService regionService, FrmRegions frm, int? id)
        {
            InitializeComponent();
            this.regionService = regionService;
            this.frmRegions = frm;
            this.id = id;
            if (id != null)
            {
                this.Text = "Edit";
            }
            else
            {
                this.Text = "Add";
            }
        }

        private void FrmRegion_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                GetForUpdate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var region = new TreeGeneric.Model.Region();
                region.Capacity = int.Parse(this.txtCapacity.Text);
                region.Description = this.txtDescription.Text;
                region.Lat = this.txtLat.Text;
                region.Long = this.txtLong.Text;
                region.Photo = this.txtPhoto.Text;
                region.Name = this.txtName.Text;
                region.IsActive = this.chkIsActive.Checked ? true : false;
                if (id != null)
                {
                    regionService.Update(region);
                }
                else
                {
                    regionService.Insert(region);
                }
                this.frmRegions.RefreshGrid();
                if (id == null)
                {
                    MessageBox.Show("Region has been saved.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Region has been updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GetForUpdate()
        {
            var region = regionService.Find(id);
            this.txtCapacity.Text = region.Capacity.ToString();
            this.txtDescription.Text = region.Description;
            this.txtLat.Text = region.Lat;
            this.txtLong.Text = region.Long;
            this.txtName.Text = region.Name;
            this.txtPhoto.Text = region.Photo;
            this.chkIsActive.Checked = region.IsActive ? true : false;
        }

        private void ClearForm()
        {
            this.txtCapacity.Clear();
            this.txtDescription.Clear();
            this.txtLat.Clear();
            this.txtLong.Clear();
            this.txtName.Clear();
            this.txtPhoto.Clear();
            this.chkIsActive.Checked = false;
        }
    }
}

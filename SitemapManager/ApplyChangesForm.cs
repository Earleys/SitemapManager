using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SitemapManager
{
    public partial class ApplyChangesForm : Form
    {
        public bool isUrl { get; set; }
        public bool isModificationDate { get; set; }
        public bool isChangeFrequency { get; set; }
        public bool isPriority { get; set; }
        public DialogResult dialogResult { get; set; }

        public ApplyChangesForm(int count)
        {
            InitializeComponent();
            if (count > 1)
            {
                // this won't be possible most of the time, because it would cause many conflicts.
                // Urls should be unique.
                chkUrl.Enabled = false;
                chkUrl.Checked = false;
                chkUrl.Text = "Url (not possible because of conflicts)";
            }
        }

        private void ApplyChanges_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.isUrl = chkUrl.Checked;
            this.isModificationDate = chkModificationDate.Checked;
            this.isChangeFrequency = chkChangeFrequency.Checked;
            this.isPriority = chkPriority.Checked;
            this.dialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ApplyChangesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

using SitemapManager.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitemapManager
{
    public partial class Form1 : Form
    {
        SitemapManager sitemapManager = new SitemapManager();
        FileManager fileManager = new FileManager();
        Thread filterThread;
        ThreadStart filterThreadStart;

        private bool isFiltered = false;

        public Form1()
        {
            InitializeComponent();
            cmbFrequency.DataSource = Enum.GetValues(typeof(ChangeFrequency));
            cmbFilterChangeFrequency.DataSource = Enum.GetValues(typeof(ChangeFrequency));
            filterThreadStart = new ThreadStart(ApplyFiltering);
            filterThread = new Thread(filterThreadStart);
            ToggleFilteringTab(false);
            UpdatePriorityLabel();
        }

        private void loadSitemapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a sitemap.";
            ofd.Filter = "XML File|*.xml";
            string path = null;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }

            if (path != null)
            {
                sitemapManager.SitemapList = fileManager.ReadSiteMap(path);
            }
            RefreshTreeView(sitemapManager.SitemapList);
            ToggleFilteringTab(true);
        }

        private void RefreshTreeView(List<Sitemap> sitemapList)
        {
            tvResults.Nodes.Clear();
            tvResults.BeginUpdate();
            foreach (var item in sitemapList)
            {
                string parent = item.LocationUrl.Trim();
                tvResults.Nodes.Add(parent, parent);
                tvResults.Nodes[parent].Nodes.Add(item.LastModified.ToShortDateString().ToString());
                tvResults.Nodes[parent].Nodes.Add(item.Frequency.ToString());
                tvResults.Nodes[parent].Nodes.Add(item.Priority.ToString());
            }


            tvResults.EndUpdate();

        }

        private void tvResults_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == tvResults.SelectedNode)
            {
                string selectedParent = tvResults.SelectedNode.Text.ToString();
                Console.WriteLine(selectedParent);
                Sitemap sm = sitemapManager.GetSitemapElementByUrl(selectedParent);
                txtUrl.Text = sm.LocationUrl;
                dtpLastModified.Value = sm.LastModified;
                cmbFrequency.SelectedItem = sm.Frequency;
                tbPriority.Value = Convert.ToInt32(sm.Priority * 10);
            }
        }

        private void tbPriority_ValueChanged_1(object sender, EventArgs e)
        {
            UpdatePriorityLabel();
        }

        private string GetPriority(double priority) {
            return String.Format("{0:0.0}", priority);
        }


        private void UpdatePriorityLabel()
        {
            double value = Convert.ToDouble(tbPriority.Value) / 10;
            double filterValue = Convert.ToDouble(tbFilterPriority.Value) / 10;
            string finalValue = GetPriority(value);
            string finalFilterValue = GetPriority(filterValue);
            lblPriority.Text = "Priority (" + finalValue + ")";
            lblFilterPriority.Text = "Priority (" + finalFilterValue + ")";
        }

        private void prioritylowHighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sitemapManager.SitemapList = sitemapManager.SitemapList.OrderByDescending(o => o.Priority).ToList();
            sitemapManager.SitemapListFiltered = sitemapManager.SitemapListFiltered.OrderByDescending(o => o.Priority).ToList();
            ApplyFiltering();
        }

        private void priorityhighLowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sitemapManager.SitemapList = sitemapManager.SitemapList.OrderBy(o => o.Priority).ToList();
            sitemapManager.SitemapListFiltered = sitemapManager.SitemapListFiltered.OrderBy(o => o.Priority).ToList();
            ApplyFiltering();
        }

        private void urlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sitemapManager.SitemapList = sitemapManager.SitemapList.OrderBy(o => o.LocationUrl).ToList();
            sitemapManager.SitemapListFiltered = sitemapManager.SitemapListFiltered.OrderBy(o => o.LocationUrl).ToList();
            ApplyFiltering();
        }

        private void ApplyFiltering()
        {
            //merge filter list with normal list
            sitemapManager.SitemapList = sitemapManager.SitemapList.Union(sitemapManager.SitemapListFiltered).ToList();

            bool filterUrlChecked = chkFilterUrl.Checked;
            bool filterModificationDateChecked = chkFilterModificationDate.Checked;
            bool filterFrequencyChecked = chkFilterFrequency.Checked;
            bool filterPriorityChecked = chkFilterPriority.Checked;

            string filterUrl = txtFilterUrl.Text.ToLower();
            DateTime modificationDate = dtpFilterModificationDate.Value.Date;
            string frequency = cmbFilterChangeFrequency.SelectedValue.ToString();
            int priority = tbFilterPriority.Value;

            UrlFilter urlFilterProperties = new UrlFilter(filterUrlChecked, filterUrl, rdbFilterUrlContains.Checked, rdbFilterUrlStartsWith.Checked, rdbFilterUrlEndsWith.Checked);
            ModificationDateFilter modificationDateFilterProperties = new ModificationDateFilter(filterModificationDateChecked, modificationDate, rdbFilterModificationDateBefore.Checked, rdbFilterModificationDateAfter.Checked, chkFilterModificationDateAt.Checked, rdbFilterModificationDateExact.Checked);
            ChangeFrequencyFilter changeFrequencyFilterProperties = new ChangeFrequencyFilter(filterFrequencyChecked, frequency, rdbFilterChangeFrequencyOnlyThis.Checked, rdbFilterChangeFrequencyEverythingButThis.Checked);
            PriorityFilter priorityFilterProperties = new PriorityFilter(filterPriorityChecked, priority, rdbFilterPriorityLowerThan.Checked, rdbFilterPriorityHigherThan.Checked, chkFilterPriorityAt.Checked, rdbFilterPriorityExactValue.Checked);

            sitemapManager.SitemapListFiltered = sitemapManager.Filter(sitemapManager.SitemapList, urlFilterProperties, modificationDateFilterProperties, changeFrequencyFilterProperties, priorityFilterProperties);
            RefreshTreeView(sitemapManager.SitemapListFiltered);

            lblStatus.Text = "Showing " + sitemapManager.SitemapListFiltered.Count().ToString() + " items out of " + sitemapManager.SitemapList.Count().ToString() + " total items.";
        }

        

        private void chkFilterUrl_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilteringWhenValid();
        }

        private void ApplyFilteringWhenValid()
        {
            bool isAnythingChecked = groupBox1.Controls.OfType<CheckBox>().Any(c => c.Checked);
            isFiltered = isAnythingChecked;
            btnApplyFiltered.Enabled = isAnythingChecked;

            if (isAnythingChecked)
            {

                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => filterThread.Start()));
                }

                ApplyFiltering(); // todo  not threaded yet!!!
            }
            else
            {
                RefreshTreeView(sitemapManager.SitemapList);
            }
        }

        // add
        private void button1_Click(object sender, EventArgs e)
        {
            Sitemap sm = new Sitemap();
            sm.LocationUrl = txtUrl.Text;
            sm.LastModified = dtpLastModified.Value.Date;
            sm.Frequency = (ChangeFrequency)cmbFrequency.SelectedValue;
            double convertedPriorityValue = Convert.ToDouble(tbPriority.Value) / 10;
            sm.Priority = Convert.ToDouble(GetPriority(convertedPriorityValue));
            sitemapManager.SaveSitemapElement(sm);
            FinalizeChanges();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tvResults.SelectedNode != null)
            {
                Sitemap sm = sitemapManager.GetSitemapElementByUrl(tvResults.SelectedNode.Name);
                sm.LocationUrl = txtUrl.Text;
                sm.LastModified = dtpLastModified.Value;
                sm.Frequency = (ChangeFrequency)cmbFrequency.SelectedValue;
                double convertedPriorityValue = Convert.ToDouble(tbPriority.Value) / 10;
                sm.Priority = Convert.ToDouble(GetPriority(convertedPriorityValue));
                FinalizeChanges();
            } else
            {
                MessageBox.Show("Unable to make changes. Please select an item from the list first.", "Cannot apply changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tvResults.SelectedNode != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete '" + tvResults.SelectedNode.Name + "' and all of it's child elements completely?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Sitemap sm = sitemapManager.GetSitemapElementByUrl(tvResults.SelectedNode.Name);
                    sitemapManager.deleteSitemapElement(sm);
                    FinalizeChanges();
                }
            } else
            {
                MessageBox.Show("Unable to delete. Please select an item from the list first.", "Cannot delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalizeChanges()
        {
            RefreshTreeView(sitemapManager.SitemapList);
            ApplyFilteringWhenValid();
            ToggleFilteringTab(true);
        }

        private void ToggleFilteringTab(bool value)
        {
            ((Control)tpFiltering).Enabled = value;
        }


        private void tvResults_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Sitemap sm = sitemapManager.GetSitemapElementByUrl(e.Node.Name);
            txtUrl.Text = sm.LocationUrl;
            dtpLastModified.Value = sm.LastModified;
            cmbFrequency.SelectedIndex = cmbFrequency.FindString(sm.Frequency.ToString());
            tbPriority.Value = Convert.ToInt32(sm.Priority * 10);
        }


    }
}

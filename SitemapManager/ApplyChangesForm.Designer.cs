namespace SitemapManager
{
    partial class ApplyChangesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chkUrl = new System.Windows.Forms.CheckBox();
            this.chkModificationDate = new System.Windows.Forms.CheckBox();
            this.chkChangeFrequency = new System.Windows.Forms.CheckBox();
            this.chkPriority = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select which items should be replaced with the new fields.";
            // 
            // chkUrl
            // 
            this.chkUrl.AutoSize = true;
            this.chkUrl.Location = new System.Drawing.Point(16, 40);
            this.chkUrl.Name = "chkUrl";
            this.chkUrl.Size = new System.Drawing.Size(39, 17);
            this.chkUrl.TabIndex = 1;
            this.chkUrl.Text = "Url";
            this.chkUrl.UseVisualStyleBackColor = true;
            // 
            // chkModificationDate
            // 
            this.chkModificationDate.AutoSize = true;
            this.chkModificationDate.Checked = true;
            this.chkModificationDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModificationDate.Location = new System.Drawing.Point(16, 63);
            this.chkModificationDate.Name = "chkModificationDate";
            this.chkModificationDate.Size = new System.Drawing.Size(107, 17);
            this.chkModificationDate.TabIndex = 2;
            this.chkModificationDate.Text = "Modification date";
            this.chkModificationDate.UseVisualStyleBackColor = true;
            // 
            // chkChangeFrequency
            // 
            this.chkChangeFrequency.AutoSize = true;
            this.chkChangeFrequency.Checked = true;
            this.chkChangeFrequency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeFrequency.Location = new System.Drawing.Point(16, 86);
            this.chkChangeFrequency.Name = "chkChangeFrequency";
            this.chkChangeFrequency.Size = new System.Drawing.Size(116, 17);
            this.chkChangeFrequency.TabIndex = 3;
            this.chkChangeFrequency.Text = "Change Frequency";
            this.chkChangeFrequency.UseVisualStyleBackColor = true;
            // 
            // chkPriority
            // 
            this.chkPriority.AutoSize = true;
            this.chkPriority.Checked = true;
            this.chkPriority.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPriority.Location = new System.Drawing.Point(16, 109);
            this.chkPriority.Name = "chkPriority";
            this.chkPriority.Size = new System.Drawing.Size(57, 17);
            this.chkPriority.TabIndex = 4;
            this.chkPriority.Text = "Priority";
            this.chkPriority.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(102, 128);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ApplyChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 163);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.chkPriority);
            this.Controls.Add(this.chkChangeFrequency);
            this.Controls.Add(this.chkModificationDate);
            this.Controls.Add(this.chkUrl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplyChangesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply changes...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplyChangesForm_FormClosing);
            this.Load += new System.EventHandler(this.ApplyChanges_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUrl;
        private System.Windows.Forms.CheckBox chkModificationDate;
        private System.Windows.Forms.CheckBox chkChangeFrequency;
        private System.Windows.Forms.CheckBox chkPriority;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}
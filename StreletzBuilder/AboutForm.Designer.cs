
namespace StreletzBuilder
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelProgramName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.labelYears = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.labelProgramName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProgramName.Location = new System.Drawing.Point(14, 12);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(207, 37);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "StreletzBuilder";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(14, 156);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(127, 20);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "© Стрелец Coder";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(14, 176);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(165, 20);
            this.linkLabelSite.TabIndex = 2;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "https://streletzcoder.ru/";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Location = new System.Drawing.Point(14, 196);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(41, 20);
            this.labelYears.TabIndex = 3;
            this.labelYears.Text = "2021";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(80, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(15, 57);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(59, 20);
            this.labelVersion.TabIndex = 5;
            this.labelVersion.Text = "Версия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Бета";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelYears);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelProgramName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label1;
    }
}

namespace StreletzBuilder
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelGitTitle = new System.Windows.Forms.Label();
            this.textBoxGit = new System.Windows.Forms.TextBox();
            this.labelRepositoryTitle = new System.Windows.Forms.Label();
            this.textBoxRepository = new System.Windows.Forms.TextBox();
            this.labelSlnTitle = new System.Windows.Forms.Label();
            this.textBoxSln = new System.Windows.Forms.TextBox();
            this.buttonGit = new System.Windows.Forms.Button();
            this.buttonRepositorySelection = new System.Windows.Forms.Button();
            this.buttonSln = new System.Windows.Forms.Button();
            this.repositoryFolderSelectionDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogGit = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogSln = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(594, 202);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(694, 202);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 29);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelGitTitle
            // 
            this.labelGitTitle.AutoSize = true;
            this.labelGitTitle.Location = new System.Drawing.Point(12, 9);
            this.labelGitTitle.Name = "labelGitTitle";
            this.labelGitTitle.Size = new System.Drawing.Size(171, 20);
            this.labelGitTitle.TabIndex = 2;
            this.labelGitTitle.Text = "Исполняемый файл Git";
            // 
            // textBoxGit
            // 
            this.textBoxGit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGit.Location = new System.Drawing.Point(12, 32);
            this.textBoxGit.Name = "textBoxGit";
            this.textBoxGit.ReadOnly = true;
            this.textBoxGit.Size = new System.Drawing.Size(676, 27);
            this.textBoxGit.TabIndex = 3;
            // 
            // labelRepositoryTitle
            // 
            this.labelRepositoryTitle.AutoSize = true;
            this.labelRepositoryTitle.Location = new System.Drawing.Point(12, 62);
            this.labelRepositoryTitle.Name = "labelRepositoryTitle";
            this.labelRepositoryTitle.Size = new System.Drawing.Size(193, 20);
            this.labelRepositoryTitle.TabIndex = 4;
            this.labelRepositoryTitle.Text = "Папка с репозиторием Git";
            // 
            // textBoxRepository
            // 
            this.textBoxRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepository.Location = new System.Drawing.Point(12, 85);
            this.textBoxRepository.Name = "textBoxRepository";
            this.textBoxRepository.ReadOnly = true;
            this.textBoxRepository.Size = new System.Drawing.Size(676, 27);
            this.textBoxRepository.TabIndex = 5;
            // 
            // labelSlnTitle
            // 
            this.labelSlnTitle.AutoSize = true;
            this.labelSlnTitle.Location = new System.Drawing.Point(12, 115);
            this.labelSlnTitle.Name = "labelSlnTitle";
            this.labelSlnTitle.Size = new System.Drawing.Size(202, 20);
            this.labelSlnTitle.TabIndex = 6;
            this.labelSlnTitle.Text = "Файл решения Visual Studio";
            // 
            // textBoxSln
            // 
            this.textBoxSln.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSln.Location = new System.Drawing.Point(12, 138);
            this.textBoxSln.Name = "textBoxSln";
            this.textBoxSln.ReadOnly = true;
            this.textBoxSln.Size = new System.Drawing.Size(676, 27);
            this.textBoxSln.TabIndex = 7;
            // 
            // buttonGit
            // 
            this.buttonGit.Location = new System.Drawing.Point(694, 31);
            this.buttonGit.Name = "buttonGit";
            this.buttonGit.Size = new System.Drawing.Size(94, 29);
            this.buttonGit.TabIndex = 8;
            this.buttonGit.Text = "Выбрать";
            this.buttonGit.UseVisualStyleBackColor = true;
            this.buttonGit.Click += new System.EventHandler(this.buttonGit_Click);
            // 
            // buttonRepositorySelection
            // 
            this.buttonRepositorySelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRepositorySelection.Location = new System.Drawing.Point(694, 84);
            this.buttonRepositorySelection.Name = "buttonRepositorySelection";
            this.buttonRepositorySelection.Size = new System.Drawing.Size(94, 29);
            this.buttonRepositorySelection.TabIndex = 9;
            this.buttonRepositorySelection.Text = "Выбрать";
            this.buttonRepositorySelection.UseVisualStyleBackColor = true;
            this.buttonRepositorySelection.Click += new System.EventHandler(this.buttonRepositorySelection_Click);
            // 
            // buttonSln
            // 
            this.buttonSln.Location = new System.Drawing.Point(694, 137);
            this.buttonSln.Name = "buttonSln";
            this.buttonSln.Size = new System.Drawing.Size(94, 29);
            this.buttonSln.TabIndex = 10;
            this.buttonSln.Text = "Выбрать";
            this.buttonSln.UseVisualStyleBackColor = true;
            this.buttonSln.Click += new System.EventHandler(this.buttonSln_Click);
            // 
            // repositoryFolderSelectionDialog
            // 
            this.repositoryFolderSelectionDialog.Description = "Папка с репозиторием Git";
            // 
            // openFileDialogGit
            // 
            this.openFileDialogGit.Filter = "Исполняемые файлы|*.exe;";
            // 
            // openFileDialogSln
            // 
            this.openFileDialogSln.Filter = "Файлы решений Visual Studio|*.sln;";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 243);
            this.Controls.Add(this.buttonSln);
            this.Controls.Add(this.buttonRepositorySelection);
            this.Controls.Add(this.buttonGit);
            this.Controls.Add(this.textBoxSln);
            this.Controls.Add(this.labelSlnTitle);
            this.Controls.Add(this.textBoxRepository);
            this.Controls.Add(this.labelRepositoryTitle);
            this.Controls.Add(this.textBoxGit);
            this.Controls.Add(this.labelGitTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelGitTitle;
        private System.Windows.Forms.TextBox textBoxGit;
        private System.Windows.Forms.Label labelRepositoryTitle;
        private System.Windows.Forms.TextBox textBoxRepository;
        private System.Windows.Forms.Label labelSlnTitle;
        private System.Windows.Forms.TextBox textBoxSln;
        private System.Windows.Forms.Button buttonGit;
        private System.Windows.Forms.Button buttonRepositorySelection;
        private System.Windows.Forms.Button buttonSln;
        private System.Windows.Forms.FolderBrowserDialog repositoryFolderSelectionDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialogGit;
        private System.Windows.Forms.OpenFileDialog openFileDialogSln;
    }
}
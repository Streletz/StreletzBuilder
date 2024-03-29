﻿
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
            this.groupBoxMsBulid = new System.Windows.Forms.GroupBox();
            this.buttonSelectMsBuild = new System.Windows.Forms.Button();
            this.textBoxMSBuild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxUseMsBuild = new System.Windows.Forms.CheckBox();
            this.openFileDialogMsBuild = new System.Windows.Forms.OpenFileDialog();
            this.labelVsVersionTitle = new System.Windows.Forms.Label();
            this.comboBoxVsVersion = new System.Windows.Forms.ComboBox();
            this.groupBoxMsBulid.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(594, 364);
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
            this.buttonCancel.Location = new System.Drawing.Point(694, 364);
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
            // groupBoxMsBulid
            // 
            this.groupBoxMsBulid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMsBulid.Controls.Add(this.comboBoxVsVersion);
            this.groupBoxMsBulid.Controls.Add(this.labelVsVersionTitle);
            this.groupBoxMsBulid.Controls.Add(this.buttonSelectMsBuild);
            this.groupBoxMsBulid.Controls.Add(this.textBoxMSBuild);
            this.groupBoxMsBulid.Controls.Add(this.label1);
            this.groupBoxMsBulid.Controls.Add(this.checkBoxUseMsBuild);
            this.groupBoxMsBulid.Location = new System.Drawing.Point(12, 171);
            this.groupBoxMsBulid.Name = "groupBoxMsBulid";
            this.groupBoxMsBulid.Size = new System.Drawing.Size(776, 187);
            this.groupBoxMsBulid.TabIndex = 11;
            this.groupBoxMsBulid.TabStop = false;
            this.groupBoxMsBulid.Text = "Использование MSBuild";
            // 
            // buttonSelectMsBuild
            // 
            this.buttonSelectMsBuild.Location = new System.Drawing.Point(676, 75);
            this.buttonSelectMsBuild.Name = "buttonSelectMsBuild";
            this.buttonSelectMsBuild.Size = new System.Drawing.Size(94, 29);
            this.buttonSelectMsBuild.TabIndex = 3;
            this.buttonSelectMsBuild.Text = "Выбрать";
            this.buttonSelectMsBuild.UseVisualStyleBackColor = true;
            this.buttonSelectMsBuild.Click += new System.EventHandler(this.buttonSelectMsBuild_Click);
            // 
            // textBoxMSBuild
            // 
            this.textBoxMSBuild.Location = new System.Drawing.Point(6, 76);
            this.textBoxMSBuild.Name = "textBoxMSBuild";
            this.textBoxMSBuild.ReadOnly = true;
            this.textBoxMSBuild.Size = new System.Drawing.Size(664, 27);
            this.textBoxMSBuild.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл MSBuild.exe";
            // 
            // checkBoxUseMsBuild
            // 
            this.checkBoxUseMsBuild.AutoSize = true;
            this.checkBoxUseMsBuild.Location = new System.Drawing.Point(6, 26);
            this.checkBoxUseMsBuild.Name = "checkBoxUseMsBuild";
            this.checkBoxUseMsBuild.Size = new System.Drawing.Size(356, 24);
            this.checkBoxUseMsBuild.TabIndex = 0;
            this.checkBoxUseMsBuild.Text = "Использовать MSBuild вместо команды dotnet";
            this.checkBoxUseMsBuild.UseVisualStyleBackColor = true;
            this.checkBoxUseMsBuild.CheckedChanged += new System.EventHandler(this.checkBoxUseMsBuild_CheckedChanged);
            // 
            // openFileDialogMsBuild
            // 
            this.openFileDialogMsBuild.Filter = "Файл MSBuild.exe|MSBuild.exe;";
            // 
            // labelVsVersionTitle
            // 
            this.labelVsVersionTitle.AutoSize = true;
            this.labelVsVersionTitle.Location = new System.Drawing.Point(6, 106);
            this.labelVsVersionTitle.Name = "labelVsVersionTitle";
            this.labelVsVersionTitle.Size = new System.Drawing.Size(149, 20);
            this.labelVsVersionTitle.TabIndex = 4;
            this.labelVsVersionTitle.Text = "Версия Visual Studio";
            // 
            // comboBoxVsVersion
            // 
            this.comboBoxVsVersion.FormattingEnabled = true;
            this.comboBoxVsVersion.Location = new System.Drawing.Point(6, 129);
            this.comboBoxVsVersion.Name = "comboBoxVsVersion";
            this.comboBoxVsVersion.Size = new System.Drawing.Size(664, 28);
            this.comboBoxVsVersion.TabIndex = 5;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.groupBoxMsBulid);
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
            this.groupBoxMsBulid.ResumeLayout(false);
            this.groupBoxMsBulid.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxMsBulid;
        private System.Windows.Forms.CheckBox checkBoxUseMsBuild;
        private System.Windows.Forms.Button buttonSelectMsBuild;
        private System.Windows.Forms.TextBox textBoxMSBuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogMsBuild;
        private System.Windows.Forms.ComboBox comboBoxVsVersion;
        private System.Windows.Forms.Label labelVsVersionTitle;
    }
}
using StreletzBuilder.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreletzBuilder
{
    public partial class SettingsForm : Form
    {
        private bool closeByBtn = false;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonRepositorySelection_Click(object sender, EventArgs e)
        {
            if (repositoryFolderSelectionDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRepository.Text = repositoryFolderSelectionDialog.SelectedPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SettingsManager.GetInstance().Settings.GitPath = textBoxGit.Text;
            SettingsManager.GetInstance().Settings.RepositoryPath = textBoxRepository.Text;
            SettingsManager.GetInstance().Settings.SolutionFilePath = textBoxSln.Text;
            SettingsManager.GetInstance().Settings.UseMsBuild = checkBoxUseMsBuild.Checked;
            SettingsManager.GetInstance().Settings.MsBuildExePath = textBoxMSBuild.Text;
            if (!((checkBoxUseMsBuild.Checked && !string.IsNullOrEmpty(textBoxMSBuild.Text) && !string.IsNullOrWhiteSpace(textBoxMSBuild.Text)) || !checkBoxUseMsBuild.Checked))
            {
                MessageBox.Show("Расположение файла MSBuild.exe не указано!");
            }
            closeByBtn = true;
        }

        private void buttonGit_Click(object sender, EventArgs e)
        {
            if (openFileDialogGit.ShowDialog() == DialogResult.OK)
            {
                textBoxGit.Text = openFileDialogGit.FileName;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBoxGit.Text = SettingsManager.GetInstance().Settings.GitPath;
            textBoxRepository.Text = SettingsManager.GetInstance().Settings.RepositoryPath;
            textBoxSln.Text = SettingsManager.GetInstance().Settings.SolutionFilePath;
            checkBoxUseMsBuild.Checked = SettingsManager.GetInstance().Settings.UseMsBuild;
            textBoxMSBuild.Text = SettingsManager.GetInstance().Settings.MsBuildExePath;
            buttonSelectMsBuild.Enabled = SettingsManager.GetInstance().Settings.UseMsBuild;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeByBtn)
            {
                e.Cancel = !SettingsManager.GetInstance().Ready;
                if (!e.Cancel)
                {
                    SettingsManager.GetInstance().Save();
                }
                else
                {
                    MessageBox.Show("Задайте все настройки или нажмите \"Отмена\"!");
                }
                closeByBtn = false;
            }
        }

        private void buttonSln_Click(object sender, EventArgs e)
        {
            if (openFileDialogSln.ShowDialog() == DialogResult.OK)
            {
                textBoxSln.Text = openFileDialogSln.FileName;
            }
        }

        private void checkBoxUseMsBuild_CheckedChanged(object sender, EventArgs e)
        {
            buttonSelectMsBuild.Enabled = checkBoxUseMsBuild.Checked;
        }

        private void buttonSelectMsBuild_Click(object sender, EventArgs e)
        {
            if (openFileDialogMsBuild.ShowDialog() == DialogResult.OK)
            {
                textBoxMSBuild.Text = openFileDialogMsBuild.FileName;
            }
        }
    }
}

using GitIntegration;
using NetCoreBuildIntegration.Builders;
using StreletzBuilder.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreletzBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void contextMenuStripFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "exitProgramMenuItem":
                    Close();
                    break;
            }
        }

        private void contextMenuStripTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "settingsMenuItem":
                    SettingsForm settingsForm = new SettingsForm();
                    settingsForm.ShowDialog();
                    break;
            }
        }


        private void contextMenuStripHelp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "aboutMenuItem":
                    {
                        AboutForm aboutForm = new AboutForm();
                        aboutForm.ShowDialog();
                    }
                    break;
            }
        }

        private void contextMenuStripSaveOutput_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "saveGitOutputMenuItem":
                    SaveIntoTextFile(textBoxGit.Text);
                    break;
                case "saveBuildOutputMenuItem":
                    SaveIntoTextFile(textBoxBuild.Text);
                    break;
            }
        }

        private void SaveIntoTextFile(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Нет данных для сохранения!");
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, text);
            }
        }

        private void buttonUpdateBuild_Click(object sender, EventArgs e)
        {
            _ = UpdateAndBuild();
        }

        private async Task UpdateAndBuild()
        {
            if (!CheckConfigurationReady())
            {
                return;
            }
            outputDataTabs.SelectedTab = gitPage;
            await UpdateFromRemoteRepositoryAsync();
            outputDataTabs.SelectedTab = buildPage;
            await buildAsync();
        }

        private async Task buildAsync()
        {
            ISolutionBuilder builder;
            statusLabel.Text = "Сборка...";
            if (SettingsManager.GetInstance().Settings.UseMsBuild)
            {
                builder = new NetFrameworkBuilder(SettingsManager.GetInstance().Settings.MsBuildExePath, SettingsManager.GetInstance().Settings.SelectedVsVersion)
                {
                    SolutionFilePath = SettingsManager.GetInstance().Settings.SolutionFilePath
                };
            }
            else
            {
                builder = new NetCoreBuilder()
                {
                    SolutionFilePath = SettingsManager.GetInstance().Settings.SolutionFilePath
                };
            }
            textBoxBuild.Text = await builder.BuildAsync();
            statusLabel.Text = "Сборка выполнена!";
        }

        private async Task UpdateFromRemoteRepositoryAsync()
        {
            statusLabel.Text = "Обновление репозитория...";
            Git git = new()
            {
                GitPath = SettingsManager.GetInstance().Settings.GitPath,
                RepositoryPath = SettingsManager.GetInstance().Settings.RepositoryPath
            };
            textBoxGit.Text = await git.PullAsync();
            statusLabel.Text = "Репозиторий обновлён!";
        }

        private bool CheckConfigurationReady()
        {
            if (!SettingsManager.GetInstance().Ready)
            {
                statusLabel.Text = "К работе не готов!";
                MessageBox.Show("Не заданы параметры настроек!");
                return false;
            }
            return true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckConfigurationReady())
            {
                return;
            }
            outputDataTabs.SelectedTab = gitPage;
            _ = UpdateFromRemoteRepositoryAsync();
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (!CheckConfigurationReady())
            {
                return;
            }
            outputDataTabs.SelectedTab = buildPage;
            _ = buildAsync();
        }
    }
}


namespace StreletzBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripSaveOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveGitOutputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBuildOutputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitProgramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripHelp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.outputDataTabs = new System.Windows.Forms.TabControl();
            this.gitPage = new System.Windows.Forms.TabPage();
            this.textBoxGit = new System.Windows.Forms.TextBox();
            this.buildPage = new System.Windows.Forms.TabPage();
            this.textBoxBuild = new System.Windows.Forms.TextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.imageListActions = new System.Windows.Forms.ImageList(this.components);
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonUpdateBuild = new System.Windows.Forms.Button();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.contextMenuStripFile.SuspendLayout();
            this.contextMenuStripSaveOutput.SuspendLayout();
            this.contextMenuStripTools.SuspendLayout();
            this.contextMenuStripHelp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.outputDataTabs.SuspendLayout();
            this.gitPage.SuspendLayout();
            this.buildPage.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.toolsMenuItem,
            this.helpStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(914, 30);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDown = this.contextMenuStripFile;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileMenuItem.Text = "&Файл";
            // 
            // contextMenuStripFile
            // 
            this.contextMenuStripFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.toolStripSeparator1,
            this.exitProgramMenuItem});
            this.contextMenuStripFile.Name = "contextMenuStripFile";
            this.contextMenuStripFile.OwnerItem = this.fileMenuItem;
            this.contextMenuStripFile.Size = new System.Drawing.Size(153, 58);
            this.contextMenuStripFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripFile_ItemClicked);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.DropDown = this.contextMenuStripSaveOutput;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saveMenuItem.Text = "&Сохранить";
            // 
            // contextMenuStripSaveOutput
            // 
            this.contextMenuStripSaveOutput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSaveOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGitOutputMenuItem,
            this.saveBuildOutputMenuItem});
            this.contextMenuStripSaveOutput.Name = "contextMenuStripSaveOutput";
            this.contextMenuStripSaveOutput.OwnerItem = this.saveMenuItem;
            this.contextMenuStripSaveOutput.Size = new System.Drawing.Size(178, 52);
            this.contextMenuStripSaveOutput.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripSaveOutput_ItemClicked);
            // 
            // saveGitOutputMenuItem
            // 
            this.saveGitOutputMenuItem.Name = "saveGitOutputMenuItem";
            this.saveGitOutputMenuItem.Size = new System.Drawing.Size(177, 24);
            this.saveGitOutputMenuItem.Text = "&Вывод Git";
            // 
            // saveBuildOutputMenuItem
            // 
            this.saveBuildOutputMenuItem.Name = "saveBuildOutputMenuItem";
            this.saveBuildOutputMenuItem.Size = new System.Drawing.Size(177, 24);
            this.saveBuildOutputMenuItem.Text = "Вывод &сборки";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitProgramMenuItem
            // 
            this.exitProgramMenuItem.Name = "exitProgramMenuItem";
            this.exitProgramMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitProgramMenuItem.Text = "&Выход";
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDown = this.contextMenuStripTools;
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(73, 24);
            this.toolsMenuItem.Text = "&Сервис";
            // 
            // contextMenuStripTools
            // 
            this.contextMenuStripTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.contextMenuStripTools.Name = "contextMenuStripTools";
            this.contextMenuStripTools.OwnerItem = this.toolsMenuItem;
            this.contextMenuStripTools.Size = new System.Drawing.Size(153, 28);
            this.contextMenuStripTools.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripTools_ItemClicked);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(152, 24);
            this.settingsMenuItem.Text = "&Настройка";
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.DropDown = this.contextMenuStripHelp;
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.helpStripMenuItem.Text = "С&правка";
            // 
            // contextMenuStripHelp
            // 
            this.contextMenuStripHelp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.contextMenuStripHelp.Name = "contextMenuStripHelp";
            this.contextMenuStripHelp.OwnerItem = this.helpStripMenuItem;
            this.contextMenuStripHelp.Size = new System.Drawing.Size(174, 28);
            this.contextMenuStripHelp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripHelp_ItemClicked);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(173, 24);
            this.aboutMenuItem.Text = "&О программе";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(914, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(116, 20);
            this.statusLabel.Text = "Готов к работе!";
            // 
            // outputDataTabs
            // 
            this.outputDataTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDataTabs.Controls.Add(this.gitPage);
            this.outputDataTabs.Controls.Add(this.buildPage);
            this.outputDataTabs.Location = new System.Drawing.Point(14, 141);
            this.outputDataTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputDataTabs.Name = "outputDataTabs";
            this.outputDataTabs.SelectedIndex = 0;
            this.outputDataTabs.Size = new System.Drawing.Size(887, 425);
            this.outputDataTabs.TabIndex = 2;
            // 
            // gitPage
            // 
            this.gitPage.Controls.Add(this.textBoxGit);
            this.gitPage.Location = new System.Drawing.Point(4, 29);
            this.gitPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gitPage.Name = "gitPage";
            this.gitPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gitPage.Size = new System.Drawing.Size(879, 392);
            this.gitPage.TabIndex = 0;
            this.gitPage.Text = "Вывод Git";
            this.gitPage.UseVisualStyleBackColor = true;
            // 
            // textBoxGit
            // 
            this.textBoxGit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGit.Location = new System.Drawing.Point(3, 4);
            this.textBoxGit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGit.Multiline = true;
            this.textBoxGit.Name = "textBoxGit";
            this.textBoxGit.ReadOnly = true;
            this.textBoxGit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGit.Size = new System.Drawing.Size(870, 379);
            this.textBoxGit.TabIndex = 0;
            // 
            // buildPage
            // 
            this.buildPage.Controls.Add(this.textBoxBuild);
            this.buildPage.Location = new System.Drawing.Point(4, 29);
            this.buildPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buildPage.Name = "buildPage";
            this.buildPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buildPage.Size = new System.Drawing.Size(879, 392);
            this.buildPage.TabIndex = 1;
            this.buildPage.Text = "Вывод сборки";
            this.buildPage.UseVisualStyleBackColor = true;
            // 
            // textBoxBuild
            // 
            this.textBoxBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuild.Location = new System.Drawing.Point(3, 4);
            this.textBoxBuild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBuild.Multiline = true;
            this.textBoxBuild.Name = "textBoxBuild";
            this.textBoxBuild.ReadOnly = true;
            this.textBoxBuild.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBuild.Size = new System.Drawing.Size(870, 379);
            this.textBoxBuild.TabIndex = 0;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActions.Controls.Add(this.buttonBuild);
            this.groupBoxActions.Controls.Add(this.buttonUpdate);
            this.groupBoxActions.Controls.Add(this.buttonUpdateBuild);
            this.groupBoxActions.Location = new System.Drawing.Point(18, 36);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxActions.Size = new System.Drawing.Size(878, 97);
            this.groupBoxActions.TabIndex = 3;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Действия";
            // 
            // buttonBuild
            // 
            this.buttonBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuild.ImageIndex = 0;
            this.buttonBuild.ImageList = this.imageListActions;
            this.buttonBuild.Location = new System.Drawing.Point(489, 29);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(234, 60);
            this.buttonBuild.TabIndex = 2;
            this.buttonBuild.Text = "Только собрать";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // imageListActions
            // 
            this.imageListActions.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListActions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListActions.ImageStream")));
            this.imageListActions.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListActions.Images.SetKeyName(0, "kisspng-tool-free-content-clip-art-mechanic-tools-cliparts-5aa9cc8344b9b0.3221463" +
        "015210773792815.png");
            this.imageListActions.Images.SetKeyName(1, "kisspng-clip-art-update-button-5ad5b300159197.0271801615239544320884.png");
            this.imageListActions.Images.SetKeyName(2, "kisspng-computer-icons-desktop-wallpaper-icon-design-image-web-2-ruby-red-refresh" +
        "-icon-free-web-2-ruby-red-5b6e421be31bc4.3793982515339525399303.png");
            this.imageListActions.Images.SetKeyName(3, "kisspng-computer-icons-download-clip-art-5afc7497740939.3730564915264943594753.pn" +
        "g");
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.ImageIndex = 3;
            this.buttonUpdate.ImageList = this.imageListActions;
            this.buttonUpdate.Location = new System.Drawing.Point(248, 29);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(234, 60);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Только обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonUpdateBuild
            // 
            this.buttonUpdateBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateBuild.ImageIndex = 2;
            this.buttonUpdateBuild.ImageList = this.imageListActions;
            this.buttonUpdateBuild.Location = new System.Drawing.Point(7, 29);
            this.buttonUpdateBuild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateBuild.Name = "buttonUpdateBuild";
            this.buttonUpdateBuild.Size = new System.Drawing.Size(234, 60);
            this.buttonUpdateBuild.TabIndex = 0;
            this.buttonUpdateBuild.Text = "Обновить и собрать";
            this.buttonUpdateBuild.UseVisualStyleBackColor = true;
            this.buttonUpdateBuild.Click += new System.EventHandler(this.buttonUpdateBuild_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitMenuItem.Text = "&Выход";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Текстовые файлы|*.txt;";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.outputDataTabs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Streletz Builder";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenuStripFile.ResumeLayout(false);
            this.contextMenuStripSaveOutput.ResumeLayout(false);
            this.contextMenuStripTools.ResumeLayout(false);
            this.contextMenuStripHelp.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.outputDataTabs.ResumeLayout(false);
            this.gitPage.ResumeLayout(false);
            this.gitPage.PerformLayout();
            this.buildPage.ResumeLayout(false);
            this.buildPage.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl outputDataTabs;
        private System.Windows.Forms.TabPage gitPage;
        private System.Windows.Forms.TextBox textBoxGit;
        private System.Windows.Forms.TabPage buildPage;
        private System.Windows.Forms.TextBox textBoxBuild;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonUpdateBuild;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFile;
        private System.Windows.Forms.ToolStripMenuItem exitProgramMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ImageList imageListActions;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSaveOutput;
        private System.Windows.Forms.ToolStripMenuItem saveGitOutputMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBuildOutputMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTools;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}


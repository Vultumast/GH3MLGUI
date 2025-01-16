namespace GH3MLGUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            modCheckedListBox = new CheckedListBox();
            pluginContextMenuStrip = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            moveModUpToolStripMenuItem = new ToolStripMenuItem();
            moveModDownToolStripMenuItem = new ToolStripMenuItem();
            launchGH3Button = new Button();
            panel1 = new Panel();
            label3 = new Label();
            savePathLinkLabel = new LinkLabel();
            gamePathLinkLabel = new LinkLabel();
            toolStrip1 = new ToolStrip();
            installLoaderToolStripButton = new ToolStripButton();
            versionToolStripLabel = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripButton = new ToolStripButton();
            settingsToolStripButton = new ToolStripButton();
            checkForLoaderUpdatesToolStripButton = new ToolStripButton();
            aboutToolStripButton = new ToolStripButton();
            pluginContextMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // modCheckedListBox
            // 
            modCheckedListBox.ContextMenuStrip = pluginContextMenuStrip;
            modCheckedListBox.FormattingEnabled = true;
            modCheckedListBox.IntegralHeight = false;
            modCheckedListBox.Location = new Point(12, 28);
            modCheckedListBox.Name = "modCheckedListBox";
            modCheckedListBox.Size = new Size(270, 363);
            modCheckedListBox.TabIndex = 0;
            // 
            // pluginContextMenuStrip
            // 
            pluginContextMenuStrip.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, toolStripSeparator2, moveModUpToolStripMenuItem, moveModDownToolStripMenuItem });
            pluginContextMenuStrip.Name = "pluginContextMenuStrip";
            pluginContextMenuStrip.Size = new Size(167, 76);
            pluginContextMenuStrip.Opening += pluginContextMenuStrip_Opening;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(166, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(163, 6);
            // 
            // moveModUpToolStripMenuItem
            // 
            moveModUpToolStripMenuItem.Name = "moveModUpToolStripMenuItem";
            moveModUpToolStripMenuItem.Size = new Size(166, 22);
            moveModUpToolStripMenuItem.Text = "Move Mod Up";
            moveModUpToolStripMenuItem.Click += moveModUpToolStripMenuItem_Click;
            // 
            // moveModDownToolStripMenuItem
            // 
            moveModDownToolStripMenuItem.Name = "moveModDownToolStripMenuItem";
            moveModDownToolStripMenuItem.Size = new Size(166, 22);
            moveModDownToolStripMenuItem.Text = "Move Mod Down";
            moveModDownToolStripMenuItem.Click += moveModDownToolStripMenuItem_Click;
            // 
            // launchGH3Button
            // 
            launchGH3Button.Location = new Point(12, 397);
            launchGH3Button.Name = "launchGH3Button";
            launchGH3Button.Size = new Size(270, 26);
            launchGH3Button.TabIndex = 1;
            launchGH3Button.Text = "Save and Launch GH3";
            launchGH3Button.UseVisualStyleBackColor = true;
            launchGH3Button.Click += launchGH3Button_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(288, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 363);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(220, 15);
            label3.TabIndex = 0;
            label3.Text = "Plugin specific settings are not yet done!";
            // 
            // savePathLinkLabel
            // 
            savePathLinkLabel.AutoSize = true;
            savePathLinkLabel.Font = new Font("Consolas", 9F);
            savePathLinkLabel.Location = new Point(288, 409);
            savePathLinkLabel.Name = "savePathLinkLabel";
            savePathLinkLabel.Size = new Size(77, 14);
            savePathLinkLabel.TabIndex = 6;
            savePathLinkLabel.TabStop = true;
            savePathLinkLabel.Text = "Save Path:";
            savePathLinkLabel.LinkClicked += savePathLinkLabel_LinkClicked;
            // 
            // gamePathLinkLabel
            // 
            gamePathLinkLabel.AutoSize = true;
            gamePathLinkLabel.Font = new Font("Consolas", 9F);
            gamePathLinkLabel.Location = new Point(288, 394);
            gamePathLinkLabel.Name = "gamePathLinkLabel";
            gamePathLinkLabel.Size = new Size(77, 14);
            gamePathLinkLabel.TabIndex = 7;
            gamePathLinkLabel.TabStop = true;
            gamePathLinkLabel.Text = "Game Path:";
            gamePathLinkLabel.LinkClicked += gamePathLinkLabel_LinkClicked;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { installLoaderToolStripButton, versionToolStripLabel, toolStripSeparator1, saveToolStripButton, settingsToolStripButton, checkForLoaderUpdatesToolStripButton, aboutToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // installLoaderToolStripButton
            // 
            installLoaderToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            installLoaderToolStripButton.Image = (Image)resources.GetObject("installLoaderToolStripButton.Image");
            installLoaderToolStripButton.ImageTransparentColor = Color.Magenta;
            installLoaderToolStripButton.Name = "installLoaderToolStripButton";
            installLoaderToolStripButton.Size = new Size(81, 22);
            installLoaderToolStripButton.Text = "Install Loader";
            installLoaderToolStripButton.Click += installLoaderToolStripButton_Click;
            // 
            // versionToolStripLabel
            // 
            versionToolStripLabel.Alignment = ToolStripItemAlignment.Right;
            versionToolStripLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versionToolStripLabel.Name = "versionToolStripLabel";
            versionToolStripLabel.Size = new Size(77, 22);
            versionToolStripLabel.Text = "GUI v0.0.1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(35, 22);
            saveToolStripButton.Text = "Save";
            saveToolStripButton.Click += saveToolStripButton_Click;
            // 
            // settingsToolStripButton
            // 
            settingsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            settingsToolStripButton.Image = (Image)resources.GetObject("settingsToolStripButton.Image");
            settingsToolStripButton.ImageTransparentColor = Color.Magenta;
            settingsToolStripButton.Name = "settingsToolStripButton";
            settingsToolStripButton.Size = new Size(53, 22);
            settingsToolStripButton.Text = "Settings";
            settingsToolStripButton.Click += settingsToolStripButton_Click;
            // 
            // checkForLoaderUpdatesToolStripButton
            // 
            checkForLoaderUpdatesToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            checkForLoaderUpdatesToolStripButton.Image = (Image)resources.GetObject("checkForLoaderUpdatesToolStripButton.Image");
            checkForLoaderUpdatesToolStripButton.ImageTransparentColor = Color.Magenta;
            checkForLoaderUpdatesToolStripButton.Name = "checkForLoaderUpdatesToolStripButton";
            checkForLoaderUpdatesToolStripButton.Size = new Size(149, 22);
            checkForLoaderUpdatesToolStripButton.Text = "Check For Loader Updates";
            checkForLoaderUpdatesToolStripButton.Click += checkForLoaderUpdatesToolStripButton_Click;
            // 
            // aboutToolStripButton
            // 
            aboutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            aboutToolStripButton.Image = (Image)resources.GetObject("aboutToolStripButton.Image");
            aboutToolStripButton.ImageTransparentColor = Color.Magenta;
            aboutToolStripButton.Name = "aboutToolStripButton";
            aboutToolStripButton.Size = new Size(44, 22);
            aboutToolStripButton.Text = "About";
            aboutToolStripButton.Click += aboutToolStripButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(toolStrip1);
            Controls.Add(launchGH3Button);
            Controls.Add(gamePathLinkLabel);
            Controls.Add(savePathLinkLabel);
            Controls.Add(panel1);
            Controls.Add(modCheckedListBox);
            Name = "MainForm";
            Text = "Guitar Hero 3 - Mod Loader GUI - By Vultumast";
            Load += MainForm_Load;
            pluginContextMenuStrip.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox modCheckedListBox;
        private Button launchGH3Button;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private LinkLabel savePathLinkLabel;
        private LinkLabel gamePathLinkLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton installLoaderToolStripButton;
        private ToolStripLabel versionToolStripLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton settingsToolStripButton;
        private ToolStripButton aboutToolStripButton;
        private Label label3;
        private ContextMenuStrip pluginContextMenuStrip;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem moveModUpToolStripMenuItem;
        private ToolStripMenuItem moveModDownToolStripMenuItem;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton checkForLoaderUpdatesToolStripButton;
    }
}

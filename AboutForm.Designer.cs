namespace GH3MLGUI
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
            discordLinkLabel = new LinkLabel();
            versionLabel = new Label();
            twitterLinkLabel = new LinkLabel();
            kofiLinkLabel = new LinkLabel();
            panHandleLabel = new Label();
            needHelpLabel = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            gh3mlGithubLinkLabel = new LinkLabel();
            gh3mlGUILinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // discordLinkLabel
            // 
            discordLinkLabel.AutoSize = true;
            discordLinkLabel.Location = new Point(86, 39);
            discordLinkLabel.Name = "discordLinkLabel";
            discordLinkLabel.Size = new Size(47, 15);
            discordLinkLabel.TabIndex = 0;
            discordLinkLabel.TabStop = true;
            discordLinkLabel.Tag = "https://discord.gg/gEszrxW5PS";
            discordLinkLabel.Text = "Discord";
            discordLinkLabel.LinkClicked += LinkLabel_LinkClicked;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(12, 24);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(48, 15);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "Version:";
            // 
            // twitterLinkLabel
            // 
            twitterLinkLabel.AutoSize = true;
            twitterLinkLabel.Location = new Point(100, 69);
            twitterLinkLabel.Name = "twitterLinkLabel";
            twitterLinkLabel.Size = new Size(43, 15);
            twitterLinkLabel.TabIndex = 3;
            twitterLinkLabel.TabStop = true;
            twitterLinkLabel.Tag = "https://x.com/vultumast";
            twitterLinkLabel.Text = "Twitter";
            // 
            // kofiLinkLabel
            // 
            kofiLinkLabel.AutoSize = true;
            kofiLinkLabel.Location = new Point(61, 69);
            kofiLinkLabel.Name = "kofiLinkLabel";
            kofiLinkLabel.Size = new Size(33, 15);
            kofiLinkLabel.TabIndex = 4;
            kofiLinkLabel.TabStop = true;
            kofiLinkLabel.Tag = "https://ko-fi.com/vultumast";
            kofiLinkLabel.Text = "Ko-fi";
            // 
            // panHandleLabel
            // 
            panHandleLabel.AutoSize = true;
            panHandleLabel.Location = new Point(12, 54);
            panHandleLabel.Name = "panHandleLabel";
            panHandleLabel.Size = new Size(367, 15);
            panHandleLabel.TabIndex = 5;
            panHandleLabel.Text = "If you like this or anything I've made, please consder the links below!";
            // 
            // needHelpLabel
            // 
            needHelpLabel.AutoSize = true;
            needHelpLabel.Location = new Point(12, 39);
            needHelpLabel.Name = "needHelpLabel";
            needHelpLabel.Size = new Size(68, 15);
            needHelpLabel.TabIndex = 6;
            needHelpLabel.Text = "Need Help?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 69);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Tag = "https://github.com/Vultumast";
            linkLabel1.Text = "Github";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 15);
            label1.TabIndex = 8;
            label1.Text = "GH3 ML and GH3 ML GUI are created by Vultumast";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(149, 69);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(47, 15);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Tag = "https://bsky.app/profile/vultumast.dev";
            linkLabel2.Text = "Bluesky";
            // 
            // gh3mlGithubLinkLabel
            // 
            gh3mlGithubLinkLabel.AutoSize = true;
            gh3mlGithubLinkLabel.Location = new Point(139, 39);
            gh3mlGithubLinkLabel.Name = "gh3mlGithubLinkLabel";
            gh3mlGithubLinkLabel.Size = new Size(86, 15);
            gh3mlGithubLinkLabel.TabIndex = 10;
            gh3mlGithubLinkLabel.TabStop = true;
            gh3mlGithubLinkLabel.Tag = "https://github.com/Vultumast/gh3ml";
            gh3mlGithubLinkLabel.Text = "GH3ML Github";
            // 
            // gh3mlGUILinkLabel
            // 
            gh3mlGUILinkLabel.AutoSize = true;
            gh3mlGUILinkLabel.Location = new Point(231, 39);
            gh3mlGUILinkLabel.Name = "gh3mlGUILinkLabel";
            gh3mlGUILinkLabel.Size = new Size(105, 15);
            gh3mlGUILinkLabel.TabIndex = 11;
            gh3mlGUILinkLabel.TabStop = true;
            gh3mlGUILinkLabel.Tag = "https://github.com/Vultumast/GH3MLGUI";
            gh3mlGUILinkLabel.Text = "GH3MLGUI Github";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 94);
            Controls.Add(gh3mlGUILinkLabel);
            Controls.Add(gh3mlGithubLinkLabel);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(needHelpLabel);
            Controls.Add(panHandleLabel);
            Controls.Add(kofiLinkLabel);
            Controls.Add(twitterLinkLabel);
            Controls.Add(discordLinkLabel);
            Controls.Add(versionLabel);
            Name = "AboutForm";
            Text = "About GH3 Mod Loader GUI";
            Load += AboutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel discordLinkLabel;
        private Label versionLabel;
        private LinkLabel twitterLinkLabel;
        private LinkLabel kofiLinkLabel;
        private Label panHandleLabel;
        private Label needHelpLabel;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel gh3mlGithubLinkLabel;
        private LinkLabel gh3mlGUILinkLabel;
    }
}
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
            kofiLinkLabel = new LinkLabel();
            panHandleLabel = new Label();
            needHelpLabel = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            gh3mlGithubLinkLabel = new LinkLabel();
            gh3mlGUILinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // discordLinkLabel
            // 
            discordLinkLabel.AutoSize = true;
            discordLinkLabel.Location = new Point(86, 42);
            discordLinkLabel.Name = "discordLinkLabel";
            discordLinkLabel.Size = new Size(47, 16);
            discordLinkLabel.TabIndex = 0;
            discordLinkLabel.TabStop = true;
            discordLinkLabel.Tag = "https://discord.gg/gEszrxW5PS";
            discordLinkLabel.Text = "Discord";
            discordLinkLabel.LinkClicked += LinkLabel_LinkClicked;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(12, 26);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(48, 16);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "Version:";
            // 
            // kofiLinkLabel
            // 
            kofiLinkLabel.AutoSize = true;
            kofiLinkLabel.Location = new Point(61, 74);
            kofiLinkLabel.Name = "kofiLinkLabel";
            kofiLinkLabel.Size = new Size(33, 16);
            kofiLinkLabel.TabIndex = 4;
            kofiLinkLabel.TabStop = true;
            kofiLinkLabel.Tag = "https://ko-fi.com/vultumast";
            kofiLinkLabel.Text = "Ko-fi";
            // 
            // panHandleLabel
            // 
            panHandleLabel.AutoSize = true;
            panHandleLabel.Location = new Point(12, 58);
            panHandleLabel.Name = "panHandleLabel";
            panHandleLabel.Size = new Size(366, 16);
            panHandleLabel.TabIndex = 5;
            panHandleLabel.Text = "If you like this or anything I've made, please consder the links below!";
            // 
            // needHelpLabel
            // 
            needHelpLabel.AutoSize = true;
            needHelpLabel.Location = new Point(12, 42);
            needHelpLabel.Name = "needHelpLabel";
            needHelpLabel.Size = new Size(68, 16);
            needHelpLabel.TabIndex = 6;
            needHelpLabel.Text = "Need Help?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 74);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 16);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Tag = "https://github.com/Vultumast";
            linkLabel1.Text = "Github";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(249, 16);
            label1.TabIndex = 8;
            label1.Text = "Nylon and NylonGUI are created by Vultumast";
            // 
            // gh3mlGithubLinkLabel
            // 
            gh3mlGithubLinkLabel.AutoSize = true;
            gh3mlGithubLinkLabel.Location = new Point(139, 42);
            gh3mlGithubLinkLabel.Name = "gh3mlGithubLinkLabel";
            gh3mlGithubLinkLabel.Size = new Size(78, 16);
            gh3mlGithubLinkLabel.TabIndex = 10;
            gh3mlGithubLinkLabel.TabStop = true;
            gh3mlGithubLinkLabel.Tag = "https://github.com/nsneverhax/nylon";
            gh3mlGithubLinkLabel.Text = "Nylon Github";
            // 
            // gh3mlGUILinkLabel
            // 
            gh3mlGUILinkLabel.AutoSize = true;
            gh3mlGUILinkLabel.Location = new Point(223, 42);
            gh3mlGUILinkLabel.Name = "gh3mlGUILinkLabel";
            gh3mlGUILinkLabel.Size = new Size(97, 16);
            gh3mlGUILinkLabel.TabIndex = 11;
            gh3mlGUILinkLabel.TabStop = true;
            gh3mlGUILinkLabel.Tag = "https://github.com/nsneverhax/NylonGUI";
            gh3mlGUILinkLabel.Text = "NylonGUI Github";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 100);
            Controls.Add(gh3mlGUILinkLabel);
            Controls.Add(gh3mlGithubLinkLabel);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(needHelpLabel);
            Controls.Add(panHandleLabel);
            Controls.Add(kofiLinkLabel);
            Controls.Add(discordLinkLabel);
            Controls.Add(versionLabel);
            Name = "AboutForm";
            Text = "About Nylon & Nylon GUI";
            Load += AboutForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel discordLinkLabel;
        private Label versionLabel;
        private LinkLabel kofiLinkLabel;
        private Label panHandleLabel;
        private Label needHelpLabel;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel gh3mlGithubLinkLabel;
        private LinkLabel gh3mlGUILinkLabel;
    }
}
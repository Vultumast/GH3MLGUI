namespace GH3MLGUI.Forms
{
    partial class ModInfoForm
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
            displayNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            versionTextBox = new TextBox();
            label3 = new Label();
            tagsCheckedListBox = new CheckedListBox();
            descriptionTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            authorTextBox = new TextBox();
            okayButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // displayNameTextBox
            // 
            displayNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            displayNameTextBox.Location = new Point(100, 12);
            displayNameTextBox.Name = "displayNameTextBox";
            displayNameTextBox.Size = new Size(297, 23);
            displayNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 1;
            label1.Text = "Display Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 3;
            label2.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(100, 41);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(297, 23);
            nameTextBox.TabIndex = 2;
            // 
            // versionTextBox
            // 
            versionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            versionTextBox.Location = new Point(100, 70);
            versionTextBox.Name = "versionTextBox";
            versionTextBox.Size = new Size(297, 23);
            versionTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 5;
            label3.Text = "Version:";
            // 
            // tagsCheckedListBox
            // 
            tagsCheckedListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tagsCheckedListBox.FormattingEnabled = true;
            tagsCheckedListBox.IntegralHeight = false;
            tagsCheckedListBox.Location = new Point(12, 273);
            tagsCheckedListBox.Name = "tagsCheckedListBox";
            tagsCheckedListBox.Size = new Size(385, 135);
            tagsCheckedListBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(12, 144);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(385, 107);
            descriptionTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(33, 16);
            label5.TabIndex = 9;
            label5.Text = "Tags:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 102);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 11;
            label6.Text = "Author:";
            // 
            // authorTextBox
            // 
            authorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            authorTextBox.Location = new Point(100, 99);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(297, 23);
            authorTextBox.TabIndex = 10;
            // 
            // okayButton
            // 
            okayButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            okayButton.Location = new Point(12, 414);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(75, 23);
            okayButton.TabIndex = 12;
            okayButton.Text = "Okay";
            okayButton.UseVisualStyleBackColor = true;
            okayButton.Click += okayButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(322, 414);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ModInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 449);
            Controls.Add(cancelButton);
            Controls.Add(okayButton);
            Controls.Add(label6);
            Controls.Add(authorTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(descriptionTextBox);
            Controls.Add(tagsCheckedListBox);
            Controls.Add(label3);
            Controls.Add(versionTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(displayNameTextBox);
            Name = "ModInfoForm";
            Text = "ModInfoForm";
            Load += ModInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox versionTextBox;
        private Label label3;
        private CheckedListBox tagsCheckedListBox;
        private TextBox descriptionTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox authorTextBox;
        private Button okayButton;
        private Button cancelButton;
    }
}
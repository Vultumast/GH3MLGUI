namespace GH3MLGUI
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cancelButton = new Button();
            applyButton = new Button();
            consoleLogGroupBox = new GroupBox();
            allowQScriptCheckBox = new CheckBox();
            modLogComboBox = new ComboBox();
            modLogLevelLabel = new Label();
            openGH3ConsoleCheckBox = new CheckBox();
            sharedToolTip = new ToolTip(components);
            windowStyleComboBox = new ComboBox();
            windowDisplayGroupBox = new GroupBox();
            label2 = new Label();
            panel1.SuspendLayout();
            consoleLogGroupBox.SuspendLayout();
            windowDisplayGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(applyButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 29);
            panel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.Location = new Point(257, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(3, 3);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 1;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // consoleLogGroupBox
            // 
            consoleLogGroupBox.Controls.Add(allowQScriptCheckBox);
            consoleLogGroupBox.Controls.Add(modLogComboBox);
            consoleLogGroupBox.Controls.Add(modLogLevelLabel);
            consoleLogGroupBox.Controls.Add(openGH3ConsoleCheckBox);
            consoleLogGroupBox.Location = new Point(12, 12);
            consoleLogGroupBox.Name = "consoleLogGroupBox";
            consoleLogGroupBox.Size = new Size(271, 113);
            consoleLogGroupBox.TabIndex = 2;
            consoleLogGroupBox.TabStop = false;
            consoleLogGroupBox.Text = "Console/Log";
            // 
            // allowQScriptCheckBox
            // 
            allowQScriptCheckBox.AutoSize = true;
            allowQScriptCheckBox.Checked = true;
            allowQScriptCheckBox.CheckState = CheckState.Checked;
            allowQScriptCheckBox.Location = new Point(6, 47);
            allowQScriptCheckBox.Name = "allowQScriptCheckBox";
            allowQScriptCheckBox.Size = new Size(138, 19);
            allowQScriptCheckBox.TabIndex = 4;
            allowQScriptCheckBox.Text = "Enable Q Script Printf";
            sharedToolTip.SetToolTip(allowQScriptCheckBox, "Do you want to allow Q Script files to print to the console?");
            allowQScriptCheckBox.UseVisualStyleBackColor = true;
            // 
            // modLogComboBox
            // 
            modLogComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modLogComboBox.FormattingEnabled = true;
            modLogComboBox.Items.AddRange(new object[] { "None", "Trace", "Debug", "Info", "Warn", "Error" });
            modLogComboBox.Location = new Point(109, 77);
            modLogComboBox.Name = "modLogComboBox";
            modLogComboBox.Size = new Size(121, 23);
            modLogComboBox.TabIndex = 3;
            sharedToolTip.SetToolTip(modLogComboBox, "The log level that mods will use");
            // 
            // modLogLevelLabel
            // 
            modLogLevelLabel.AutoSize = true;
            modLogLevelLabel.Location = new Point(6, 80);
            modLogLevelLabel.Name = "modLogLevelLabel";
            modLogLevelLabel.Size = new Size(97, 15);
            modLogLevelLabel.TabIndex = 3;
            modLogLevelLabel.Text = "Plugin Log Level:";
            // 
            // openGH3ConsoleCheckBox
            // 
            openGH3ConsoleCheckBox.AutoSize = true;
            openGH3ConsoleCheckBox.Checked = true;
            openGH3ConsoleCheckBox.CheckState = CheckState.Checked;
            openGH3ConsoleCheckBox.Location = new Point(6, 22);
            openGH3ConsoleCheckBox.Name = "openGH3ConsoleCheckBox";
            openGH3ConsoleCheckBox.Size = new Size(155, 19);
            openGH3ConsoleCheckBox.TabIndex = 3;
            openGH3ConsoleCheckBox.Text = "Open Console With GH3";
            sharedToolTip.SetToolTip(openGH3ConsoleCheckBox, "Do you want a Console window to open with GH3?");
            openGH3ConsoleCheckBox.UseVisualStyleBackColor = true;
            openGH3ConsoleCheckBox.CheckedChanged += openGH3ConsoleCheckBox_CheckedChanged;
            // 
            // windowStyleComboBox
            // 
            windowStyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            windowStyleComboBox.FormattingEnabled = true;
            windowStyleComboBox.Items.AddRange(new object[] { "Fullscreen", "Windowed", "Borderless Windowed", "Borderless Fullscreen" });
            windowStyleComboBox.Location = new Point(94, 22);
            windowStyleComboBox.Name = "windowStyleComboBox";
            windowStyleComboBox.Size = new Size(121, 23);
            windowStyleComboBox.TabIndex = 4;
            sharedToolTip.SetToolTip(windowStyleComboBox, "The window style that will be used");
            // 
            // windowDisplayGroupBox
            // 
            windowDisplayGroupBox.Controls.Add(label2);
            windowDisplayGroupBox.Controls.Add(windowStyleComboBox);
            windowDisplayGroupBox.Location = new Point(18, 131);
            windowDisplayGroupBox.Name = "windowDisplayGroupBox";
            windowDisplayGroupBox.Size = new Size(265, 84);
            windowDisplayGroupBox.TabIndex = 3;
            windowDisplayGroupBox.TabStop = false;
            windowDisplayGroupBox.Text = "Window/Display Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Window Style:";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(335, 263);
            Controls.Add(windowDisplayGroupBox);
            Controls.Add(consoleLogGroupBox);
            Controls.Add(panel1);
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            panel1.ResumeLayout(false);
            consoleLogGroupBox.ResumeLayout(false);
            consoleLogGroupBox.PerformLayout();
            windowDisplayGroupBox.ResumeLayout(false);
            windowDisplayGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button applyButton;
        private Button cancelButton;
        private GroupBox consoleLogGroupBox;
        private ComboBox modLogComboBox;
        private CheckBox allowQScriptCheckBox;
        private ToolTip sharedToolTip;
        private Label modLogLevelLabel;
        private CheckBox openGH3ConsoleCheckBox;
        private GroupBox windowDisplayGroupBox;
        private ComboBox windowStyleComboBox;
        private Label label2;
    }
}
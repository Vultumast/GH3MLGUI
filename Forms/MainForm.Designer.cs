namespace GH3MLGUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            modsListView = new System.Windows.Forms.ListView();
            nameColumHeader = new System.Windows.Forms.ColumnHeader();
            authorColumnHeader = new System.Windows.Forms.ColumnHeader();
            versionColumnHeader = new System.Windows.Forms.ColumnHeader();
            tagsColumnHeader = new System.Windows.Forms.ColumnHeader();
            descriptionTextBox = new System.Windows.Forms.TextBox();
            descriptionGroupBox = new System.Windows.Forms.GroupBox();
            mainTabControl = new System.Windows.Forms.TabControl();
            modsTabPage = new System.Windows.Forms.TabPage();
            editButton = new System.Windows.Forms.Button();
            refreshModListButton = new System.Windows.Forms.Button();
            moveModToBottomButton = new System.Windows.Forms.Button();
            moveModDownButton = new System.Windows.Forms.Button();
            removeModButton = new System.Windows.Forms.Button();
            addModButton = new System.Windows.Forms.Button();
            moveModUpButton = new System.Windows.Forms.Button();
            moveModToTopButton = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            tabPage1 = new System.Windows.Forms.TabPage();
            label6 = new System.Windows.Forms.Label();
            logLevelComboBox = new System.Windows.Forms.ComboBox();
            openConsoleCheckBox = new System.Windows.Forms.CheckBox();
            allowQScriptPrintfCheckBox = new System.Windows.Forms.CheckBox();
            updatedNoteTypesCheckBox = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            checkBox4 = new System.Windows.Forms.CheckBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            windowStyleComboBox = new System.Windows.Forms.ComboBox();
            windowResolutionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            resizableCheckBox = new System.Windows.Forms.CheckBox();
            windowResolutionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            vsyncCheckBox = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            commonToolTip = new System.Windows.Forms.ToolTip(components);
            saveButton = new System.Windows.Forms.Button();
            launchButton = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            checkForUpdatesToolStripButton = new System.Windows.Forms.ToolStripButton();
            infoTextToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            descriptionGroupBox.SuspendLayout();
            mainTabControl.SuspendLayout();
            modsTabPage.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)windowResolutionXNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowResolutionYNumericUpDown).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // modsListView
            // 
            modsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            modsListView.CheckBoxes = true;
            modsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { nameColumHeader, authorColumnHeader, versionColumnHeader, tagsColumnHeader });
            modsListView.FullRowSelect = true;
            modsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            modsListView.Location = new System.Drawing.Point(6, 3);
            modsListView.MultiSelect = false;
            modsListView.Name = "modsListView";
            modsListView.ShowItemToolTips = true;
            modsListView.Size = new System.Drawing.Size(489, 248);
            modsListView.TabIndex = 0;
            modsListView.UseCompatibleStateImageBehavior = false;
            modsListView.View = System.Windows.Forms.View.Details;
            modsListView.ItemChecked += modsListView_ItemChecked;
            modsListView.SelectedIndexChanged += modsListView_SelectedIndexChanged;
            // 
            // nameColumHeader
            // 
            nameColumHeader.Name = "nameColumHeader";
            nameColumHeader.Text = "Name";
            nameColumHeader.Width = 100;
            // 
            // authorColumnHeader
            // 
            authorColumnHeader.Name = "authorColumnHeader";
            authorColumnHeader.Text = "Author";
            authorColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            authorColumnHeader.Width = 100;
            // 
            // versionColumnHeader
            // 
            versionColumnHeader.Name = "versionColumnHeader";
            versionColumnHeader.Text = "Version";
            versionColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            versionColumnHeader.Width = 100;
            // 
            // tagsColumnHeader
            // 
            tagsColumnHeader.Name = "tagsColumnHeader";
            tagsColumnHeader.Text = "Tags";
            tagsColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tagsColumnHeader.Width = 100;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            descriptionTextBox.Location = new System.Drawing.Point(3, 19);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new System.Drawing.Size(513, 78);
            descriptionTextBox.TabIndex = 1;
            // 
            // descriptionGroupBox
            // 
            descriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            descriptionGroupBox.Controls.Add(descriptionTextBox);
            descriptionGroupBox.Location = new System.Drawing.Point(6, 257);
            descriptionGroupBox.Name = "descriptionGroupBox";
            descriptionGroupBox.Size = new System.Drawing.Size(519, 100);
            descriptionGroupBox.TabIndex = 2;
            descriptionGroupBox.TabStop = false;
            descriptionGroupBox.Text = "Description";
            // 
            // mainTabControl
            // 
            mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            mainTabControl.Controls.Add(modsTabPage);
            mainTabControl.Controls.Add(tabPage2);
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Location = new System.Drawing.Point(12, 28);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new System.Drawing.Size(539, 392);
            mainTabControl.TabIndex = 4;
            // 
            // modsTabPage
            // 
            modsTabPage.Controls.Add(editButton);
            modsTabPage.Controls.Add(refreshModListButton);
            modsTabPage.Controls.Add(moveModToBottomButton);
            modsTabPage.Controls.Add(moveModDownButton);
            modsTabPage.Controls.Add(removeModButton);
            modsTabPage.Controls.Add(addModButton);
            modsTabPage.Controls.Add(modsListView);
            modsTabPage.Controls.Add(moveModUpButton);
            modsTabPage.Controls.Add(descriptionGroupBox);
            modsTabPage.Controls.Add(moveModToTopButton);
            modsTabPage.Location = new System.Drawing.Point(4, 25);
            modsTabPage.Name = "modsTabPage";
            modsTabPage.Padding = new System.Windows.Forms.Padding(3);
            modsTabPage.Size = new System.Drawing.Size(531, 363);
            modsTabPage.TabIndex = 0;
            modsTabPage.Text = "Mods";
            modsTabPage.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            editButton.Enabled = false;
            editButton.Image = global::GH3MLGUI.Properties.Resources.EditInput_16x;
            editButton.Location = new System.Drawing.Point(501, 167);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(24, 24);
            editButton.TabIndex = 10;
            commonToolTip.SetToolTip(editButton, "Edit Mod Info");
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // refreshModListButton
            // 
            refreshModListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            refreshModListButton.Image = global::GH3MLGUI.Properties.Resources.Refresh_16x;
            refreshModListButton.Location = new System.Drawing.Point(501, 6);
            refreshModListButton.Name = "refreshModListButton";
            refreshModListButton.Size = new System.Drawing.Size(24, 24);
            refreshModListButton.TabIndex = 8;
            commonToolTip.SetToolTip(refreshModListButton, "Refresh the current Mod List");
            refreshModListButton.UseVisualStyleBackColor = true;
            refreshModListButton.Click += refreshModListButton_Click;
            // 
            // moveModToBottomButton
            // 
            moveModToBottomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            moveModToBottomButton.Image = global::GH3MLGUI.Properties.Resources.MoveToBottom_16x;
            moveModToBottomButton.Location = new System.Drawing.Point(501, 126);
            moveModToBottomButton.Name = "moveModToBottomButton";
            moveModToBottomButton.Size = new System.Drawing.Size(24, 24);
            moveModToBottomButton.TabIndex = 9;
            commonToolTip.SetToolTip(moveModToBottomButton, "Move the selected mod to the bottom");
            moveModToBottomButton.UseVisualStyleBackColor = true;
            moveModToBottomButton.Click += moveModToBottomButton_Click;
            // 
            // moveModDownButton
            // 
            moveModDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            moveModDownButton.Image = global::GH3MLGUI.Properties.Resources.MoveDown_16x;
            moveModDownButton.Location = new System.Drawing.Point(501, 96);
            moveModDownButton.Name = "moveModDownButton";
            moveModDownButton.Size = new System.Drawing.Size(24, 24);
            moveModDownButton.TabIndex = 8;
            commonToolTip.SetToolTip(moveModDownButton, "Move the selected mod down");
            moveModDownButton.UseVisualStyleBackColor = true;
            moveModDownButton.Click += moveModDownButton_Click;
            // 
            // removeModButton
            // 
            removeModButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            removeModButton.Image = global::GH3MLGUI.Properties.Resources.Remove_16x;
            removeModButton.Location = new System.Drawing.Point(501, 227);
            removeModButton.Name = "removeModButton";
            removeModButton.Size = new System.Drawing.Size(24, 24);
            removeModButton.TabIndex = 7;
            commonToolTip.SetToolTip(removeModButton, "Remove the selected mod");
            removeModButton.UseVisualStyleBackColor = true;
            removeModButton.Click += removeModButton_Click;
            // 
            // addModButton
            // 
            addModButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            addModButton.Image = global::GH3MLGUI.Properties.Resources.Add_16x;
            addModButton.Location = new System.Drawing.Point(501, 197);
            addModButton.Name = "addModButton";
            addModButton.Size = new System.Drawing.Size(24, 24);
            addModButton.TabIndex = 7;
            commonToolTip.SetToolTip(addModButton, "Add a new mod");
            addModButton.UseVisualStyleBackColor = true;
            addModButton.Click += addModButton_Click;
            // 
            // moveModUpButton
            // 
            moveModUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            moveModUpButton.Image = global::GH3MLGUI.Properties.Resources.MoveUp_16x;
            moveModUpButton.Location = new System.Drawing.Point(501, 66);
            moveModUpButton.Name = "moveModUpButton";
            moveModUpButton.Size = new System.Drawing.Size(24, 24);
            moveModUpButton.TabIndex = 6;
            commonToolTip.SetToolTip(moveModUpButton, "Move the selected mod up");
            moveModUpButton.UseVisualStyleBackColor = true;
            moveModUpButton.Click += moveModUpButton_Click;
            // 
            // moveModToTopButton
            // 
            moveModToTopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            moveModToTopButton.Image = global::GH3MLGUI.Properties.Resources.MoveToTop_16x;
            moveModToTopButton.Location = new System.Drawing.Point(501, 36);
            moveModToTopButton.Name = "moveModToTopButton";
            moveModToTopButton.Size = new System.Drawing.Size(24, 24);
            moveModToTopButton.TabIndex = 5;
            commonToolTip.SetToolTip(moveModToTopButton, "Move the selected mod to the top");
            moveModToTopButton.UseVisualStyleBackColor = true;
            moveModToTopButton.Click += moveModToTopButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel2);
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Location = new System.Drawing.Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(531, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mod Loader";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(29, 122);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(60, 16);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "linkLabel2";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(6, 74);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(59, 16);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(logLevelComboBox);
            tabPage1.Controls.Add(openConsoleCheckBox);
            tabPage1.Controls.Add(allowQScriptPrintfCheckBox);
            tabPage1.Controls.Add(updatedNoteTypesCheckBox);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(531, 363);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Game Options";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(142, 220);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 16);
            label6.TabIndex = 14;
            label6.Text = "Log Level:";
            // 
            // logLevelComboBox
            // 
            logLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            logLevelComboBox.FormattingEnabled = true;
            logLevelComboBox.Items.AddRange(new object[] { "None", "Trace", "Debug", "Info", "Warn", "Error" });
            logLevelComboBox.Location = new System.Drawing.Point(232, 215);
            logLevelComboBox.Name = "logLevelComboBox";
            logLevelComboBox.Size = new System.Drawing.Size(170, 24);
            logLevelComboBox.TabIndex = 13;
            // 
            // openConsoleCheckBox
            // 
            openConsoleCheckBox.AutoSize = true;
            openConsoleCheckBox.Location = new System.Drawing.Point(25, 219);
            openConsoleCheckBox.Name = "openConsoleCheckBox";
            openConsoleCheckBox.Size = new System.Drawing.Size(100, 20);
            openConsoleCheckBox.TabIndex = 12;
            openConsoleCheckBox.Text = "Open Console";
            commonToolTip.SetToolTip(openConsoleCheckBox, "Opens a console window");
            openConsoleCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowQScriptPrintfCheckBox
            // 
            allowQScriptPrintfCheckBox.AutoSize = true;
            allowQScriptPrintfCheckBox.Location = new System.Drawing.Point(25, 245);
            allowQScriptPrintfCheckBox.Name = "allowQScriptPrintfCheckBox";
            allowQScriptPrintfCheckBox.Size = new System.Drawing.Size(130, 20);
            allowQScriptPrintfCheckBox.TabIndex = 11;
            allowQScriptPrintfCheckBox.Text = "Allow QScript Printf";
            commonToolTip.SetToolTip(allowQScriptPrintfCheckBox, "Allow printing of \"Printf\" in QScript");
            allowQScriptPrintfCheckBox.UseVisualStyleBackColor = true;
            // 
            // updatedNoteTypesCheckBox
            // 
            updatedNoteTypesCheckBox.AutoSize = true;
            updatedNoteTypesCheckBox.Location = new System.Drawing.Point(25, 271);
            updatedNoteTypesCheckBox.Name = "updatedNoteTypesCheckBox";
            updatedNoteTypesCheckBox.Size = new System.Drawing.Size(132, 20);
            updatedNoteTypesCheckBox.TabIndex = 10;
            updatedNoteTypesCheckBox.Text = "Updated Note Types";
            commonToolTip.SetToolTip(updatedNoteTypesCheckBox, "Adds Tap-Notes, HOPO Chords, Open Strums");
            updatedNoteTypesCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label2);
            groupBox2.Enabled = false;
            groupBox2.Location = new System.Drawing.Point(6, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(517, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "DirectX Options";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(65, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 16);
            label5.TabIndex = 11;
            label5.Text = "Not Yet Ready!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 52);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 16);
            label3.TabIndex = 2;
            label3.Text = "Framerate:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(130, 50);
            numericUpDown3.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(71, 23);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numericUpDown3.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(10, 22);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(114, 20);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Force Resolution";
            commonToolTip.SetToolTip(checkBox4, "Is the window resizable? In other words, does it have a border?");
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(130, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 800, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(71, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numericUpDown1.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(226, 21);
            numericUpDown2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(71, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numericUpDown2.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(207, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 16);
            label2.TabIndex = 4;
            label2.Text = "x";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(windowStyleComboBox);
            groupBox1.Controls.Add(windowResolutionXNumericUpDown);
            groupBox1.Controls.Add(resizableCheckBox);
            groupBox1.Controls.Add(windowResolutionYNumericUpDown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(vsyncCheckBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(517, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Window Settings";
            // 
            // windowStyleComboBox
            // 
            windowStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            windowStyleComboBox.FormattingEnabled = true;
            windowStyleComboBox.Items.AddRange(new object[] { "Fullscreen", "Windowed", "Borderless Windowed", "Borderless Fullscreen" });
            windowStyleComboBox.Location = new System.Drawing.Point(6, 22);
            windowStyleComboBox.Name = "windowStyleComboBox";
            windowStyleComboBox.Size = new System.Drawing.Size(170, 24);
            windowStyleComboBox.TabIndex = 11;
            windowStyleComboBox.SelectedIndexChanged += windowStyleComboBox_SelectedIndexChanged;
            // 
            // windowResolutionXNumericUpDown
            // 
            windowResolutionXNumericUpDown.Location = new System.Drawing.Point(78, 52);
            windowResolutionXNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            windowResolutionXNumericUpDown.Minimum = new decimal(new int[] { 800, 0, 0, 0 });
            windowResolutionXNumericUpDown.Name = "windowResolutionXNumericUpDown";
            windowResolutionXNumericUpDown.Size = new System.Drawing.Size(71, 23);
            windowResolutionXNumericUpDown.TabIndex = 11;
            windowResolutionXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            windowResolutionXNumericUpDown.Value = new decimal(new int[] { 1920, 0, 0, 0 });
            windowResolutionXNumericUpDown.ValueChanged += windowResolutionXNumericUpDown_ValueChanged;
            // 
            // resizableCheckBox
            // 
            resizableCheckBox.AutoSize = true;
            resizableCheckBox.Location = new System.Drawing.Point(425, 22);
            resizableCheckBox.Name = "resizableCheckBox";
            resizableCheckBox.Size = new System.Drawing.Size(74, 20);
            resizableCheckBox.TabIndex = 9;
            resizableCheckBox.Text = "Resizable";
            commonToolTip.SetToolTip(resizableCheckBox, "Is the window resizable? In other words, does it have a border?");
            resizableCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowResolutionYNumericUpDown
            // 
            windowResolutionYNumericUpDown.Location = new System.Drawing.Point(174, 52);
            windowResolutionYNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            windowResolutionYNumericUpDown.Minimum = new decimal(new int[] { 600, 0, 0, 0 });
            windowResolutionYNumericUpDown.Name = "windowResolutionYNumericUpDown";
            windowResolutionYNumericUpDown.Size = new System.Drawing.Size(71, 23);
            windowResolutionYNumericUpDown.TabIndex = 12;
            windowResolutionYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            windowResolutionYNumericUpDown.Value = new decimal(new int[] { 1080, 0, 0, 0 });
            windowResolutionYNumericUpDown.ValueChanged += windowResolutionYNumericUpDown_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(155, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(13, 16);
            label4.TabIndex = 13;
            label4.Text = "x";
            // 
            // vsyncCheckBox
            // 
            vsyncCheckBox.AutoSize = true;
            vsyncCheckBox.Checked = true;
            vsyncCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            vsyncCheckBox.Enabled = false;
            vsyncCheckBox.Location = new System.Drawing.Point(182, 24);
            vsyncCheckBox.Name = "vsyncCheckBox";
            vsyncCheckBox.Size = new System.Drawing.Size(63, 20);
            vsyncCheckBox.TabIndex = 8;
            vsyncCheckBox.Text = "V-Sync";
            commonToolTip.SetToolTip(vsyncCheckBox, "Enables/Disables V-Sync\r\n(EXPERIMENTAL)");
            vsyncCheckBox.UseVisualStyleBackColor = true;
            vsyncCheckBox.CheckedChanged += vsyncCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 16);
            label1.TabIndex = 1;
            label1.Text = "Resolution:";
            // 
            // saveButton
            // 
            saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            saveButton.Image = global::GH3MLGUI.Properties.Resources.Save_16x;
            saveButton.Location = new System.Drawing.Point(527, 426);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(24, 24);
            saveButton.TabIndex = 8;
            commonToolTip.SetToolTip(saveButton, "Add a new mod");
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // launchButton
            // 
            launchButton.Location = new System.Drawing.Point(12, 426);
            launchButton.Name = "launchButton";
            launchButton.Size = new System.Drawing.Size(509, 24);
            launchButton.TabIndex = 5;
            launchButton.Text = "Ready to Rock!";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += launchButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { checkForUpdatesToolStripButton, infoTextToolStripLabel, toolStripButton2 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(563, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip";
            // 
            // checkForUpdatesToolStripButton
            // 
            checkForUpdatesToolStripButton.Image = global::GH3MLGUI.Properties.Resources.StatusUpdate_16x;
            checkForUpdatesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            checkForUpdatesToolStripButton.Name = "checkForUpdatesToolStripButton";
            checkForUpdatesToolStripButton.Size = new System.Drawing.Size(125, 22);
            checkForUpdatesToolStripButton.Text = "Check For Updates";
            checkForUpdatesToolStripButton.Click += checkForUpdatesToolStripButton_Click;
            // 
            // infoTextToolStripLabel
            // 
            infoTextToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            infoTextToolStripLabel.Name = "infoTextToolStripLabel";
            infoTextToolStripLabel.Size = new System.Drawing.Size(161, 22);
            infoTextToolStripLabel.Text = "Loader: vX.X.X.x GUI: vX.X.X.x";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton2.Image"));
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(563, 461);
            Controls.Add(toolStrip1);
            Controls.Add(saveButton);
            Controls.Add(launchButton);
            Controls.Add(mainTabControl);
            Text = "Nylon Configuration Tool";
            Load += MainForm_Load;
            descriptionGroupBox.ResumeLayout(false);
            descriptionGroupBox.PerformLayout();
            mainTabControl.ResumeLayout(false);
            modsTabPage.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)windowResolutionXNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowResolutionYNumericUpDown).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView modsListView;
        private ColumnHeader nameColumHeader;
        private ColumnHeader authorColumnHeader;
        private ColumnHeader versionColumnHeader;
        private ColumnHeader tagsColumnHeader;
        private TextBox descriptionTextBox;
        private GroupBox descriptionGroupBox;
        private TabControl mainTabControl;
        private TabPage modsTabPage;
        private TabPage tabPage2;
        private ToolTip commonToolTip;
        private Button moveModToTopButton;
        private Button moveModUpButton;
        private Button moveModDownButton;
        private Button removeModButton;
        private Button addModButton;
        private Button moveModToBottomButton;
        private Button refreshModListButton;
        private Button launchButton;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox vsyncCheckBox;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private CheckBox checkBox4;
        private NumericUpDown windowResolutionXNumericUpDown;
        private NumericUpDown windowResolutionYNumericUpDown;
        private Label label4;
        private Button saveButton;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private ComboBox windowStyleComboBox;
        private CheckBox resizableCheckBox;
        private Label label5;
        private CheckBox openConsoleCheckBox;
        private CheckBox allowQScriptPrintfCheckBox;
        private CheckBox updatedNoteTypesCheckBox;
        private ComboBox logLevelComboBox;
        private Label label6;
        private ToolStrip toolStrip1;
        private ToolStripButton checkForUpdatesToolStripButton;
        private ToolStripLabel infoTextToolStripLabel;
        private Button editButton;
        private ToolStripButton toolStripButton2;
    }
}
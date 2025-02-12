namespace GH3MLGUI.Forms
{
    partial class InstallingUpdateForm
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
            conduitPictureBox = new PictureBox();
            conduitTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)conduitPictureBox).BeginInit();
            SuspendLayout();
            // 
            // conduitPictureBox
            // 
            conduitPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            conduitPictureBox.Location = new Point(12, 12);
            conduitPictureBox.Name = "conduitPictureBox";
            conduitPictureBox.Size = new Size(176, 118);
            conduitPictureBox.TabIndex = 0;
            conduitPictureBox.TabStop = false;
            // 
            // conduitTimer
            // 
            conduitTimer.Interval = 500;
            conduitTimer.Tick += conduitTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 133);
            label1.Name = "label1";
            label1.Size = new Size(128, 16);
            label1.TabIndex = 1;
            label1.Text = "Updating Please Wait...";
            // 
            // InstallingUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 155);
            Controls.Add(label1);
            Controls.Add(conduitPictureBox);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "InstallingUpdateForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Updating";
            FormClosing += InstallingUpdateForm_FormClosing;
            Load += InstallingUpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)conduitPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox conduitPictureBox;
        private System.Windows.Forms.Timer conduitTimer;
        private Label label1;
    }
}
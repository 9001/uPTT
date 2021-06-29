namespace uPTT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._key = new System.Windows.Forms.Label();
            this._pick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystemTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackCheckBox = new System.Windows.Forms.CheckBox();
            this.minimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.SystemTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PTT key:";
            // 
            // _key
            // 
            this._key.AutoSize = true;
            this._key.Location = new System.Drawing.Point(69, 9);
            this._key.Name = "_key";
            this._key.Size = new System.Drawing.Size(54, 13);
            this._key.TabIndex = 1;
            this._key.Text = "NOT SET";
            // 
            // _pick
            // 
            this._pick.Location = new System.Drawing.Point(12, 25);
            this._pick.Name = "_pick";
            this._pick.Size = new System.Drawing.Size(111, 23);
            this._pick.TabIndex = 2;
            this._pick.Text = "choose key";
            this._pick.UseVisualStyleBackColor = true;
            this._pick.Click += new System.EventHandler(this._pick_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "v1.1 by ed @ rizon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "uPTT";
            this.notifyIcon.ContextMenuStrip = this.SystemTrayContextMenu;
            this.notifyIcon.Text = "uPTT";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // SystemTrayContextMenu
            // 
            this.SystemTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.SystemTrayContextMenu.Name = "SystemTrayContextMenu";
            this.SystemTrayContextMenu.Size = new System.Drawing.Size(104, 26);
            this.SystemTrayContextMenu.Text = "uPTT";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // feedbackCheckBox
            // 
            this.feedbackCheckBox.AutoSize = true;
            this.feedbackCheckBox.Location = new System.Drawing.Point(140, 29);
            this.feedbackCheckBox.Name = "feedbackCheckBox";
            this.feedbackCheckBox.Size = new System.Drawing.Size(82, 17);
            this.feedbackCheckBox.TabIndex = 4;
            this.feedbackCheckBox.Text = "Enable SFX";
            this.feedbackCheckBox.UseVisualStyleBackColor = true;
            this.feedbackCheckBox.CheckedChanged += new System.EventHandler(this.feedbackCheckBox_CheckedChanged);
            // 
            // minimizedCheckBox
            // 
            this.minimizedCheckBox.AutoSize = true;
            this.minimizedCheckBox.Location = new System.Drawing.Point(140, 8);
            this.minimizedCheckBox.Name = "minimizedCheckBox";
            this.minimizedCheckBox.Size = new System.Drawing.Size(97, 17);
            this.minimizedCheckBox.TabIndex = 5;
            this.minimizedCheckBox.Text = "Start Minimized";
            this.minimizedCheckBox.UseVisualStyleBackColor = true;
            this.minimizedCheckBox.CheckedChanged += new System.EventHandler(this.minimizedCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 75);
            this.Controls.Add(this.minimizedCheckBox);
            this.Controls.Add(this.feedbackCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._pick);
            this.Controls.Add(this._key);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uPTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.SystemTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _key;
        private System.Windows.Forms.Button _pick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox feedbackCheckBox;
        private System.Windows.Forms.ContextMenuStrip SystemTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.CheckBox minimizedCheckBox;
    }
}


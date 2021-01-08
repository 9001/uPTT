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
            this.label1 = new System.Windows.Forms.Label();
            this._key = new System.Windows.Forms.Label();
            this._pick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "v1.0 by ed @ rizon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 73);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._pick);
            this.Controls.Add(this._key);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uPTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _key;
        private System.Windows.Forms.Button _pick;
        private System.Windows.Forms.Label label2;
    }
}


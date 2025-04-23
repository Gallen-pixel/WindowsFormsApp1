namespace WindowsFormsApp1
{
    partial class stat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stat));
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(77)))));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(43, 34);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(123, 112);
            this.Back.TabIndex = 4;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(77)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Stat_Paint);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ReadAndDisplayFilesAsync);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
    }
}
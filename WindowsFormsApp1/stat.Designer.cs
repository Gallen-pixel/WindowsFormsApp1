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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.place1Score = new System.Windows.Forms.Label();
            this.place1Name = new System.Windows.Forms.Label();
            this.place1Time = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.place1Score);
            this.flowLayoutPanel1.Controls.Add(this.place1Name);
            this.flowLayoutPanel1.Controls.Add(this.place1Time);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(774, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 630);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // place1Score
            // 
            this.place1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place1Score.ForeColor = System.Drawing.SystemColors.Control;
            this.place1Score.Location = new System.Drawing.Point(3, 3);
            this.place1Score.Margin = new System.Windows.Forms.Padding(3);
            this.place1Score.Name = "place1Score";
            this.place1Score.Padding = new System.Windows.Forms.Padding(3);
            this.place1Score.Size = new System.Drawing.Size(109, 45);
            this.place1Score.TabIndex = 0;
            this.place1Score.Text = "label1";
            // 
            // place1Name
            // 
            this.place1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place1Name.ForeColor = System.Drawing.SystemColors.Control;
            this.place1Name.Location = new System.Drawing.Point(118, 3);
            this.place1Name.Margin = new System.Windows.Forms.Padding(3);
            this.place1Name.Name = "place1Name";
            this.place1Name.Padding = new System.Windows.Forms.Padding(3);
            this.place1Name.Size = new System.Drawing.Size(109, 45);
            this.place1Name.TabIndex = 1;
            this.place1Name.Text = "label1";
            // 
            // place1Time
            // 
            this.place1Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place1Time.ForeColor = System.Drawing.SystemColors.Control;
            this.place1Time.Location = new System.Drawing.Point(233, 3);
            this.place1Time.Margin = new System.Windows.Forms.Padding(3);
            this.place1Time.Name = "place1Time";
            this.place1Time.Padding = new System.Windows.Forms.Padding(3);
            this.place1Time.Size = new System.Drawing.Size(175, 45);
            this.place1Time.TabIndex = 2;
            this.place1Time.Text = "label1";
            // 
            // stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(77)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ReadAndDisplayFilesAsync);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label place1Score;
        private System.Windows.Forms.Label place1Name;
        private System.Windows.Forms.Label place1Time;
    }
}
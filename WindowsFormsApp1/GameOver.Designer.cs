namespace WindowsFormsApp1
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.Repeat = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.playerScore = new System.Windows.Forms.Label();
            this.NameSc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Repeat
            // 
            this.Repeat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Repeat.FlatAppearance.BorderSize = 0;
            this.Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repeat.Image = ((System.Drawing.Image)(resources.GetObject("Repeat.Image")));
            this.Repeat.Location = new System.Drawing.Point(958, 686);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(178, 176);
            this.Repeat.TabIndex = 2;
            this.Repeat.UseVisualStyleBackColor = true;
            this.Repeat.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(816, 721);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(112, 107);
            this.Back.TabIndex = 3;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.ForeColor = System.Drawing.SystemColors.Control;
            this.playerScore.Location = new System.Drawing.Point(813, 673);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(0, 13);
            this.playerScore.TabIndex = 4;
            // 
            // NameSc
            // 
            this.NameSc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NameSc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameSc.DetectUrls = false;
            this.NameSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSc.ForeColor = System.Drawing.SystemColors.Menu;
            this.NameSc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.NameSc.Location = new System.Drawing.Point(862, 619);
            this.NameSc.Multiline = false;
            this.NameSc.Name = "NameSc";
            this.NameSc.Size = new System.Drawing.Size(213, 37);
            this.NameSc.TabIndex = 5;
            this.NameSc.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1090, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(77)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameSc);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Repeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pac-Man";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Score_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Repeat;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox NameSc;
    }
}
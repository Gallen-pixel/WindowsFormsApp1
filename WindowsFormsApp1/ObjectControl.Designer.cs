namespace WindowsFormsApp1
{
    partial class ObjectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).BeginInit();
            this.SuspendLayout();
            // 
            // Sprite
            // 
            this.Sprite.BackColor = System.Drawing.Color.Transparent;
            this.Sprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sprite.Location = new System.Drawing.Point(0, 0);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(48, 48);
            this.Sprite.TabIndex = 0;
            this.Sprite.TabStop = false;
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Sprite);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(48, 48);
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Sprite;
    }
}

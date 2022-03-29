namespace mycal
{
    partial class close
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
            this.close1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(375, 214);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(100, 55);
            this.close1.TabIndex = 0;
            this.close1.Text = "Close_load";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.close1);
            this.Name = "close";
            this.Text = "close";
            this.Load += new System.EventHandler(this.close_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
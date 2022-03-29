namespace mycal
{
    partial class app
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.base1 = new System.Windows.Forms.TextBox();
            this.lim1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(357, 244);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 68);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // base1
            // 
            this.base1.Location = new System.Drawing.Point(377, 107);
            this.base1.Name = "base1";
            this.base1.PasswordChar = '*';
            this.base1.Size = new System.Drawing.Size(100, 22);
            this.base1.TabIndex = 2;
            this.base1.UseSystemPasswordChar = true;
            this.base1.TextChanged += new System.EventHandler(this.base1_TextChanged);
            // 
            // lim1
            // 
            this.lim1.Location = new System.Drawing.Point(377, 155);
            this.lim1.Name = "lim1";
            this.lim1.PasswordChar = '*';
            this.lim1.Size = new System.Drawing.Size(100, 22);
            this.lim1.TabIndex = 3;
            this.lim1.UseSystemPasswordChar = true;
            this.lim1.TextChanged += new System.EventHandler(this.lim1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 494);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lim1);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb1);
            this.Name = "app";
            this.Text = "app";
            this.Load += new System.EventHandler(this.app_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox base1;
        private System.Windows.Forms.TextBox lim1;
        private System.Windows.Forms.TextBox textBox3;
    }
}
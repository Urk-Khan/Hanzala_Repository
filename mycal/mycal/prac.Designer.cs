namespace mycal
{
    partial class prac
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
            this.n1 = new System.Windows.Forms.NumericUpDown();
            this.n2 = new System.Windows.Forms.NumericUpDown();
            this.b1 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.n3 = new System.Windows.Forms.NumericUpDown();
            this.t3 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).BeginInit();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(261, 116);
            this.n1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.n1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(120, 22);
            this.n1.TabIndex = 0;
            this.n1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n1.ValueChanged += new System.EventHandler(this.n1_ValueChanged);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(261, 182);
            this.n2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(120, 22);
            this.n2.TabIndex = 1;
            this.n2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n2.ValueChanged += new System.EventHandler(this.n2_ValueChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(283, 264);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 2;
            this.b1.Text = "calculate";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // l1
            // 
            this.l1.Location = new System.Drawing.Point(226, 340);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(175, 62);
            this.l1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mycal.Properties.Resources._220px_NUML_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(521, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(64, 102);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 22);
            this.t1.TabIndex = 5;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(64, 181);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 22);
            this.t2.TabIndex = 6;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(64, 248);
            this.n3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(120, 22);
            this.n3.TabIndex = 7;
            this.n3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n3.ValueChanged += new System.EventHandler(this.n3_ValueChanged);
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(37, 350);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(173, 22);
            this.t3.TabIndex = 8;
            this.t3.TextChanged += new System.EventHandler(this.t3_TextChanged);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(79, 287);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 9;
            this.b2.Text = "calculate";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // prac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "prac";
            this.Text = "prac";
            this.Load += new System.EventHandler(this.prac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown n1;
        private System.Windows.Forms.NumericUpDown n2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.NumericUpDown n3;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Button b2;
    }
}
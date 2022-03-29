namespace mycal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.data = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zaro = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.sininv = new System.Windows.Forms.Button();
            this.taninv = new System.Windows.Forms.Button();
            this.cosinv = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.cude = new System.Windows.Forms.Button();
            this.underroot = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(153, 98);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(469, 22);
            this.data.TabIndex = 0;
            this.data.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(238, 153);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "1";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(238, 237);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(351, 153);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(699, 98);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 23);
            this.equals.TabIndex = 4;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(238, 314);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 5;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(351, 226);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(351, 380);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(468, 226);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 23);
            this.point.TabIndex = 8;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(351, 314);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 9;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(468, 153);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(75, 23);
            this.percent.TabIndex = 10;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(468, 380);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // zaro
            // 
            this.zaro.Location = new System.Drawing.Point(238, 380);
            this.zaro.Name = "zaro";
            this.zaro.Size = new System.Drawing.Size(75, 23);
            this.zaro.TabIndex = 12;
            this.zaro.Text = "0";
            this.zaro.UseVisualStyleBackColor = true;
            this.zaro.Click += new System.EventHandler(this.zaro_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(576, 153);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 13;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(576, 226);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 14;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(576, 314);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 15;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // sininv
            // 
            this.sininv.Location = new System.Drawing.Point(576, 380);
            this.sininv.Name = "sininv";
            this.sininv.Size = new System.Drawing.Size(75, 23);
            this.sininv.TabIndex = 16;
            this.sininv.Text = "sininv";
            this.sininv.UseVisualStyleBackColor = true;
            this.sininv.Click += new System.EventHandler(this.sininv_Click);
            // 
            // taninv
            // 
            this.taninv.Location = new System.Drawing.Point(699, 314);
            this.taninv.Name = "taninv";
            this.taninv.Size = new System.Drawing.Size(75, 23);
            this.taninv.TabIndex = 17;
            this.taninv.Text = "taninv";
            this.taninv.UseVisualStyleBackColor = true;
            this.taninv.Click += new System.EventHandler(this.taninv_Click);
            // 
            // cosinv
            // 
            this.cosinv.Location = new System.Drawing.Point(699, 380);
            this.cosinv.Name = "cosinv";
            this.cosinv.Size = new System.Drawing.Size(75, 23);
            this.cosinv.TabIndex = 18;
            this.cosinv.Text = "cosinv";
            this.cosinv.UseVisualStyleBackColor = true;
            this.cosinv.Click += new System.EventHandler(this.cosinv_Click);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(699, 153);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(75, 23);
            this.sqr.TabIndex = 19;
            this.sqr.Text = "sqr";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.sqr_Click);
            // 
            // cude
            // 
            this.cude.Location = new System.Drawing.Point(699, 226);
            this.cude.Name = "cude";
            this.cude.Size = new System.Drawing.Size(75, 23);
            this.cude.TabIndex = 20;
            this.cude.Text = "cube";
            this.cude.UseVisualStyleBackColor = true;
            this.cude.Click += new System.EventHandler(this.cude_Click);
            // 
            // underroot
            // 
            this.underroot.Location = new System.Drawing.Point(468, 314);
            this.underroot.Name = "underroot";
            this.underroot.Size = new System.Drawing.Size(75, 23);
            this.underroot.TabIndex = 21;
            this.underroot.Text = "underroot";
            this.underroot.UseVisualStyleBackColor = true;
            this.underroot.Click += new System.EventHandler(this.underroot_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.underroot);
            this.Controls.Add(this.cude);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.cosinv);
            this.Controls.Add(this.taninv);
            this.Controls.Add(this.sininv);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.zaro);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.point);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zaro;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button sininv;
        private System.Windows.Forms.Button taninv;
        private System.Windows.Forms.Button cosinv;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button cude;
        private System.Windows.Forms.Button underroot;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}


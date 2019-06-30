namespace AliFashion
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
            this.m1ClassName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Pshelflife = new System.Windows.Forms.TextBox();
            this.CalcualteShelfLife = new System.Windows.Forms.Button();
            this.m1SalePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m1Season = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m1ShopeCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m1GroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m1CategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PPrice = new System.Windows.Forms.TextBox();
            this.m2TypeName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.m2Groupname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m2Seasons = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m2ColorName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.m2SubClassName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m2CategoryName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.m2ClassName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DaysItemBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // m1ClassName
            // 
            this.m1ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1ClassName.Location = new System.Drawing.Point(194, 53);
            this.m1ClassName.Name = "m1ClassName";
            this.m1ClassName.Size = new System.Drawing.Size(262, 29);
            this.m1ClassName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.DaysItemBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Pshelflife);
            this.groupBox1.Controls.Add(this.CalcualteShelfLife);
            this.groupBox1.Controls.Add(this.m1SalePrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m1Season);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m1ShopeCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m1GroupName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m1CategoryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m1ClassName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 478);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shelf Life";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(92, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Estimated Shelf Life";
            // 
            // Pshelflife
            // 
            this.Pshelflife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pshelflife.Location = new System.Drawing.Point(271, 402);
            this.Pshelflife.Name = "Pshelflife";
            this.Pshelflife.ReadOnly = true;
            this.Pshelflife.Size = new System.Drawing.Size(185, 29);
            this.Pshelflife.TabIndex = 11;
            this.Pshelflife.TextChanged += new System.EventHandler(this.Pshelflife_TextChanged);
            // 
            // CalcualteShelfLife
            // 
            this.CalcualteShelfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcualteShelfLife.Location = new System.Drawing.Point(271, 333);
            this.CalcualteShelfLife.Name = "CalcualteShelfLife";
            this.CalcualteShelfLife.Size = new System.Drawing.Size(185, 57);
            this.CalcualteShelfLife.TabIndex = 7;
            this.CalcualteShelfLife.Text = "Calculate Shelf Life";
            this.CalcualteShelfLife.UseVisualStyleBackColor = true;
            this.CalcualteShelfLife.Click += new System.EventHandler(this.button1_Click);
            // 
            // m1SalePrice
            // 
            this.m1SalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1SalePrice.Location = new System.Drawing.Point(194, 287);
            this.m1SalePrice.Name = "m1SalePrice";
            this.m1SalePrice.Size = new System.Drawing.Size(262, 29);
            this.m1SalePrice.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sale Price";
            // 
            // m1Season
            // 
            this.m1Season.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1Season.Location = new System.Drawing.Point(194, 240);
            this.m1Season.Name = "m1Season";
            this.m1Season.Size = new System.Drawing.Size(262, 29);
            this.m1Season.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Season";
            // 
            // m1ShopeCode
            // 
            this.m1ShopeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1ShopeCode.Location = new System.Drawing.Point(194, 191);
            this.m1ShopeCode.Name = "m1ShopeCode";
            this.m1ShopeCode.Size = new System.Drawing.Size(262, 29);
            this.m1ShopeCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shop Code";
            // 
            // m1GroupName
            // 
            this.m1GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1GroupName.Location = new System.Drawing.Point(194, 144);
            this.m1GroupName.Name = "m1GroupName";
            this.m1GroupName.Size = new System.Drawing.Size(262, 29);
            this.m1GroupName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // m1CategoryName
            // 
            this.m1CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1CategoryName.Location = new System.Drawing.Point(194, 99);
            this.m1CategoryName.Name = "m1CategoryName";
            this.m1CategoryName.Size = new System.Drawing.Size(262, 29);
            this.m1CategoryName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.PPrice);
            this.groupBox2.Controls.Add(this.m2TypeName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.m2Groupname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.m2Seasons);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.m2ColorName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.m2SubClassName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.m2CategoryName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.m2ClassName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(573, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 478);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(125, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 24);
            this.label15.TabIndex = 18;
            this.label15.Text = "Estimated Price";
            // 
            // PPrice
            // 
            this.PPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrice.Location = new System.Drawing.Point(271, 437);
            this.PPrice.Name = "PPrice";
            this.PPrice.ReadOnly = true;
            this.PPrice.Size = new System.Drawing.Size(185, 29);
            this.PPrice.TabIndex = 17;
            // 
            // m2TypeName
            // 
            this.m2TypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2TypeName.Location = new System.Drawing.Point(194, 333);
            this.m2TypeName.Name = "m2TypeName";
            this.m2TypeName.Size = new System.Drawing.Size(262, 29);
            this.m2TypeName.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(79, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Type Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(271, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "Calculate Price";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // m2Groupname
            // 
            this.m2Groupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2Groupname.Location = new System.Drawing.Point(194, 287);
            this.m2Groupname.Name = "m2Groupname";
            this.m2Groupname.Size = new System.Drawing.Size(262, 29);
            this.m2Groupname.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Group Name";
            // 
            // m2Seasons
            // 
            this.m2Seasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2Seasons.Location = new System.Drawing.Point(194, 240);
            this.m2Seasons.Name = "m2Seasons";
            this.m2Seasons.Size = new System.Drawing.Size(262, 29);
            this.m2Seasons.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Season";
            // 
            // m2ColorName
            // 
            this.m2ColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2ColorName.Location = new System.Drawing.Point(194, 191);
            this.m2ColorName.Name = "m2ColorName";
            this.m2ColorName.Size = new System.Drawing.Size(262, 29);
            this.m2ColorName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Color Name";
            // 
            // m2SubClassName
            // 
            this.m2SubClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2SubClassName.Location = new System.Drawing.Point(194, 144);
            this.m2SubClassName.Name = "m2SubClassName";
            this.m2SubClassName.Size = new System.Drawing.Size(262, 29);
            this.m2SubClassName.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "SubClass Name";
            // 
            // m2CategoryName
            // 
            this.m2CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2CategoryName.Location = new System.Drawing.Point(194, 99);
            this.m2CategoryName.Name = "m2CategoryName";
            this.m2CategoryName.Size = new System.Drawing.Size(262, 29);
            this.m2CategoryName.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Category Name";
            // 
            // m2ClassName
            // 
            this.m2ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m2ClassName.Location = new System.Drawing.Point(194, 53);
            this.m2ClassName.Name = "m2ClassName";
            this.m2ClassName.Size = new System.Drawing.Size(262, 29);
            this.m2ClassName.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(77, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Class Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(69, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "Days To sell one item";
            // 
            // DaysItemBox
            // 
            this.DaysItemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysItemBox.Location = new System.Drawing.Point(271, 437);
            this.DaysItemBox.Name = "DaysItemBox";
            this.DaysItemBox.ReadOnly = true;
            this.DaysItemBox.Size = new System.Drawing.Size(185, 29);
            this.DaysItemBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fashion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m1ClassName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m1ShopeCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m1GroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m1CategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m1SalePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m1Season;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalcualteShelfLife;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox m2Groupname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m2Seasons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m2ColorName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m2SubClassName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox m2CategoryName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox m2ClassName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox m2TypeName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Pshelflife;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DaysItemBox;
    }
}


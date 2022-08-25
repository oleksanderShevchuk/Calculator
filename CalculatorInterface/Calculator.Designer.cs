namespace CalculatorInterface
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.SubtractionBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.MaximumSize = new System.Drawing.Size(300, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TotalBtn);
            this.panel1.Controls.Add(this.SubtractionBtn);
            this.panel1.Controls.Add(this.PlusBtn);
            this.panel1.Controls.Add(this.DotBtn);
            this.panel1.Controls.Add(this.NineBtn);
            this.panel1.Controls.Add(this.EightBtn);
            this.panel1.Controls.Add(this.SevenBtn);
            this.panel1.Controls.Add(this.SixBtn);
            this.panel1.Controls.Add(this.FiveBtn);
            this.panel1.Controls.Add(this.FourBtn);
            this.panel1.Controls.Add(this.ThreeBtn);
            this.panel1.Controls.Add(this.OneBtn);
            this.panel1.Controls.Add(this.TwoBtn);
            this.panel1.Controls.Add(this.ZeroBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 426);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.MaximumSize = new System.Drawing.Size(300, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 15;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBtn
            // 
            this.TotalBtn.Location = new System.Drawing.Point(261, 378);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(85, 44);
            this.TotalBtn.TabIndex = 14;
            this.TotalBtn.Text = "=";
            this.TotalBtn.UseVisualStyleBackColor = true;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.Location = new System.Drawing.Point(261, 288);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(85, 44);
            this.SubtractionBtn.TabIndex = 13;
            this.SubtractionBtn.Text = "-";
            this.SubtractionBtn.UseVisualStyleBackColor = true;
            this.SubtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(261, 333);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(85, 44);
            this.PlusBtn.TabIndex = 12;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // DotBtn
            // 
            this.DotBtn.Location = new System.Drawing.Point(175, 378);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(85, 44);
            this.DotBtn.TabIndex = 11;
            this.DotBtn.Text = ",";
            this.DotBtn.UseVisualStyleBackColor = true;
            this.DotBtn.Click += new System.EventHandler(this.DotBtn_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.Location = new System.Drawing.Point(175, 244);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(85, 44);
            this.NineBtn.TabIndex = 10;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.Location = new System.Drawing.Point(89, 244);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(85, 44);
            this.EightBtn.TabIndex = 9;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Location = new System.Drawing.Point(3, 244);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(85, 44);
            this.SevenBtn.TabIndex = 8;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.Location = new System.Drawing.Point(175, 288);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(85, 44);
            this.SixBtn.TabIndex = 7;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Location = new System.Drawing.Point(89, 288);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(85, 44);
            this.FiveBtn.TabIndex = 6;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.Location = new System.Drawing.Point(3, 288);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(85, 44);
            this.FourBtn.TabIndex = 5;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Location = new System.Drawing.Point(175, 333);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(85, 44);
            this.ThreeBtn.TabIndex = 4;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Location = new System.Drawing.Point(3, 333);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(85, 44);
            this.OneBtn.TabIndex = 3;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Location = new System.Drawing.Point(89, 333);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(85, 44);
            this.TwoBtn.TabIndex = 2;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Location = new System.Drawing.Point(89, 378);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(85, 44);
            this.ZeroBtn.TabIndex = 1;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(261, 244);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 44);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "C";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button SubtractionBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
    }
}


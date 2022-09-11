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
            this.FactorialBtn = new System.Windows.Forms.Button();
            this.PowerBtn = new System.Windows.Forms.Button();
            this.SqrtBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PiBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.MultiplicationBtn = new System.Windows.Forms.Button();
            this.DeleteAllBtn = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.FactorialBtn);
            this.panel1.Controls.Add(this.PowerBtn);
            this.panel1.Controls.Add(this.SqrtBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.PiBtn);
            this.panel1.Controls.Add(this.DivisionBtn);
            this.panel1.Controls.Add(this.MultiplicationBtn);
            this.panel1.Controls.Add(this.DeleteAllBtn);
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 426);
            this.panel1.TabIndex = 1;
            // 
            // FactorialBtn
            // 
            this.FactorialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FactorialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FactorialBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FactorialBtn.Location = new System.Drawing.Point(3, 200);
            this.FactorialBtn.Name = "FactorialBtn";
            this.FactorialBtn.Size = new System.Drawing.Size(85, 44);
            this.FactorialBtn.TabIndex = 23;
            this.FactorialBtn.Text = "!";
            this.FactorialBtn.UseVisualStyleBackColor = false;
            this.FactorialBtn.Click += new System.EventHandler(this.FactorialBtn_Click);
            // 
            // PowerBtn
            // 
            this.PowerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PowerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PowerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PowerBtn.Location = new System.Drawing.Point(89, 200);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(85, 44);
            this.PowerBtn.TabIndex = 22;
            this.PowerBtn.Text = "xⁿ";
            this.PowerBtn.UseVisualStyleBackColor = false;
            this.PowerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // SqrtBtn
            // 
            this.SqrtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SqrtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SqrtBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SqrtBtn.Location = new System.Drawing.Point(175, 200);
            this.SqrtBtn.Name = "SqrtBtn";
            this.SqrtBtn.Size = new System.Drawing.Size(85, 44);
            this.SqrtBtn.TabIndex = 21;
            this.SqrtBtn.Text = "√";
            this.SqrtBtn.UseVisualStyleBackColor = false;
            this.SqrtBtn.Click += new System.EventHandler(this.SqrtBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteBtn.Location = new System.Drawing.Point(261, 156);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(85, 44);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "⌫";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PiBtn
            // 
            this.PiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PiBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PiBtn.Location = new System.Drawing.Point(3, 378);
            this.PiBtn.Name = "PiBtn";
            this.PiBtn.Size = new System.Drawing.Size(85, 44);
            this.PiBtn.TabIndex = 19;
            this.PiBtn.Text = "𝝅";
            this.PiBtn.UseVisualStyleBackColor = false;
            this.PiBtn.Click += new System.EventHandler(this.PiBtn_Click);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DivisionBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DivisionBtn.Location = new System.Drawing.Point(261, 200);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(85, 44);
            this.DivisionBtn.TabIndex = 18;
            this.DivisionBtn.Text = "➗";
            this.DivisionBtn.UseVisualStyleBackColor = false;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MultiplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplicationBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MultiplicationBtn.Location = new System.Drawing.Point(261, 244);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Size = new System.Drawing.Size(85, 44);
            this.MultiplicationBtn.TabIndex = 17;
            this.MultiplicationBtn.Text = "❌";
            this.MultiplicationBtn.UseVisualStyleBackColor = false;
            this.MultiplicationBtn.Click += new System.EventHandler(this.MultiplicationBtn_Click);
            // 
            // DeleteAllBtn
            // 
            this.DeleteAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteAllBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteAllBtn.Location = new System.Drawing.Point(175, 156);
            this.DeleteAllBtn.Name = "DeleteAllBtn";
            this.DeleteAllBtn.Size = new System.Drawing.Size(85, 44);
            this.DeleteAllBtn.TabIndex = 16;
            this.DeleteAllBtn.Text = "C";
            this.DeleteAllBtn.UseVisualStyleBackColor = false;
            this.DeleteAllBtn.Click += new System.EventHandler(this.DeleteAllBtn_Click);
            this.DeleteAllBtn.MouseHover += new System.EventHandler(this.DeleteAllBtn_Click);
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
            this.TotalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TotalBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TotalBtn.Location = new System.Drawing.Point(261, 378);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(85, 44);
            this.TotalBtn.TabIndex = 14;
            this.TotalBtn.Text = "=";
            this.TotalBtn.UseVisualStyleBackColor = false;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubtractionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubtractionBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SubtractionBtn.Location = new System.Drawing.Point(261, 288);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(85, 44);
            this.SubtractionBtn.TabIndex = 13;
            this.SubtractionBtn.Text = "━";
            this.SubtractionBtn.UseVisualStyleBackColor = false;
            this.SubtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlusBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PlusBtn.Location = new System.Drawing.Point(261, 333);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(85, 44);
            this.PlusBtn.TabIndex = 12;
            this.PlusBtn.Text = "✚";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // DotBtn
            // 
            this.DotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DotBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DotBtn.Location = new System.Drawing.Point(175, 378);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(85, 44);
            this.DotBtn.TabIndex = 11;
            this.DotBtn.Text = ",";
            this.DotBtn.UseVisualStyleBackColor = false;
            this.DotBtn.Click += new System.EventHandler(this.DotBtn_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NineBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NineBtn.Location = new System.Drawing.Point(175, 244);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(85, 44);
            this.NineBtn.TabIndex = 10;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = false;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EightBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EightBtn.Location = new System.Drawing.Point(89, 244);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(85, 44);
            this.EightBtn.TabIndex = 9;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = false;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SevenBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SevenBtn.Location = new System.Drawing.Point(3, 244);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(85, 44);
            this.SevenBtn.TabIndex = 8;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = false;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SixBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SixBtn.Location = new System.Drawing.Point(175, 288);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(85, 44);
            this.SixBtn.TabIndex = 7;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = false;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiveBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FiveBtn.Location = new System.Drawing.Point(89, 288);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(85, 44);
            this.FiveBtn.TabIndex = 6;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = false;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FourBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FourBtn.Location = new System.Drawing.Point(3, 288);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(85, 44);
            this.FourBtn.TabIndex = 5;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = false;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThreeBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ThreeBtn.Location = new System.Drawing.Point(175, 333);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(85, 44);
            this.ThreeBtn.TabIndex = 4;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = false;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OneBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OneBtn.Location = new System.Drawing.Point(3, 333);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(85, 44);
            this.OneBtn.TabIndex = 3;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = false;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TwoBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TwoBtn.Location = new System.Drawing.Point(89, 333);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(85, 44);
            this.TwoBtn.TabIndex = 2;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = false;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZeroBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ZeroBtn.Location = new System.Drawing.Point(89, 378);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(85, 44);
            this.ZeroBtn.TabIndex = 1;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(355, 430);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.MouseHover += new System.EventHandler(this.DeleteAllBtn_Click);
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
        private System.Windows.Forms.Button DeleteAllBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button PiBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button MultiplicationBtn;
        private System.Windows.Forms.Button SqrtBtn;
        private System.Windows.Forms.Button PowerBtn;
        private System.Windows.Forms.Button FactorialBtn;
    }
}


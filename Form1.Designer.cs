namespace ScientificCal
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
            this.output = new System.Windows.Forms.TextBox();
            this.cBtn = new System.Windows.Forms.Button();
            this.sinBtn = new System.Windows.Forms.Button();
            this.cosBtn = new System.Windows.Forms.Button();
            this.tanBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.MulBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.ninBtn = new System.Windows.Forms.Button();
            this.sevBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.dZeroBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(22, 41);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(325, 39);
            this.output.TabIndex = 1;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.output.Click += new System.EventHandler(this.output_TextChanged);
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // cBtn
            // 
            this.cBtn.Location = new System.Drawing.Point(22, 123);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(52, 42);
            this.cBtn.TabIndex = 2;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // sinBtn
            // 
            this.sinBtn.Location = new System.Drawing.Point(202, 191);
            this.sinBtn.Name = "sinBtn";
            this.sinBtn.Size = new System.Drawing.Size(52, 45);
            this.sinBtn.TabIndex = 3;
            this.sinBtn.Text = "sin";
            this.sinBtn.UseVisualStyleBackColor = true;
            this.sinBtn.Click += new System.EventHandler(this.sinBtn_Click);
            // 
            // cosBtn
            // 
            this.cosBtn.Location = new System.Drawing.Point(109, 191);
            this.cosBtn.Name = "cosBtn";
            this.cosBtn.Size = new System.Drawing.Size(52, 45);
            this.cosBtn.TabIndex = 4;
            this.cosBtn.Text = "cos";
            this.cosBtn.UseVisualStyleBackColor = true;
            this.cosBtn.Click += new System.EventHandler(this.cosBtn_Click);
            // 
            // tanBtn
            // 
            this.tanBtn.Location = new System.Drawing.Point(22, 191);
            this.tanBtn.Name = "tanBtn";
            this.tanBtn.Size = new System.Drawing.Size(52, 45);
            this.tanBtn.TabIndex = 5;
            this.tanBtn.Text = "tan";
            this.tanBtn.UseVisualStyleBackColor = true;
            this.tanBtn.Click += new System.EventHandler(this.tanBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(298, 413);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(52, 46);
            this.divBtn.TabIndex = 6;
            this.divBtn.Text = "÷";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // MulBtn
            // 
            this.MulBtn.Location = new System.Drawing.Point(295, 348);
            this.MulBtn.Name = "MulBtn";
            this.MulBtn.Size = new System.Drawing.Size(55, 42);
            this.MulBtn.TabIndex = 7;
            this.MulBtn.Text = "x";
            this.MulBtn.UseVisualStyleBackColor = true;
            this.MulBtn.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(295, 273);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(52, 44);
            this.MinusBtn.TabIndex = 8;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(295, 487);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(52, 44);
            this.plusBtn.TabIndex = 9;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // equalBtn
            // 
            this.equalBtn.Location = new System.Drawing.Point(203, 487);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(53, 45);
            this.equalBtn.TabIndex = 10;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.Operator_Pressed);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Location = new System.Drawing.Point(22, 488);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(52, 44);
            this.zeroBtn.TabIndex = 11;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // OneBtn
            // 
            this.OneBtn.Location = new System.Drawing.Point(22, 418);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(52, 44);
            this.OneBtn.TabIndex = 12;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // twoBtn
            // 
            this.twoBtn.Location = new System.Drawing.Point(109, 418);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(52, 44);
            this.twoBtn.TabIndex = 13;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // fourBtn
            // 
            this.fourBtn.Location = new System.Drawing.Point(22, 349);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(52, 41);
            this.fourBtn.TabIndex = 14;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // sixBtn
            // 
            this.sixBtn.Location = new System.Drawing.Point(203, 348);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(52, 42);
            this.sixBtn.TabIndex = 15;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Location = new System.Drawing.Point(109, 348);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(52, 43);
            this.fiveBtn.TabIndex = 16;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // eightBtn
            // 
            this.eightBtn.Location = new System.Drawing.Point(109, 273);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(52, 45);
            this.eightBtn.TabIndex = 17;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // ninBtn
            // 
            this.ninBtn.Location = new System.Drawing.Point(202, 273);
            this.ninBtn.Name = "ninBtn";
            this.ninBtn.Size = new System.Drawing.Size(52, 45);
            this.ninBtn.TabIndex = 18;
            this.ninBtn.Text = "9";
            this.ninBtn.UseVisualStyleBackColor = true;
            this.ninBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // sevBtn
            // 
            this.sevBtn.Location = new System.Drawing.Point(22, 273);
            this.sevBtn.Name = "sevBtn";
            this.sevBtn.Size = new System.Drawing.Size(52, 45);
            this.sevBtn.TabIndex = 19;
            this.sevBtn.Text = "7";
            this.sevBtn.UseVisualStyleBackColor = true;
            this.sevBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // threeBtn
            // 
            this.threeBtn.Location = new System.Drawing.Point(202, 418);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(52, 41);
            this.threeBtn.TabIndex = 20;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(298, 191);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(52, 45);
            this.logBtn.TabIndex = 21;
            this.logBtn.Text = "log";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // dZeroBtn
            // 
            this.dZeroBtn.Location = new System.Drawing.Point(109, 487);
            this.dZeroBtn.Name = "dZeroBtn";
            this.dZeroBtn.Size = new System.Drawing.Size(52, 44);
            this.dZeroBtn.TabIndex = 22;
            this.dZeroBtn.Text = "00";
            this.dZeroBtn.UseVisualStyleBackColor = true;
            this.dZeroBtn.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 561);
            this.Controls.Add(this.dZeroBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.sevBtn);
            this.Controls.Add(this.ninBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.MulBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.tanBtn);
            this.Controls.Add(this.cosBtn);
            this.Controls.Add(this.sinBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "Scientific Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button sinBtn;
        private System.Windows.Forms.Button cosBtn;
        private System.Windows.Forms.Button tanBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button MulBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button ninBtn;
        private System.Windows.Forms.Button sevBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button dZeroBtn;
    }
}


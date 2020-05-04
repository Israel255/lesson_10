namespace lesson_10
{
    partial class calculator_frm
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
            this.num1_txtbx = new System.Windows.Forms.TextBox();
            this.num2_txtbx = new System.Windows.Forms.TextBox();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.mult_btn = new System.Windows.Forms.Button();
            this.division_btn = new System.Windows.Forms.Button();
            this.power_btn = new System.Windows.Forms.Button();
            this.squareRoot_btn = new System.Windows.Forms.Button();
            this.board_lb = new System.Windows.Forms.ListBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.randonNum_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // num1_txtbx
            // 
            this.num1_txtbx.Location = new System.Drawing.Point(67, 80);
            this.num1_txtbx.Name = "num1_txtbx";
            this.num1_txtbx.Size = new System.Drawing.Size(100, 20);
            this.num1_txtbx.TabIndex = 0;
            this.num1_txtbx.Text = "0";
            // 
            // num2_txtbx
            // 
            this.num2_txtbx.Location = new System.Drawing.Point(519, 80);
            this.num2_txtbx.Name = "num2_txtbx";
            this.num2_txtbx.Size = new System.Drawing.Size(100, 20);
            this.num2_txtbx.TabIndex = 1;
            this.num2_txtbx.Text = "0";
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(12, 184);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(75, 23);
            this.plus_btn.TabIndex = 2;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Location = new System.Drawing.Point(110, 184);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(75, 23);
            this.minus_btn.TabIndex = 3;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // mult_btn
            // 
            this.mult_btn.Location = new System.Drawing.Point(223, 184);
            this.mult_btn.Name = "mult_btn";
            this.mult_btn.Size = new System.Drawing.Size(75, 23);
            this.mult_btn.TabIndex = 4;
            this.mult_btn.Text = "*";
            this.mult_btn.UseVisualStyleBackColor = true;
            this.mult_btn.Click += new System.EventHandler(this.mult_btn_Click);
            // 
            // division_btn
            // 
            this.division_btn.Location = new System.Drawing.Point(341, 184);
            this.division_btn.Name = "division_btn";
            this.division_btn.Size = new System.Drawing.Size(75, 23);
            this.division_btn.TabIndex = 5;
            this.division_btn.Text = "/";
            this.division_btn.UseVisualStyleBackColor = true;
            this.division_btn.Click += new System.EventHandler(this.division_btn_Click);
            // 
            // power_btn
            // 
            this.power_btn.Location = new System.Drawing.Point(442, 184);
            this.power_btn.Name = "power_btn";
            this.power_btn.Size = new System.Drawing.Size(75, 23);
            this.power_btn.TabIndex = 6;
            this.power_btn.Text = "**";
            this.power_btn.UseVisualStyleBackColor = true;
            this.power_btn.Click += new System.EventHandler(this.power_btn_Click);
            // 
            // squareRoot_btn
            // 
            this.squareRoot_btn.Location = new System.Drawing.Point(544, 184);
            this.squareRoot_btn.Name = "squareRoot_btn";
            this.squareRoot_btn.Size = new System.Drawing.Size(75, 23);
            this.squareRoot_btn.TabIndex = 7;
            this.squareRoot_btn.Text = "Square root";
            this.squareRoot_btn.UseVisualStyleBackColor = true;
            this.squareRoot_btn.Click += new System.EventHandler(this.squareRoot_btn_Click);
            // 
            // board_lb
            // 
            this.board_lb.BackColor = System.Drawing.SystemColors.Window;
            this.board_lb.FormattingEnabled = true;
            this.board_lb.Location = new System.Drawing.Point(67, 230);
            this.board_lb.Name = "board_lb";
            this.board_lb.Size = new System.Drawing.Size(552, 95);
            this.board_lb.TabIndex = 8;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(282, 347);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // randonNum_btn
            // 
            this.randonNum_btn.Location = new System.Drawing.Point(460, 346);
            this.randonNum_btn.Name = "randonNum_btn";
            this.randonNum_btn.Size = new System.Drawing.Size(143, 23);
            this.randonNum_btn.TabIndex = 10;
            this.randonNum_btn.Text = "random numbers";
            this.randonNum_btn.UseVisualStyleBackColor = true;
            this.randonNum_btn.Click += new System.EventHandler(this.randonNum_btn_Click);
            // 
            // calculator_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 465);
            this.Controls.Add(this.randonNum_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.board_lb);
            this.Controls.Add(this.squareRoot_btn);
            this.Controls.Add(this.power_btn);
            this.Controls.Add(this.division_btn);
            this.Controls.Add(this.mult_btn);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.num2_txtbx);
            this.Controls.Add(this.num1_txtbx);
            this.Name = "calculator_frm";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1_txtbx;
        private System.Windows.Forms.TextBox num2_txtbx;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button mult_btn;
        private System.Windows.Forms.Button division_btn;
        private System.Windows.Forms.Button power_btn;
        private System.Windows.Forms.Button squareRoot_btn;
        private System.Windows.Forms.ListBox board_lb;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button randonNum_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


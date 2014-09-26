namespace WindowsFormsApplication1
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
            this.rawSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.giftMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rawSalary
            // 
            this.rawSalary.Location = new System.Drawing.Point(244, 40);
            this.rawSalary.Name = "rawSalary";
            this.rawSalary.Size = new System.Drawing.Size(44, 20);
            this.rawSalary.TabIndex = 0;
            this.rawSalary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть заробітну плату";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заробітня плата після оподаткування";
            // 
            // totalSalary
            // 
            this.totalSalary.AutoSize = true;
            this.totalSalary.Location = new System.Drawing.Point(254, 96);
            this.totalSalary.Name = "totalSalary";
            this.totalSalary.Size = new System.Drawing.Size(34, 13);
            this.totalSalary.TabIndex = 3;
            this.totalSalary.Text = "00.00";
            this.totalSalary.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введіть суму премії";
            // 
            // giftMoney
            // 
            this.giftMoney.Location = new System.Drawing.Point(515, 39);
            this.giftMoney.Name = "giftMoney";
            this.giftMoney.Size = new System.Drawing.Size(49, 20);
            this.giftMoney.TabIndex = 5;
            this.giftMoney.TextChanged += new System.EventHandler(this.giftMoney_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 398);
            this.Controls.Add(this.giftMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rawSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rawSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox giftMoney;
    }
}


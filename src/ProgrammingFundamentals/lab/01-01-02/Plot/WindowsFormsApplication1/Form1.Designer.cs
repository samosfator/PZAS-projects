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
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(80, 37);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 0;
            this.aTextBox.Text = "-123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введіть b";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(80, 89);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 4;
            this.bTextBox.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введіть c";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(80, 142);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 20);
            this.cTextBox.TabIndex = 6;
            this.cTextBox.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введіть X1";
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(281, 40);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(100, 20);
            this.x1TextBox.TabIndex = 8;
            this.x1TextBox.Text = "-100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введіть X2";
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(281, 92);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(100, 20);
            this.x2TextBox.TabIndex = 10;
            this.x2TextBox.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введіть H";
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(281, 145);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(100, 20);
            this.hTextBox.TabIndex = 12;
            this.hTextBox.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Побудувати графік";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTextBox);
            this.Name = "Form1";
            this.Text = "Голубєв Владислав ПЗАС-12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.Button button1;
    }
}


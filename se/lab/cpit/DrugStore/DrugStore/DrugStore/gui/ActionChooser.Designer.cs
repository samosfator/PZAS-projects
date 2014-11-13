using System.Windows.Forms;

namespace DrugStore {
    partial class ActionChooser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionChooser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_drugsList = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_addTitle = new System.Windows.Forms.TextBox();
            this.tb_addType = new System.Windows.Forms.TextBox();
            this.tb_addQuantity = new System.Windows.Forms.TextBox();
            this.tb_addDescr = new System.Windows.Forms.TextBox();
            this.btn_addDrug = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugsList)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dgv_drugsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список ліків";
            // 
            // dgv_drugsList
            // 
            this.dgv_drugsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_drugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drugsList.Location = new System.Drawing.Point(-4, 0);
            this.dgv_drugsList.Name = "dgv_drugsList";
            this.dgv_drugsList.ReadOnly = true;
            this.dgv_drugsList.Size = new System.Drawing.Size(826, 345);
            this.dgv_drugsList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btn_addDrug);
            this.tabPage2.Controls.Add(this.tb_addDescr);
            this.tabPage2.Controls.Add(this.tb_addQuantity);
            this.tabPage2.Controls.Add(this.tb_addType);
            this.tabPage2.Controls.Add(this.tb_addTitle);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додати ліки";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(690, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Видалити ліки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва препарату";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип препарату";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Опис";
            // 
            // tb_addTitle
            // 
            this.tb_addTitle.Location = new System.Drawing.Point(131, 22);
            this.tb_addTitle.Name = "tb_addTitle";
            this.tb_addTitle.Size = new System.Drawing.Size(100, 20);
            this.tb_addTitle.TabIndex = 4;
            // 
            // tb_addType
            // 
            this.tb_addType.Location = new System.Drawing.Point(131, 51);
            this.tb_addType.Name = "tb_addType";
            this.tb_addType.Size = new System.Drawing.Size(100, 20);
            this.tb_addType.TabIndex = 5;
            // 
            // tb_addQuantity
            // 
            this.tb_addQuantity.Location = new System.Drawing.Point(131, 77);
            this.tb_addQuantity.Name = "tb_addQuantity";
            this.tb_addQuantity.Size = new System.Drawing.Size(100, 20);
            this.tb_addQuantity.TabIndex = 6;
            // 
            // tb_addDescr
            // 
            this.tb_addDescr.Location = new System.Drawing.Point(131, 103);
            this.tb_addDescr.Name = "tb_addDescr";
            this.tb_addDescr.Size = new System.Drawing.Size(100, 20);
            this.tb_addDescr.TabIndex = 7;
            // 
            // btn_addDrug
            // 
            this.btn_addDrug.Location = new System.Drawing.Point(25, 129);
            this.btn_addDrug.Name = "btn_addDrug";
            this.btn_addDrug.Size = new System.Drawing.Size(206, 23);
            this.btn_addDrug.TabIndex = 8;
            this.btn_addDrug.Text = "Додати препарат у базу";
            this.btn_addDrug.UseVisualStyleBackColor = true;
            this.btn_addDrug.Click += new System.EventHandler(this.btn_addDrug_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 167);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ActionChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 395);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік ліків";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugsList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_drugsList;
        private TextBox tb_addDescr;
        private TextBox tb_addQuantity;
        private TextBox tb_addType;
        private TextBox tb_addTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_addDrug;
        private GroupBox groupBox1;

    }
}
using System.Windows.Forms;

namespace DrugStore.gui {
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
            this.tab_add_drugs = new System.Windows.Forms.TabPage();
            this.lbl_add_success = new System.Windows.Forms.Label();
            this.lbl_check_price = new System.Windows.Forms.Label();
            this.lbl_check_quantity = new System.Windows.Forms.Label();
            this.lbl_check_type = new System.Windows.Forms.Label();
            this.lbl_check_title = new System.Windows.Forms.Label();
            this.tb_addQuantity = new System.Windows.Forms.TextBox();
            this.tb_addType = new System.Windows.Forms.TextBox();
            this.tb_addTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addPicture = new System.Windows.Forms.Button();
            this.btn_updateDrug = new System.Windows.Forms.Button();
            this.tb_addPrice = new System.Windows.Forms.TextBox();
            this.btn_addDrug = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_addDescr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_reload_add = new System.Windows.Forms.Button();
            this.lb_drug_list = new System.Windows.Forms.ListBox();
            this.tab_delete_drugs = new System.Windows.Forms.TabPage();
            this.btn_delDrug = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_reload_del = new System.Windows.Forms.Button();
            this.lbl_delete_status = new System.Windows.Forms.Label();
            this.tb_del_title = new System.Windows.Forms.TextBox();
            this.lb_delete_items = new System.Windows.Forms.ListBox();
            this.tab_view_drugs = new System.Windows.Forms.TabPage();
            this.btn_reloadTable = new System.Windows.Forms.Button();
            this.dgv_drugsList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tab_add_drugs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tab_delete_drugs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_view_drugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_add_drugs);
            this.tabControl1.Controls.Add(this.tab_delete_drugs);
            this.tabControl1.Controls.Add(this.tab_view_drugs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_add_drugs
            // 
            this.tab_add_drugs.BackColor = System.Drawing.SystemColors.Control;
            this.tab_add_drugs.Controls.Add(this.tb_addQuantity);
            this.tab_add_drugs.Controls.Add(this.tb_addType);
            this.tab_add_drugs.Controls.Add(this.tb_addTitle);
            this.tab_add_drugs.Controls.Add(this.label3);
            this.tab_add_drugs.Controls.Add(this.label2);
            this.tab_add_drugs.Controls.Add(this.label1);
            this.tab_add_drugs.Controls.Add(this.groupBox1);
            this.tab_add_drugs.Controls.Add(this.groupBox4);
            this.tab_add_drugs.Location = new System.Drawing.Point(4, 22);
            this.tab_add_drugs.Name = "tab_add_drugs";
            this.tab_add_drugs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_add_drugs.Size = new System.Drawing.Size(822, 345);
            this.tab_add_drugs.TabIndex = 1;
            this.tab_add_drugs.Text = "Додати ліки";
            // 
            // lbl_add_success
            // 
            this.lbl_add_success.AutoSize = true;
            this.lbl_add_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_add_success.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_add_success.Location = new System.Drawing.Point(228, 190);
            this.lbl_add_success.Name = "lbl_add_success";
            this.lbl_add_success.Size = new System.Drawing.Size(14, 13);
            this.lbl_add_success.TabIndex = 12;
            this.lbl_add_success.Text = "X";
            // 
            // lbl_check_price
            // 
            this.lbl_check_price.AutoSize = true;
            this.lbl_check_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_check_price.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_check_price.Location = new System.Drawing.Point(228, 104);
            this.lbl_check_price.Name = "lbl_check_price";
            this.lbl_check_price.Size = new System.Drawing.Size(14, 13);
            this.lbl_check_price.TabIndex = 11;
            this.lbl_check_price.Text = "X";
            // 
            // lbl_check_quantity
            // 
            this.lbl_check_quantity.AutoSize = true;
            this.lbl_check_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_check_quantity.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_check_quantity.Location = new System.Drawing.Point(228, 74);
            this.lbl_check_quantity.Name = "lbl_check_quantity";
            this.lbl_check_quantity.Size = new System.Drawing.Size(14, 13);
            this.lbl_check_quantity.TabIndex = 2;
            this.lbl_check_quantity.Text = "X";
            // 
            // lbl_check_type
            // 
            this.lbl_check_type.AutoSize = true;
            this.lbl_check_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_check_type.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_check_type.Location = new System.Drawing.Point(228, 45);
            this.lbl_check_type.Name = "lbl_check_type";
            this.lbl_check_type.Size = new System.Drawing.Size(14, 13);
            this.lbl_check_type.TabIndex = 1;
            this.lbl_check_type.Text = "X";
            // 
            // lbl_check_title
            // 
            this.lbl_check_title.AutoSize = true;
            this.lbl_check_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_check_title.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_check_title.Location = new System.Drawing.Point(228, 18);
            this.lbl_check_title.Name = "lbl_check_title";
            this.lbl_check_title.Size = new System.Drawing.Size(14, 13);
            this.lbl_check_title.TabIndex = 0;
            this.lbl_check_title.Text = "X";
            // 
            // tb_addQuantity
            // 
            this.tb_addQuantity.Location = new System.Drawing.Point(131, 77);
            this.tb_addQuantity.Name = "tb_addQuantity";
            this.tb_addQuantity.Size = new System.Drawing.Size(100, 20);
            this.tb_addQuantity.TabIndex = 6;
            this.tb_addQuantity.TextChanged += new System.EventHandler(this.tb_addQuantity_TextChanged);
            // 
            // tb_addType
            // 
            this.tb_addType.Location = new System.Drawing.Point(131, 51);
            this.tb_addType.Name = "tb_addType";
            this.tb_addType.Size = new System.Drawing.Size(100, 20);
            this.tb_addType.TabIndex = 5;
            this.tb_addType.TextChanged += new System.EventHandler(this.tb_addType_TextChanged);
            // 
            // tb_addTitle
            // 
            this.tb_addTitle.Location = new System.Drawing.Point(131, 22);
            this.tb_addTitle.Name = "tb_addTitle";
            this.tb_addTitle.Size = new System.Drawing.Size(100, 20);
            this.tb_addTitle.TabIndex = 4;
            this.tb_addTitle.TextChanged += new System.EventHandler(this.tb_addTitle_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип препарату";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbl_add_success);
            this.groupBox1.Controls.Add(this.btn_addPicture);
            this.groupBox1.Controls.Add(this.lbl_check_price);
            this.groupBox1.Controls.Add(this.btn_updateDrug);
            this.groupBox1.Controls.Add(this.tb_addPrice);
            this.groupBox1.Controls.Add(this.lbl_check_quantity);
            this.groupBox1.Controls.Add(this.btn_addDrug);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_check_type);
            this.groupBox1.Controls.Add(this.tb_addDescr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_check_title);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 216);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_addPicture
            // 
            this.btn_addPicture.Location = new System.Drawing.Point(19, 151);
            this.btn_addPicture.Name = "btn_addPicture";
            this.btn_addPicture.Size = new System.Drawing.Size(206, 23);
            this.btn_addPicture.TabIndex = 13;
            this.btn_addPicture.Text = "Додати зображення";
            this.btn_addPicture.UseVisualStyleBackColor = true;
            this.btn_addPicture.Click += new System.EventHandler(this.btn_addPicture_Click);
            // 
            // btn_updateDrug
            // 
            this.btn_updateDrug.Location = new System.Drawing.Point(19, 180);
            this.btn_updateDrug.Name = "btn_updateDrug";
            this.btn_updateDrug.Size = new System.Drawing.Size(91, 23);
            this.btn_updateDrug.TabIndex = 13;
            this.btn_updateDrug.Text = "Оновити";
            this.btn_updateDrug.UseVisualStyleBackColor = true;
            this.btn_updateDrug.Click += new System.EventHandler(this.btn_updateDrug_Click);
            // 
            // tb_addPrice
            // 
            this.tb_addPrice.Location = new System.Drawing.Point(125, 97);
            this.tb_addPrice.Name = "tb_addPrice";
            this.tb_addPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_addPrice.TabIndex = 7;
            this.tb_addPrice.TextChanged += new System.EventHandler(this.tb_addPrice_TextChanged);
            // 
            // btn_addDrug
            // 
            this.btn_addDrug.Location = new System.Drawing.Point(125, 180);
            this.btn_addDrug.Name = "btn_addDrug";
            this.btn_addDrug.Size = new System.Drawing.Size(100, 23);
            this.btn_addDrug.TabIndex = 9;
            this.btn_addDrug.Text = "Додати у базу";
            this.btn_addDrug.UseVisualStyleBackColor = true;
            this.btn_addDrug.Click += new System.EventHandler(this.btn_addDrug_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ціна";
            // 
            // tb_addDescr
            // 
            this.tb_addDescr.Location = new System.Drawing.Point(125, 125);
            this.tb_addDescr.Name = "tb_addDescr";
            this.tb_addDescr.Size = new System.Drawing.Size(100, 20);
            this.tb_addDescr.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Опис";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_reload_add);
            this.groupBox4.Controls.Add(this.lb_drug_list);
            this.groupBox4.Location = new System.Drawing.Point(546, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 216);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Список ліків";
            // 
            // btn_reload_add
            // 
            this.btn_reload_add.Location = new System.Drawing.Point(221, 20);
            this.btn_reload_add.Name = "btn_reload_add";
            this.btn_reload_add.Size = new System.Drawing.Size(23, 23);
            this.btn_reload_add.TabIndex = 13;
            this.btn_reload_add.Text = "↺";
            this.btn_reload_add.UseVisualStyleBackColor = true;
            this.btn_reload_add.Click += new System.EventHandler(this.btn_reload_add_Click);
            // 
            // lb_drug_list
            // 
            this.lb_drug_list.FormattingEnabled = true;
            this.lb_drug_list.Location = new System.Drawing.Point(15, 20);
            this.lb_drug_list.Name = "lb_drug_list";
            this.lb_drug_list.Size = new System.Drawing.Size(229, 186);
            this.lb_drug_list.TabIndex = 11;
            this.lb_drug_list.SelectedIndexChanged += new System.EventHandler(this.lb_drug_list_SelectedIndexChanged);
            // 
            // tab_delete_drugs
            // 
            this.tab_delete_drugs.BackColor = System.Drawing.SystemColors.Control;
            this.tab_delete_drugs.Controls.Add(this.btn_delDrug);
            this.tab_delete_drugs.Controls.Add(this.label6);
            this.tab_delete_drugs.Controls.Add(this.groupBox3);
            this.tab_delete_drugs.Location = new System.Drawing.Point(4, 22);
            this.tab_delete_drugs.Name = "tab_delete_drugs";
            this.tab_delete_drugs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_delete_drugs.Size = new System.Drawing.Size(822, 345);
            this.tab_delete_drugs.TabIndex = 2;
            this.tab_delete_drugs.Text = "Видалити ліки";
            // 
            // btn_delDrug
            // 
            this.btn_delDrug.Location = new System.Drawing.Point(23, 186);
            this.btn_delDrug.Name = "btn_delDrug";
            this.btn_delDrug.Size = new System.Drawing.Size(207, 30);
            this.btn_delDrug.TabIndex = 3;
            this.btn_delDrug.Text = "Видалити препарат";
            this.btn_delDrug.UseVisualStyleBackColor = true;
            this.btn_delDrug.Click += new System.EventHandler(this.btn_delDrug_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Назва перпарату";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_reload_del);
            this.groupBox3.Controls.Add(this.lbl_delete_status);
            this.groupBox3.Controls.Add(this.tb_del_title);
            this.groupBox3.Controls.Add(this.lb_delete_items);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 259);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btn_reload_del
            // 
            this.btn_reload_del.Location = new System.Drawing.Point(201, 42);
            this.btn_reload_del.Name = "btn_reload_del";
            this.btn_reload_del.Size = new System.Drawing.Size(23, 23);
            this.btn_reload_del.TabIndex = 100;
            this.btn_reload_del.Text = "↺";
            this.btn_reload_del.UseVisualStyleBackColor = true;
            this.btn_reload_del.Click += new System.EventHandler(this.btn_reload_del_Click);
            // 
            // lbl_delete_status
            // 
            this.lbl_delete_status.AutoSize = true;
            this.lbl_delete_status.Location = new System.Drawing.Point(14, 226);
            this.lbl_delete_status.Name = "lbl_delete_status";
            this.lbl_delete_status.Size = new System.Drawing.Size(16, 13);
            this.lbl_delete_status.TabIndex = 5;
            this.lbl_delete_status.Text = "...";
            // 
            // tb_del_title
            // 
            this.tb_del_title.Location = new System.Drawing.Point(114, 16);
            this.tb_del_title.Name = "tb_del_title";
            this.tb_del_title.Size = new System.Drawing.Size(110, 20);
            this.tb_del_title.TabIndex = 1;
            this.tb_del_title.TextChanged += new System.EventHandler(this.tb_del_title_TextChanged);
            // 
            // lb_delete_items
            // 
            this.lb_delete_items.FormattingEnabled = true;
            this.lb_delete_items.Location = new System.Drawing.Point(17, 42);
            this.lb_delete_items.Name = "lb_delete_items";
            this.lb_delete_items.Size = new System.Drawing.Size(207, 121);
            this.lb_delete_items.TabIndex = 99;
            // 
            // tab_view_drugs
            // 
            this.tab_view_drugs.BackColor = System.Drawing.SystemColors.Control;
            this.tab_view_drugs.Controls.Add(this.btn_reloadTable);
            this.tab_view_drugs.Controls.Add(this.dgv_drugsList);
            this.tab_view_drugs.Location = new System.Drawing.Point(4, 22);
            this.tab_view_drugs.Name = "tab_view_drugs";
            this.tab_view_drugs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_view_drugs.Size = new System.Drawing.Size(822, 345);
            this.tab_view_drugs.TabIndex = 0;
            this.tab_view_drugs.Text = "Список ліків";
            // 
            // btn_reloadTable
            // 
            this.btn_reloadTable.Location = new System.Drawing.Point(6, 319);
            this.btn_reloadTable.Name = "btn_reloadTable";
            this.btn_reloadTable.Size = new System.Drawing.Size(117, 23);
            this.btn_reloadTable.TabIndex = 1;
            this.btn_reloadTable.Text = "Оновити таблицю";
            this.btn_reloadTable.UseVisualStyleBackColor = true;
            this.btn_reloadTable.Click += new System.EventHandler(this.btn_reloadTable_Click);
            // 
            // dgv_drugsList
            // 
            this.dgv_drugsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_drugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drugsList.Location = new System.Drawing.Point(-4, 0);
            this.dgv_drugsList.Name = "dgv_drugsList";
            this.dgv_drugsList.ReadOnly = true;
            this.dgv_drugsList.Size = new System.Drawing.Size(826, 316);
            this.dgv_drugsList.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.tab_add_drugs.ResumeLayout(false);
            this.tab_add_drugs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tab_delete_drugs.ResumeLayout(false);
            this.tab_delete_drugs.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tab_view_drugs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_view_drugs;
        private System.Windows.Forms.TabPage tab_add_drugs;
        private System.Windows.Forms.TabPage tab_delete_drugs;
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
        private TextBox tb_addPrice;
        private Label label5;
        private Label lbl_check_price;
        private Label lbl_check_quantity;
        private Label lbl_check_type;
        private Label lbl_check_title;
        private Label lbl_add_success;
        private Button btn_reloadTable;
        private GroupBox groupBox3;
        private Button btn_delDrug;
        private ListBox lb_delete_items;
        private TextBox tb_del_title;
        private Label label6;
        private Label lbl_delete_status;
        private GroupBox groupBox4;
        private ListBox lb_drug_list;
        private Button btn_updateDrug;
        private Button btn_reload_add;
        private Button btn_reload_del;
        private Button btn_addPicture;
        private PictureBox pictureBox1;

    }
}
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
            this.tb_addType = new System.Windows.Forms.TextBox();
            this.tb_addTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reload_add = new System.Windows.Forms.Button();
            this.tb_filter = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_addPicture = new System.Windows.Forms.Button();
            this.lb_drug_list = new System.Windows.Forms.ListBox();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.tb_addDescr = new System.Windows.Forms.RichTextBox();
            this.btn_delDrug = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addDrug = new System.Windows.Forms.Button();
            this.btn_updateDrug = new System.Windows.Forms.Button();
            this.tb_addPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_view_drugs = new System.Windows.Forms.TabPage();
            this.btn_reloadTable = new System.Windows.Forms.Button();
            this.dgv_drugsList = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_add_drugs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_view_drugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_add_drugs);
            this.tabControl1.Controls.Add(this.tab_view_drugs);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_add_drugs
            // 
            this.tab_add_drugs.BackColor = System.Drawing.SystemColors.Control;
            this.tab_add_drugs.Controls.Add(this.tb_addType);
            this.tab_add_drugs.Controls.Add(this.tb_addTitle);
            this.tab_add_drugs.Controls.Add(this.label3);
            this.tab_add_drugs.Controls.Add(this.label2);
            this.tab_add_drugs.Controls.Add(this.label1);
            this.tab_add_drugs.Controls.Add(this.groupBox1);
            this.tab_add_drugs.Location = new System.Drawing.Point(4, 22);
            this.tab_add_drugs.Name = "tab_add_drugs";
            this.tab_add_drugs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_add_drugs.Size = new System.Drawing.Size(603, 257);
            this.tab_add_drugs.TabIndex = 1;
            this.tab_add_drugs.Text = "Додати ліки";
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
            this.groupBox1.Controls.Add(this.btn_reload_add);
            this.groupBox1.Controls.Add(this.tb_filter);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.btn_addPicture);
            this.groupBox1.Controls.Add(this.lb_drug_list);
            this.groupBox1.Controls.Add(this.num_quantity);
            this.groupBox1.Controls.Add(this.tb_addDescr);
            this.groupBox1.Controls.Add(this.btn_delDrug);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_addDrug);
            this.groupBox1.Controls.Add(this.btn_updateDrug);
            this.groupBox1.Controls.Add(this.tb_addPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 238);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_reload_add
            // 
            this.btn_reload_add.Location = new System.Drawing.Point(556, 14);
            this.btn_reload_add.Name = "btn_reload_add";
            this.btn_reload_add.Size = new System.Drawing.Size(23, 23);
            this.btn_reload_add.TabIndex = 13;
            this.btn_reload_add.Text = "↺";
            this.btn_reload_add.UseVisualStyleBackColor = true;
            this.btn_reload_add.Click += new System.EventHandler(this.btn_reload_add_Click);
            // 
            // tb_filter
            // 
            this.tb_filter.BackColor = System.Drawing.SystemColors.Info;
            this.tb_filter.Location = new System.Drawing.Point(408, 181);
            this.tb_filter.Name = "tb_filter";
            this.tb_filter.Size = new System.Drawing.Size(171, 20);
            this.tb_filter.TabIndex = 16;
            this.tb_filter.TextChanged += new System.EventHandler(this.tb_filter_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(3, 213);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(586, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_lbl
            // 
            this.status_lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_addPicture
            // 
            this.btn_addPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addPicture.Location = new System.Drawing.Point(231, 139);
            this.btn_addPicture.Name = "btn_addPicture";
            this.btn_addPicture.Size = new System.Drawing.Size(171, 28);
            this.btn_addPicture.TabIndex = 9;
            this.btn_addPicture.Text = "+ зобр.";
            this.btn_addPicture.UseVisualStyleBackColor = true;
            this.btn_addPicture.Click += new System.EventHandler(this.btn_addPicture_Click);
            // 
            // lb_drug_list
            // 
            this.lb_drug_list.FormattingEnabled = true;
            this.lb_drug_list.Location = new System.Drawing.Point(408, 16);
            this.lb_drug_list.Name = "lb_drug_list";
            this.lb_drug_list.Size = new System.Drawing.Size(171, 160);
            this.lb_drug_list.TabIndex = 11;
            this.lb_drug_list.SelectedIndexChanged += new System.EventHandler(this.lb_drug_list_SelectedIndexChanged);
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(125, 72);
            this.num_quantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(100, 20);
            this.num_quantity.TabIndex = 6;
            this.num_quantity.ValueChanged += new System.EventHandler(this.num_quantity_ValueChanged);
            // 
            // tb_addDescr
            // 
            this.tb_addDescr.Location = new System.Drawing.Point(231, 174);
            this.tb_addDescr.Name = "tb_addDescr";
            this.tb_addDescr.Size = new System.Drawing.Size(171, 31);
            this.tb_addDescr.TabIndex = 14;
            this.tb_addDescr.Text = "";
            this.tb_addDescr.TextChanged += new System.EventHandler(this.tb_addDescr_TextChanged);
            // 
            // btn_delDrug
            // 
            this.btn_delDrug.BackColor = System.Drawing.Color.Crimson;
            this.btn_delDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delDrug.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delDrug.Location = new System.Drawing.Point(19, 174);
            this.btn_delDrug.Name = "btn_delDrug";
            this.btn_delDrug.Size = new System.Drawing.Size(206, 30);
            this.btn_delDrug.TabIndex = 14;
            this.btn_delDrug.Text = "Видалити препарат";
            this.btn_delDrug.UseVisualStyleBackColor = false;
            this.btn_delDrug.Click += new System.EventHandler(this.btn_delDrug_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DrugStore.Properties.Resources.colordrugs2;
            this.pictureBox1.Location = new System.Drawing.Point(231, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addDrug
            // 
            this.btn_addDrug.BackColor = System.Drawing.Color.LightGreen;
            this.btn_addDrug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addDrug.Location = new System.Drawing.Point(125, 139);
            this.btn_addDrug.Name = "btn_addDrug";
            this.btn_addDrug.Size = new System.Drawing.Size(100, 29);
            this.btn_addDrug.TabIndex = 9;
            this.btn_addDrug.Text = "Додати у базу";
            this.btn_addDrug.UseVisualStyleBackColor = false;
            this.btn_addDrug.Click += new System.EventHandler(this.btn_addDrug_Click);
            // 
            // btn_updateDrug
            // 
            this.btn_updateDrug.BackColor = System.Drawing.Color.Gold;
            this.btn_updateDrug.Enabled = false;
            this.btn_updateDrug.Location = new System.Drawing.Point(19, 139);
            this.btn_updateDrug.Name = "btn_updateDrug";
            this.btn_updateDrug.Size = new System.Drawing.Size(100, 29);
            this.btn_updateDrug.TabIndex = 13;
            this.btn_updateDrug.Text = "Оновити";
            this.btn_updateDrug.UseVisualStyleBackColor = false;
            this.btn_updateDrug.Click += new System.EventHandler(this.btn_updateDrug_Click);
            // 
            // tb_addPrice
            // 
            this.tb_addPrice.Location = new System.Drawing.Point(125, 101);
            this.tb_addPrice.Name = "tb_addPrice";
            this.tb_addPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_addPrice.TabIndex = 7;
            this.tb_addPrice.TextChanged += new System.EventHandler(this.tb_addPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ціна";
            // 
            // tab_view_drugs
            // 
            this.tab_view_drugs.BackColor = System.Drawing.SystemColors.Control;
            this.tab_view_drugs.Controls.Add(this.btn_reloadTable);
            this.tab_view_drugs.Controls.Add(this.dgv_drugsList);
            this.tab_view_drugs.Location = new System.Drawing.Point(4, 22);
            this.tab_view_drugs.Name = "tab_view_drugs";
            this.tab_view_drugs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_view_drugs.Size = new System.Drawing.Size(603, 257);
            this.tab_view_drugs.TabIndex = 0;
            this.tab_view_drugs.Text = "Перегляд";
            // 
            // btn_reloadTable
            // 
            this.btn_reloadTable.Location = new System.Drawing.Point(490, 238);
            this.btn_reloadTable.Name = "btn_reloadTable";
            this.btn_reloadTable.Size = new System.Drawing.Size(117, 23);
            this.btn_reloadTable.TabIndex = 1;
            this.btn_reloadTable.Text = "Оновити таблицю";
            this.btn_reloadTable.UseVisualStyleBackColor = true;
            this.btn_reloadTable.Click += new System.EventHandler(this.btn_reloadTable_Click);
            // 
            // dgv_drugsList
            // 
            this.dgv_drugsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_drugsList.Location = new System.Drawing.Point(-4, 0);
            this.dgv_drugsList.Name = "dgv_drugsList";
            this.dgv_drugsList.ReadOnly = true;
            this.dgv_drugsList.Size = new System.Drawing.Size(607, 258);
            this.dgv_drugsList.TabIndex = 0;
            // 
            // ActionChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrugStore.Properties.Resources.colordrugs2;
            this.ClientSize = new System.Drawing.Size(635, 304);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ActionChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік ліків";
            this.tabControl1.ResumeLayout(false);
            this.tab_add_drugs.ResumeLayout(false);
            this.tab_add_drugs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_view_drugs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drugsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_view_drugs;
        private System.Windows.Forms.TabPage tab_add_drugs;
        private System.Windows.Forms.DataGridView dgv_drugsList;
        private TextBox tb_addType;
        private TextBox tb_addTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_addDrug;
        private GroupBox groupBox1;
        private TextBox tb_addPrice;
        private Label label5;
        private Button btn_reloadTable;
        private ListBox lb_drug_list;
        private Button btn_updateDrug;
        private Button btn_reload_add;
        private Button btn_addPicture;
        private PictureBox pictureBox1;
        private RichTextBox tb_addDescr;
        private Button btn_delDrug;
        private TextBox tb_filter;
        private NumericUpDown num_quantity;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel status_lbl;

    }
}
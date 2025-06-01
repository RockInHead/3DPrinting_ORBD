namespace _3DPrinting_ORBD
{
    partial class SQLForm
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonFinishedDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomers = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Type = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Sales = new System.Windows.Forms.RadioButton();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 421);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 81);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 337);
            this.dataGridViewSelect.TabIndex = 3;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonFinishedDetails);
            this.groupBoxSelect.Controls.Add(this.radioButtonOrders);
            this.groupBoxSelect.Controls.Add(this.radioButtonCustomers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 78);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonFinishedDetails
            // 
            this.radioButtonFinishedDetails.AutoSize = true;
            this.radioButtonFinishedDetails.Location = new System.Drawing.Point(311, 21);
            this.radioButtonFinishedDetails.Name = "radioButtonFinishedDetails";
            this.radioButtonFinishedDetails.Size = new System.Drawing.Size(106, 17);
            this.radioButtonFinishedDetails.TabIndex = 2;
            this.radioButtonFinishedDetails.TabStop = true;
            this.radioButtonFinishedDetails.Text = "Готовые детали";
            this.radioButtonFinishedDetails.UseVisualStyleBackColor = true;
            this.radioButtonFinishedDetails.CheckedChanged += new System.EventHandler(this.radioButtonFinishedDetails_CheckedChanged);
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(162, 21);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(64, 17);
            this.radioButtonOrders.TabIndex = 1;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Заказы";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            this.radioButtonOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // radioButtonCustomers
            // 
            this.radioButtonCustomers.AutoSize = true;
            this.radioButtonCustomers.Location = new System.Drawing.Point(6, 21);
            this.radioButtonCustomers.Name = "radioButtonCustomers";
            this.radioButtonCustomers.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCustomers.TabIndex = 0;
            this.radioButtonCustomers.TabStop = true;
            this.radioButtonCustomers.Text = "Заказчики";
            this.radioButtonCustomers.UseVisualStyleBackColor = true;
            this.radioButtonCustomers.CheckedChanged += new System.EventHandler(this.radioButtonCustomers_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 421);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 221);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 197);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxOrderID);
            this.groupBoxFSelect.Controls.Add(this.labelOrderID);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 218);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "groupBox1";
            // 
            // buttonF_select
            // 
            this.buttonF_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonF_select.Location = new System.Drawing.Point(399, 162);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(188, 32);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Прибыль сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(22, 125);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(258, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = " Включить сортировку по убыванию прибыли.";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(212, 81);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(135, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(22, 81);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(150, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Type);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Sales);
            this.groupBoxDet.Location = new System.Drawing.Point(399, 21);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(256, 124);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли заказа";
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(26, 86);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(112, 17);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Type
            // 
            this.radioButtonDet_Type.AutoSize = true;
            this.radioButtonDet_Type.Location = new System.Drawing.Point(26, 60);
            this.radioButtonDet_Type.Name = "radioButtonDet_Type";
            this.radioButtonDet_Type.Size = new System.Drawing.Size(161, 17);
            this.radioButtonDet_Type.TabIndex = 1;
            this.radioButtonDet_Type.TabStop = true;
            this.radioButtonDet_Type.Text = "Прибыль по типу пластика";
            this.radioButtonDet_Type.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Sales
            // 
            this.radioButtonDet_Sales.AutoSize = true;
            this.radioButtonDet_Sales.Location = new System.Drawing.Point(26, 34);
            this.radioButtonDet_Sales.Name = "radioButtonDet_Sales";
            this.radioButtonDet_Sales.Size = new System.Drawing.Size(141, 17);
            this.radioButtonDet_Sales.TabIndex = 0;
            this.radioButtonDet_Sales.TabStop = true;
            this.radioButtonDet_Sales.Text = "Прибыль по продажам";
            this.radioButtonDet_Sales.UseVisualStyleBackColor = true;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(212, 40);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(135, 20);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(19, 40);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(94, 13);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "ФИО Заказчика:";
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "SQLForm";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonFinishedDetails;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonCustomers;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Type;
        private System.Windows.Forms.RadioButton radioButtonDet_Sales;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
    }
}
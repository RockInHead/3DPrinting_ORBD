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
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.buttonSelectModels = new System.Windows.Forms.Button();
            this.dataGridViewModel = new System.Windows.Forms.DataGridView();
            this.panelModel = new System.Windows.Forms.Panel();
            this.textBoxFileFormat_model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenPhoto_model = new System.Windows.Forms.Button();
            this.pictureBoxPhoto_model = new System.Windows.Forms.PictureBox();
            this.textBoxDimension_model = new System.Windows.Forms.TextBox();
            this.textBoxOrderID_model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.textBoxId_model = new System.Windows.Forms.TextBox();
            this.labelId_model = new System.Windows.Forms.Label();
            this.radioButtonDelete_model = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_model = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_model = new System.Windows.Forms.RadioButton();
            this.openFileDialogModel = new System.Windows.Forms.OpenFileDialog();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).BeginInit();
            this.panelModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_model)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(740, 554);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePrimer.Size = new System.Drawing.Size(732, 528);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(2, 65);
            this.dataGridViewSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(728, 461);
            this.dataGridViewSelect.TabIndex = 3;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonFinishedDetails);
            this.groupBoxSelect.Controls.Add(this.radioButtonOrders);
            this.groupBoxSelect.Controls.Add(this.radioButtonCustomers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(2, 2);
            this.groupBoxSelect.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSelect.Size = new System.Drawing.Size(728, 63);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonFinishedDetails
            // 
            this.radioButtonFinishedDetails.AutoSize = true;
            this.radioButtonFinishedDetails.Location = new System.Drawing.Point(233, 17);
            this.radioButtonFinishedDetails.Margin = new System.Windows.Forms.Padding(2);
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
            this.radioButtonOrders.Location = new System.Drawing.Point(122, 17);
            this.radioButtonOrders.Margin = new System.Windows.Forms.Padding(2);
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
            this.radioButtonCustomers.Location = new System.Drawing.Point(4, 17);
            this.radioButtonCustomers.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSelect.Size = new System.Drawing.Size(732, 528);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(2, 179);
            this.dataGridViewFSelect.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(728, 347);
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
            this.groupBoxFSelect.Location = new System.Drawing.Point(2, 2);
            this.groupBoxFSelect.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFSelect.Size = new System.Drawing.Size(728, 177);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "groupBox1";
            // 
            // buttonF_select
            // 
            this.buttonF_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonF_select.Location = new System.Drawing.Point(299, 132);
            this.buttonF_select.Margin = new System.Windows.Forms.Padding(2);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(141, 26);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Прибыль сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(16, 102);
            this.checkBoxOrder.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(258, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = " Включить сортировку по убыванию прибыли.";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(159, 66);
            this.textBoxMore.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(102, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(16, 66);
            this.checkBoxMore.Margin = new System.Windows.Forms.Padding(2);
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
            this.groupBoxDet.Location = new System.Drawing.Point(299, 17);
            this.groupBoxDet.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDet.Size = new System.Drawing.Size(192, 101);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли заказа";
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(20, 70);
            this.radioButtonDet_NO.Margin = new System.Windows.Forms.Padding(2);
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
            this.radioButtonDet_Type.Location = new System.Drawing.Point(20, 49);
            this.radioButtonDet_Type.Margin = new System.Windows.Forms.Padding(2);
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
            this.radioButtonDet_Sales.Location = new System.Drawing.Point(20, 28);
            this.radioButtonDet_Sales.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDet_Sales.Name = "radioButtonDet_Sales";
            this.radioButtonDet_Sales.Size = new System.Drawing.Size(141, 17);
            this.radioButtonDet_Sales.TabIndex = 0;
            this.radioButtonDet_Sales.TabStop = true;
            this.radioButtonDet_Sales.Text = "Прибыль по продажам";
            this.radioButtonDet_Sales.UseVisualStyleBackColor = true;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(159, 32);
            this.textBoxOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(102, 20);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(14, 32);
            this.labelOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(94, 13);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "ФИО Заказчика:";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSubquery.Size = new System.Drawing.Size(732, 528);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(2, 121);
            this.dataGridViewSubquery.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(728, 405);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(2, 2);
            this.groupBoxSubquery.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSubquery.Size = new System.Drawing.Size(728, 119);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(115, 77);
            this.buttonSubquery.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(170, 25);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(77, 16);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(110, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(40, 19);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "OrderID";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(223, 46);
            this.radioButtonNoCorrelated.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(42, 46);
            this.radioButtonCorrelated.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectModels);
            this.tabPageDML.Controls.Add(this.dataGridViewModel);
            this.tabPageDML.Controls.Add(this.panelModel);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDML.Size = new System.Drawing.Size(732, 528);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // buttonSelectModels
            // 
            this.buttonSelectModels.Location = new System.Drawing.Point(318, 291);
            this.buttonSelectModels.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectModels.Name = "buttonSelectModels";
            this.buttonSelectModels.Size = new System.Drawing.Size(146, 23);
            this.buttonSelectModels.TabIndex = 11;
            this.buttonSelectModels.Text = "Показать список моделей";
            this.buttonSelectModels.UseVisualStyleBackColor = true;
            this.buttonSelectModels.Click += new System.EventHandler(this.buttonSelectModels_Click);
            // 
            // dataGridViewModel
            // 
            this.dataGridViewModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewModel.Location = new System.Drawing.Point(2, 318);
            this.dataGridViewModel.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewModel.Name = "dataGridViewModel";
            this.dataGridViewModel.RowHeadersWidth = 51;
            this.dataGridViewModel.RowTemplate.Height = 24;
            this.dataGridViewModel.Size = new System.Drawing.Size(728, 208);
            this.dataGridViewModel.TabIndex = 2;
            // 
            // panelModel
            // 
            this.panelModel.Controls.Add(this.textBoxFileFormat_model);
            this.panelModel.Controls.Add(this.label4);
            this.panelModel.Controls.Add(this.buttonOpenPhoto_model);
            this.panelModel.Controls.Add(this.pictureBoxPhoto_model);
            this.panelModel.Controls.Add(this.textBoxDimension_model);
            this.panelModel.Controls.Add(this.textBoxOrderID_model);
            this.panelModel.Controls.Add(this.label3);
            this.panelModel.Controls.Add(this.label2);
            this.panelModel.Controls.Add(this.label1);
            this.panelModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModel.Location = new System.Drawing.Point(2, 113);
            this.panelModel.Margin = new System.Windows.Forms.Padding(2);
            this.panelModel.Name = "panelModel";
            this.panelModel.Size = new System.Drawing.Size(728, 174);
            this.panelModel.TabIndex = 1;
            // 
            // textBoxFileFormat_model
            // 
            this.textBoxFileFormat_model.Location = new System.Drawing.Point(130, 89);
            this.textBoxFileFormat_model.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFileFormat_model.Name = "textBoxFileFormat_model";
            this.textBoxFileFormat_model.Size = new System.Drawing.Size(108, 20);
            this.textBoxFileFormat_model.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Расширение файла";
            // 
            // buttonOpenPhoto_model
            // 
            this.buttonOpenPhoto_model.Location = new System.Drawing.Point(316, 135);
            this.buttonOpenPhoto_model.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenPhoto_model.Name = "buttonOpenPhoto_model";
            this.buttonOpenPhoto_model.Size = new System.Drawing.Size(146, 23);
            this.buttonOpenPhoto_model.TabIndex = 10;
            this.buttonOpenPhoto_model.Text = "Открыть фото модели";
            this.buttonOpenPhoto_model.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto_model.Click += new System.EventHandler(this.buttonOpenPhoto_model_Click);
            // 
            // pictureBoxPhoto_model
            // 
            this.pictureBoxPhoto_model.Location = new System.Drawing.Point(316, 32);
            this.pictureBoxPhoto_model.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPhoto_model.Name = "pictureBoxPhoto_model";
            this.pictureBoxPhoto_model.Size = new System.Drawing.Size(146, 98);
            this.pictureBoxPhoto_model.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto_model.TabIndex = 9;
            this.pictureBoxPhoto_model.TabStop = false;
            // 
            // textBoxDimension_model
            // 
            this.textBoxDimension_model.Location = new System.Drawing.Point(130, 58);
            this.textBoxDimension_model.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDimension_model.Name = "textBoxDimension_model";
            this.textBoxDimension_model.Size = new System.Drawing.Size(108, 20);
            this.textBoxDimension_model.TabIndex = 8;
            // 
            // textBoxOrderID_model
            // 
            this.textBoxOrderID_model.Location = new System.Drawing.Point(130, 32);
            this.textBoxOrderID_model.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOrderID_model.Name = "textBoxOrderID_model";
            this.textBoxOrderID_model.Size = new System.Drawing.Size(108, 20);
            this.textBoxOrderID_model.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фото модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размеры модели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "OrderID";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_model);
            this.groupBoxDML.Controls.Add(this.labelId_model);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_model);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_model);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_model);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(2, 2);
            this.groupBoxDML.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDML.Size = new System.Drawing.Size(728, 111);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(292, 76);
            this.buttonExecuteDML.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(146, 23);
            this.buttonExecuteDML.TabIndex = 11;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // textBoxId_model
            // 
            this.textBoxId_model.Location = new System.Drawing.Point(181, 79);
            this.textBoxId_model.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId_model.Name = "textBoxId_model";
            this.textBoxId_model.Size = new System.Drawing.Size(76, 20);
            this.textBoxId_model.TabIndex = 4;
            // 
            // labelId_model
            // 
            this.labelId_model.AutoSize = true;
            this.labelId_model.Location = new System.Drawing.Point(86, 81);
            this.labelId_model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId_model.Name = "labelId_model";
            this.labelId_model.Size = new System.Drawing.Size(67, 13);
            this.labelId_model.TabIndex = 3;
            this.labelId_model.Text = "Код модели";
            // 
            // radioButtonDelete_model
            // 
            this.radioButtonDelete_model.AutoSize = true;
            this.radioButtonDelete_model.Location = new System.Drawing.Point(479, 32);
            this.radioButtonDelete_model.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDelete_model.Name = "radioButtonDelete_model";
            this.radioButtonDelete_model.Size = new System.Drawing.Size(264, 17);
            this.radioButtonDelete_model.TabIndex = 2;
            this.radioButtonDelete_model.TabStop = true;
            this.radioButtonDelete_model.Text = "Удалить данные по моделе с заданным кодом";
            this.radioButtonDelete_model.UseVisualStyleBackColor = true;
            this.radioButtonDelete_model.CheckedChanged += new System.EventHandler(this.radioButtonDelete_model_CheckedChanged);
            // 
            // radioButtonUpdate_model
            // 
            this.radioButtonUpdate_model.AutoSize = true;
            this.radioButtonUpdate_model.Location = new System.Drawing.Point(202, 32);
            this.radioButtonUpdate_model.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonUpdate_model.Name = "radioButtonUpdate_model";
            this.radioButtonUpdate_model.Size = new System.Drawing.Size(272, 17);
            this.radioButtonUpdate_model.TabIndex = 1;
            this.radioButtonUpdate_model.TabStop = true;
            this.radioButtonUpdate_model.Text = "Изменить данные по моделе с заданным кодом";
            this.radioButtonUpdate_model.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert_model
            // 
            this.radioButtonInsert_model.AutoSize = true;
            this.radioButtonInsert_model.Location = new System.Drawing.Point(4, 32);
            this.radioButtonInsert_model.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonInsert_model.Name = "radioButtonInsert_model";
            this.radioButtonInsert_model.Size = new System.Drawing.Size(175, 17);
            this.radioButtonInsert_model.TabIndex = 0;
            this.radioButtonInsert_model.TabStop = true;
            this.radioButtonInsert_model.Text = "Добавить данные по моделе ";
            this.radioButtonInsert_model.UseVisualStyleBackColor = true;
            // 
            // openFileDialogModel
            // 
            this.openFileDialogModel.FileName = "openFileDialogModel";
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 554);
            this.Controls.Add(this.tabControlSQL);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).EndInit();
            this.panelModel.ResumeLayout(false);
            this.panelModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_model)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Label labelId_model;
        private System.Windows.Forms.RadioButton radioButtonDelete_model;
        private System.Windows.Forms.RadioButton radioButtonUpdate_model;
        private System.Windows.Forms.RadioButton radioButtonInsert_model;
        private System.Windows.Forms.Panel panelModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId_model;
        private System.Windows.Forms.PictureBox pictureBoxPhoto_model;
        private System.Windows.Forms.TextBox textBoxDimension_model;
        private System.Windows.Forms.TextBox textBoxOrderID_model;
        private System.Windows.Forms.Button buttonOpenPhoto_model;
        private System.Windows.Forms.OpenFileDialog openFileDialogModel;
        private System.Windows.Forms.Button buttonSelectModels;
        private System.Windows.Forms.DataGridView dataGridViewModel;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxFileFormat_model;
        private System.Windows.Forms.Label label4;
    }
}
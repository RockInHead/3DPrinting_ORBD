namespace _3DPrinting_ORBD
{
    partial class FinishedDetailsListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedDetailsListForm));
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label costPriceLabel;
            System.Windows.Forms.Label plasticLabel;
            System.Windows.Forms.Label profitLabel;
            System.Windows.Forms.Label deadlineLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label orderStatusLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._3D_PrintingDataSet = new _3DPrinting_ORBD._3D_PrintingDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.TableAdapterManager();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.costPriceTextBox = new System.Windows.Forms.TextBox();
            this.plasticComboBox = new System.Windows.Forms.ComboBox();
            this.profitTextBox = new System.Windows.Forms.TextBox();
            this.deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.FinishedDetailsLisyGroupBox = new System.Windows.Forms.GroupBox();
            this.finishedDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finishedDetailTableAdapter = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.FinishedDetailTableAdapter();
            this.finishedDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.FinishedDetailsListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveItemtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.orderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CustomerButton = new System.Windows.Forms.Button();
            orderIDLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            costPriceLabel = new System.Windows.Forms.Label();
            plasticLabel = new System.Windows.Forms.Label();
            profitLabel = new System.Windows.Forms.Label();
            deadlineLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            orderStatusLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._3D_PrintingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.FinishedDetailsLisyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinishedDetailsListBindingNavigator)).BeginInit();
            this.FinishedDetailsListBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _3D_PrintingDataSet
            // 
            this._3D_PrintingDataSet.DataSetName = "_3D_PrintingDataSet";
            this._3D_PrintingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this._3D_PrintingDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._3DModelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FinishedDetailTableAdapter = this.finishedDetailTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.UpdateOrder = _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(770, 31);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.orderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(12, 37);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(60, 16);
            orderIDLabel.TabIndex = 1;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(102, 34);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.orderIDTextBox.TabIndex = 2;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 65);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(83, 16);
            customerIDLabel.TabIndex = 3;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(102, 62);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // costPriceLabel
            // 
            costPriceLabel.AutoSize = true;
            costPriceLabel.Location = new System.Drawing.Point(378, 104);
            costPriceLabel.Name = "costPriceLabel";
            costPriceLabel.Size = new System.Drawing.Size(71, 16);
            costPriceLabel.TabIndex = 5;
            costPriceLabel.Text = "Cost Price:";
            // 
            // costPriceTextBox
            // 
            this.costPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CostPrice", true));
            this.costPriceTextBox.Location = new System.Drawing.Point(468, 98);
            this.costPriceTextBox.Name = "costPriceTextBox";
            this.costPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.costPriceTextBox.TabIndex = 6;
            // 
            // plasticLabel
            // 
            plasticLabel.AutoSize = true;
            plasticLabel.Location = new System.Drawing.Point(12, 93);
            plasticLabel.Name = "plasticLabel";
            plasticLabel.Size = new System.Drawing.Size(50, 16);
            plasticLabel.TabIndex = 7;
            plasticLabel.Text = "Plastic:";
            // 
            // plasticComboBox
            // 
            this.plasticComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Plastic", true));
            this.plasticComboBox.FormattingEnabled = true;
            this.plasticComboBox.Items.AddRange(new object[] {
            "PLA",
            "PETG",
            "ABS",
            "Flex"});
            this.plasticComboBox.Location = new System.Drawing.Point(102, 90);
            this.plasticComboBox.Name = "plasticComboBox";
            this.plasticComboBox.Size = new System.Drawing.Size(200, 24);
            this.plasticComboBox.TabIndex = 8;
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.Location = new System.Drawing.Point(378, 135);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new System.Drawing.Size(40, 16);
            profitLabel.TabIndex = 11;
            profitLabel.Text = "Profit:";
            // 
            // profitTextBox
            // 
            this.profitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Profit", true));
            this.profitTextBox.Location = new System.Drawing.Point(468, 132);
            this.profitTextBox.Name = "profitTextBox";
            this.profitTextBox.Size = new System.Drawing.Size(200, 22);
            this.profitTextBox.TabIndex = 12;
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Location = new System.Drawing.Point(378, 34);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new System.Drawing.Size(65, 16);
            deadlineLabel.TabIndex = 13;
            deadlineLabel.Text = "Deadline:";
            // 
            // deadlineDateTimePicker
            // 
            this.deadlineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Deadline", true));
            this.deadlineDateTimePicker.Location = new System.Drawing.Point(468, 30);
            this.deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            this.deadlineDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.deadlineDateTimePicker.TabIndex = 14;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(378, 73);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(37, 16);
            costLabel.TabIndex = 15;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(468, 70);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 22);
            this.costTextBox.TabIndex = 16;
            // 
            // FinishedDetailsLisyGroupBox
            // 
            this.FinishedDetailsLisyGroupBox.Controls.Add(this.FinishedDetailsListBindingNavigator);
            this.FinishedDetailsLisyGroupBox.Controls.Add(this.finishedDetailDataGridView);
            this.FinishedDetailsLisyGroupBox.Location = new System.Drawing.Point(0, 227);
            this.FinishedDetailsLisyGroupBox.Name = "FinishedDetailsLisyGroupBox";
            this.FinishedDetailsLisyGroupBox.Size = new System.Drawing.Size(758, 341);
            this.FinishedDetailsLisyGroupBox.TabIndex = 17;
            this.FinishedDetailsLisyGroupBox.TabStop = false;
            this.FinishedDetailsLisyGroupBox.Text = "Список готовых деталей в заказе";
            // 
            // finishedDetailBindingSource
            // 
            this.finishedDetailBindingSource.DataMember = "FK_FinishedDetail_Order";
            this.finishedDetailBindingSource.DataSource = this.orderBindingSource;
            // 
            // finishedDetailTableAdapter
            // 
            this.finishedDetailTableAdapter.ClearBeforeFill = true;
            // 
            // finishedDetailDataGridView
            // 
            this.finishedDetailDataGridView.AutoGenerateColumns = false;
            this.finishedDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finishedDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.finishedDetailDataGridView.DataSource = this.finishedDetailBindingSource;
            this.finishedDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.finishedDetailDataGridView.Location = new System.Drawing.Point(3, 48);
            this.finishedDetailDataGridView.Name = "finishedDetailDataGridView";
            this.finishedDetailDataGridView.RowHeadersWidth = 51;
            this.finishedDetailDataGridView.RowTemplate.Height = 24;
            this.finishedDetailDataGridView.Size = new System.Drawing.Size(752, 290);
            this.finishedDetailDataGridView.TabIndex = 0;
            this.finishedDetailDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.finishedDetailDataGridView_DataError);
            // 
            // FinishedDetailsListBindingNavigator
            // 
            this.FinishedDetailsListBindingNavigator.AddNewItem = this.toolStripButton1;
            this.FinishedDetailsListBindingNavigator.BindingSource = this.finishedDetailBindingSource;
            this.FinishedDetailsListBindingNavigator.CountItem = this.toolStripLabel1;
            this.FinishedDetailsListBindingNavigator.DeleteItem = this.toolStripButton2;
            this.FinishedDetailsListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FinishedDetailsListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.SaveItemtoolStripButton});
            this.FinishedDetailsListBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.FinishedDetailsListBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.FinishedDetailsListBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.FinishedDetailsListBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.FinishedDetailsListBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.FinishedDetailsListBindingNavigator.Name = "FinishedDetailsListBindingNavigator";
            this.FinishedDetailsListBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.FinishedDetailsListBindingNavigator.Size = new System.Drawing.Size(752, 31);
            this.FinishedDetailsListBindingNavigator.TabIndex = 18;
            this.FinishedDetailsListBindingNavigator.Text = "FinishedDetailsListBindingNavigator";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 28);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // SaveItemtoolStripButton
            // 
            this.SaveItemtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveItemtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveItemtoolStripButton.Image")));
            this.SaveItemtoolStripButton.Name = "SaveItemtoolStripButton";
            this.SaveItemtoolStripButton.Size = new System.Drawing.Size(29, 28);
            this.SaveItemtoolStripButton.Text = "Сохранить данные";
            this.SaveItemtoolStripButton.Click += new System.EventHandler(this.SaveItemtoolStripButton_Click);
            // 
            // orderStatusLabel1
            // 
            orderStatusLabel1.AutoSize = true;
            orderStatusLabel1.Location = new System.Drawing.Point(12, 132);
            orderStatusLabel1.Name = "orderStatusLabel1";
            orderStatusLabel1.Size = new System.Drawing.Size(84, 16);
            orderStatusLabel1.TabIndex = 18;
            orderStatusLabel1.Text = "Order Status:";
            // 
            // orderStatusComboBox
            // 
            this.orderStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderStatus", true));
            this.orderStatusComboBox.FormattingEnabled = true;
            this.orderStatusComboBox.Items.AddRange(new object[] {
            "Передан заказчику",
            "Готов",
            "Согласован",
            "В обработке"});
            this.orderStatusComboBox.Location = new System.Drawing.Point(102, 126);
            this.orderStatusComboBox.Name = "orderStatusComboBox";
            this.orderStatusComboBox.Size = new System.Drawing.Size(200, 24);
            this.orderStatusComboBox.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FInishedDetailID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FInishedDetailID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModelID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ModelID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOfManufacture";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата изготовления";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "DetailStatus";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Деталь готова?";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(240, 176);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(105, 31);
            this.CustomerButton.TabIndex = 20;
            this.CustomerButton.Text = "Заказчики";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // FinishedDetailsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(orderStatusLabel1);
            this.Controls.Add(this.orderStatusComboBox);
            this.Controls.Add(this.FinishedDetailsLisyGroupBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(costPriceLabel);
            this.Controls.Add(this.costPriceTextBox);
            this.Controls.Add(plasticLabel);
            this.Controls.Add(this.plasticComboBox);
            this.Controls.Add(profitLabel);
            this.Controls.Add(this.profitTextBox);
            this.Controls.Add(deadlineLabel);
            this.Controls.Add(this.deadlineDateTimePicker);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "FinishedDetailsListForm";
            this.Text = "FinishedDetailsListForm";
            this.Load += new System.EventHandler(this.FinishedDetailsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._3D_PrintingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.FinishedDetailsLisyGroupBox.ResumeLayout(false);
            this.FinishedDetailsLisyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinishedDetailsListBindingNavigator)).EndInit();
            this.FinishedDetailsListBindingNavigator.ResumeLayout(false);
            this.FinishedDetailsListBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _3D_PrintingDataSet _3D_PrintingDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private _3D_PrintingDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private _3D_PrintingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private _3D_PrintingDataSetTableAdapters.FinishedDetailTableAdapter finishedDetailTableAdapter;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox costPriceTextBox;
        private System.Windows.Forms.ComboBox plasticComboBox;
        private System.Windows.Forms.TextBox profitTextBox;
        private System.Windows.Forms.DateTimePicker deadlineDateTimePicker;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.GroupBox FinishedDetailsLisyGroupBox;
        private System.Windows.Forms.BindingSource finishedDetailBindingSource;
        private System.Windows.Forms.DataGridView finishedDetailDataGridView;
        private System.Windows.Forms.BindingNavigator FinishedDetailsListBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SaveItemtoolStripButton;
        private System.Windows.Forms.ComboBox orderStatusComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button CustomerButton;
    }
}
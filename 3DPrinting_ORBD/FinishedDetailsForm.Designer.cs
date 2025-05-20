namespace _3DPrinting_ORBD
{
    partial class FinishedDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinishedDetailsForm));
            this._3D_PrintingDataSet = new _3DPrinting_ORBD._3D_PrintingDataSet();
            this.finishedDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finishedDetailTableAdapter = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.FinishedDetailTableAdapter();
            this.tableAdapterManager = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.TableAdapterManager();
            this.finishedDetailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.finishedDetailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.finishedDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckBoxColumnDetailStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._3D_PrintingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailBindingNavigator)).BeginInit();
            this.finishedDetailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _3D_PrintingDataSet
            // 
            this._3D_PrintingDataSet.DataSetName = "_3D_PrintingDataSet";
            this._3D_PrintingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finishedDetailBindingSource
            // 
            this.finishedDetailBindingSource.DataMember = "FinishedDetail";
            this.finishedDetailBindingSource.DataSource = this._3D_PrintingDataSet;
            // 
            // finishedDetailTableAdapter
            // 
            this.finishedDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._3DModelTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FinishedDetailTableAdapter = this.finishedDetailTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // finishedDetailBindingNavigator
            // 
            this.finishedDetailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.finishedDetailBindingNavigator.BindingSource = this.finishedDetailBindingSource;
            this.finishedDetailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.finishedDetailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.finishedDetailBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.finishedDetailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.finishedDetailBindingNavigatorSaveItem});
            this.finishedDetailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.finishedDetailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.finishedDetailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.finishedDetailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.finishedDetailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.finishedDetailBindingNavigator.Name = "finishedDetailBindingNavigator";
            this.finishedDetailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.finishedDetailBindingNavigator.Size = new System.Drawing.Size(749, 31);
            this.finishedDetailBindingNavigator.TabIndex = 0;
            this.finishedDetailBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // finishedDetailBindingNavigatorSaveItem
            // 
            this.finishedDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.finishedDetailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("finishedDetailBindingNavigatorSaveItem.Image")));
            this.finishedDetailBindingNavigatorSaveItem.Name = "finishedDetailBindingNavigatorSaveItem";
            this.finishedDetailBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.finishedDetailBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.finishedDetailBindingNavigatorSaveItem.Click += new System.EventHandler(this.finishedDetailBindingNavigatorSaveItem_Click);
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
            this.DataGridViewCheckBoxColumnDetailStatus});
            this.finishedDetailDataGridView.DataSource = this.finishedDetailBindingSource;
            this.finishedDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finishedDetailDataGridView.Location = new System.Drawing.Point(0, 31);
            this.finishedDetailDataGridView.Name = "finishedDetailDataGridView";
            this.finishedDetailDataGridView.RowHeadersWidth = 51;
            this.finishedDetailDataGridView.Size = new System.Drawing.Size(749, 302);
            this.finishedDetailDataGridView.TabIndex = 1;
            this.finishedDetailDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.finishedDetailDataGridView_CellFormatting);
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
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата изготовления";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // DataGridViewCheckBoxColumnDetailStatus
            // 
            this.DataGridViewCheckBoxColumnDetailStatus.DataPropertyName = "DetailStatus";
            this.DataGridViewCheckBoxColumnDetailStatus.HeaderText = "Деталь готова";
            this.DataGridViewCheckBoxColumnDetailStatus.MinimumWidth = 6;
            this.DataGridViewCheckBoxColumnDetailStatus.Name = "DataGridViewCheckBoxColumnDetailStatus";
            this.DataGridViewCheckBoxColumnDetailStatus.Width = 125;
            // 
            // FinishedDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 333);
            this.Controls.Add(this.finishedDetailDataGridView);
            this.Controls.Add(this.finishedDetailBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinishedDetailsForm";
            this.Text = "Напечатанные детали";
            this.Load += new System.EventHandler(this.FinishedDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._3D_PrintingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailBindingNavigator)).EndInit();
            this.finishedDetailBindingNavigator.ResumeLayout(false);
            this.finishedDetailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finishedDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _3D_PrintingDataSet _3D_PrintingDataSet;
        private System.Windows.Forms.BindingSource finishedDetailBindingSource;
        private _3D_PrintingDataSetTableAdapters.FinishedDetailTableAdapter finishedDetailTableAdapter;
        private _3D_PrintingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator finishedDetailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton finishedDetailBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView finishedDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumnDetailStatus;
    }
}
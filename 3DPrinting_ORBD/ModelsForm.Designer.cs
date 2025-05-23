﻿namespace _3DPrinting_ORBD
{
    partial class ModelsForm
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
            System.Windows.Forms.Label modelIDLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label sreenshotLabel;
            System.Windows.Forms.Label dimensionsLabel;
            System.Windows.Forms.Label fileFormatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelsForm));
            this._3D_PrintingDataSet = new _3DPrinting_ORBD._3D_PrintingDataSet();
            this._3DModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3DModelTableAdapter = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters._3DModelTableAdapter();
            this.tableAdapterManager = new _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.TableAdapterManager();
            this._3DModelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modelIDTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.dimensionsTextBox = new System.Windows.Forms.TextBox();
            this.fileFormatTextBox = new System.Windows.Forms.TextBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.sreenshotPictureBox = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this._3DModelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            modelIDLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            sreenshotLabel = new System.Windows.Forms.Label();
            dimensionsLabel = new System.Windows.Forms.Label();
            fileFormatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._3D_PrintingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3DModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3DModelBindingNavigator)).BeginInit();
            this._3DModelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sreenshotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modelIDLabel
            // 
            modelIDLabel.AutoSize = true;
            modelIDLabel.Location = new System.Drawing.Point(34, 56);
            modelIDLabel.Name = "modelIDLabel";
            modelIDLabel.Size = new System.Drawing.Size(53, 13);
            modelIDLabel.TabIndex = 1;
            modelIDLabel.Text = "Model ID:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(37, 92);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 3;
            orderIDLabel.Text = "Order ID:";
            // 
            // sreenshotLabel
            // 
            sreenshotLabel.AutoSize = true;
            sreenshotLabel.Location = new System.Drawing.Point(306, 25);
            sreenshotLabel.Name = "sreenshotLabel";
            sreenshotLabel.Size = new System.Drawing.Size(98, 13);
            sreenshotLabel.TabIndex = 5;
            sreenshotLabel.Text = "Скриншот модели";
            // 
            // dimensionsLabel
            // 
            dimensionsLabel.AutoSize = true;
            dimensionsLabel.Location = new System.Drawing.Point(42, 174);
            dimensionsLabel.Name = "dimensionsLabel";
            dimensionsLabel.Size = new System.Drawing.Size(57, 13);
            dimensionsLabel.TabIndex = 7;
            dimensionsLabel.Text = "Размеры:";
            // 
            // fileFormatLabel
            // 
            fileFormatLabel.AutoSize = true;
            fileFormatLabel.Location = new System.Drawing.Point(12, 134);
            fileFormatLabel.Name = "fileFormatLabel";
            fileFormatLabel.Size = new System.Drawing.Size(87, 13);
            fileFormatLabel.TabIndex = 9;
            fileFormatLabel.Text = "Формат файла:";
            // 
            // _3D_PrintingDataSet
            // 
            this._3D_PrintingDataSet.DataSetName = "_3D_PrintingDataSet";
            this._3D_PrintingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _3DModelBindingSource
            // 
            this._3DModelBindingSource.DataMember = "3DModel";
            this._3DModelBindingSource.DataSource = this._3D_PrintingDataSet;
            // 
            // _3DModelTableAdapter
            // 
            this._3DModelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._3DModelTableAdapter = this._3DModelTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FinishedDetailTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3DPrinting_ORBD._3D_PrintingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _3DModelBindingNavigator
            // 
            this._3DModelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this._3DModelBindingNavigator.BindingSource = this._3DModelBindingSource;
            this._3DModelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this._3DModelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._3DModelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this._3DModelBindingNavigatorSaveItem});
            this._3DModelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this._3DModelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._3DModelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._3DModelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._3DModelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._3DModelBindingNavigator.Name = "_3DModelBindingNavigator";
            this._3DModelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._3DModelBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this._3DModelBindingNavigator.TabIndex = 0;
            this._3DModelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // modelIDTextBox
            // 
            this.modelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._3DModelBindingSource, "ModelID", true));
            this.modelIDTextBox.Location = new System.Drawing.Point(107, 53);
            this.modelIDTextBox.Name = "modelIDTextBox";
            this.modelIDTextBox.Size = new System.Drawing.Size(72, 20);
            this.modelIDTextBox.TabIndex = 2;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._3DModelBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(107, 89);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(72, 20);
            this.orderIDTextBox.TabIndex = 4;
            // 
            // dimensionsTextBox
            // 
            this.dimensionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._3DModelBindingSource, "Dimensions", true));
            this.dimensionsTextBox.Location = new System.Drawing.Point(107, 174);
            this.dimensionsTextBox.Multiline = true;
            this.dimensionsTextBox.Name = "dimensionsTextBox";
            this.dimensionsTextBox.Size = new System.Drawing.Size(153, 59);
            this.dimensionsTextBox.TabIndex = 8;
            // 
            // fileFormatTextBox
            // 
            this.fileFormatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._3DModelBindingSource, "FileFormat", true));
            this.fileFormatTextBox.Location = new System.Drawing.Point(107, 127);
            this.fileFormatTextBox.Name = "fileFormatTextBox";
            this.fileFormatTextBox.Size = new System.Drawing.Size(72, 20);
            this.fileFormatTextBox.TabIndex = 10;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(441, 239);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(105, 26);
            this.buttonOpenPhoto.TabIndex = 11;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // sreenshotPictureBox
            // 
            this.sreenshotPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this._3DModelBindingSource, "Sreenshot", true));
            this.sreenshotPictureBox.Location = new System.Drawing.Point(309, 56);
            this.sreenshotPictureBox.Name = "sreenshotPictureBox";
            this.sreenshotPictureBox.Size = new System.Drawing.Size(237, 177);
            this.sreenshotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sreenshotPictureBox.TabIndex = 6;
            this.sreenshotPictureBox.TabStop = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // _3DModelBindingNavigatorSaveItem
            // 
            this._3DModelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._3DModelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_3DModelBindingNavigatorSaveItem.Image")));
            this._3DModelBindingNavigatorSaveItem.Name = "_3DModelBindingNavigatorSaveItem";
            this._3DModelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this._3DModelBindingNavigatorSaveItem.Text = "Сохранить данные";
            this._3DModelBindingNavigatorSaveItem.Click += new System.EventHandler(this._3DModelBindingNavigatorSaveItem_Click);
            // 
            // ModelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 291);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(modelIDLabel);
            this.Controls.Add(this.modelIDTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(sreenshotLabel);
            this.Controls.Add(this.sreenshotPictureBox);
            this.Controls.Add(dimensionsLabel);
            this.Controls.Add(this.dimensionsTextBox);
            this.Controls.Add(fileFormatLabel);
            this.Controls.Add(this.fileFormatTextBox);
            this.Controls.Add(this._3DModelBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModelsForm";
            this.Text = "3D-модели";
            this.Load += new System.EventHandler(this.ModelsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._3D_PrintingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3DModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3DModelBindingNavigator)).EndInit();
            this._3DModelBindingNavigator.ResumeLayout(false);
            this._3DModelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sreenshotPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _3D_PrintingDataSet _3D_PrintingDataSet;
        private System.Windows.Forms.BindingSource _3DModelBindingSource;
        private _3D_PrintingDataSetTableAdapters._3DModelTableAdapter _3DModelTableAdapter;
        private _3D_PrintingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator _3DModelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton _3DModelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox modelIDTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.PictureBox sreenshotPictureBox;
        private System.Windows.Forms.TextBox dimensionsTextBox;
        private System.Windows.Forms.TextBox fileFormatTextBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomers = new System.Windows.Forms.RadioButton();
            this.radioButtonOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonFinishedDetails = new System.Windows.Forms.RadioButton();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // radioButtonCustomers
            // 
            this.radioButtonCustomers.AutoSize = true;
            this.radioButtonCustomers.Location = new System.Drawing.Point(6, 21);
            this.radioButtonCustomers.Name = "radioButtonCustomers";
            this.radioButtonCustomers.Size = new System.Drawing.Size(96, 20);
            this.radioButtonCustomers.TabIndex = 0;
            this.radioButtonCustomers.TabStop = true;
            this.radioButtonCustomers.Text = "Заказчики";
            this.radioButtonCustomers.UseVisualStyleBackColor = true;
            this.radioButtonCustomers.CheckedChanged += new System.EventHandler(this.radioButtonCustomers_CheckedChanged);
            // 
            // radioButtonOrders
            // 
            this.radioButtonOrders.AutoSize = true;
            this.radioButtonOrders.Location = new System.Drawing.Point(162, 21);
            this.radioButtonOrders.Name = "radioButtonOrders";
            this.radioButtonOrders.Size = new System.Drawing.Size(74, 20);
            this.radioButtonOrders.TabIndex = 1;
            this.radioButtonOrders.TabStop = true;
            this.radioButtonOrders.Text = "Заказы";
            this.radioButtonOrders.UseVisualStyleBackColor = true;
            this.radioButtonOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // radioButtonFinishedDetails
            // 
            this.radioButtonFinishedDetails.AutoSize = true;
            this.radioButtonFinishedDetails.Location = new System.Drawing.Point(311, 21);
            this.radioButtonFinishedDetails.Name = "radioButtonFinishedDetails";
            this.radioButtonFinishedDetails.Size = new System.Drawing.Size(130, 20);
            this.radioButtonFinishedDetails.TabIndex = 2;
            this.radioButtonFinishedDetails.TabStop = true;
            this.radioButtonFinishedDetails.Text = "Готовые детали";
            this.radioButtonFinishedDetails.UseVisualStyleBackColor = true;
            this.radioButtonFinishedDetails.CheckedChanged += new System.EventHandler(this.radioButtonFinishedDetails_CheckedChanged);
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
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonFinishedDetails;
        private System.Windows.Forms.RadioButton radioButtonOrders;
        private System.Windows.Forms.RadioButton radioButtonCustomers;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
    }
}
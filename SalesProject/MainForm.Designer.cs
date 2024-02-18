namespace SalesProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductLinkLabel = new System.Windows.Forms.LinkLabel();
            this.storeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.storeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.productRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.infoDataGridView2 = new System.Windows.Forms.DataGridView();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waremark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumTotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgDaily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDataGridView
            // 
            this.infoDataGridView.AllowUserToAddRows = false;
            this.infoDataGridView.AllowUserToDeleteRows = false;
            this.infoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreName,
            this.Waremark,
            this.ProductName,
            this.SumTotalCount,
            this.AvgDaily});
            this.infoDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataGridView.Location = new System.Drawing.Point(251, 42);
            this.infoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.infoDataGridView.Name = "infoDataGridView";
            this.infoDataGridView.ReadOnly = true;
            this.infoDataGridView.RowHeadersVisible = false;
            this.infoDataGridView.Size = new System.Drawing.Size(966, 307);
            this.infoDataGridView.TabIndex = 0;
            // 
            // ProductLinkLabel
            // 
            this.ProductLinkLabel.AutoSize = true;
            this.ProductLinkLabel.DisabledLinkColor = System.Drawing.Color.Black;
            this.ProductLinkLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ProductLinkLabel.Location = new System.Drawing.Point(15, 333);
            this.ProductLinkLabel.Name = "ProductLinkLabel";
            this.ProductLinkLabel.Size = new System.Drawing.Size(115, 16);
            this.ProductLinkLabel.TabIndex = 3;
            this.ProductLinkLabel.TabStop = true;
            this.ProductLinkLabel.Text = "Выбрать товары";
            this.ProductLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProductLinkLabel_LinkClicked);
            // 
            // storeLinkLabel
            // 
            this.storeLinkLabel.AutoSize = true;
            this.storeLinkLabel.DisabledLinkColor = System.Drawing.Color.Black;
            this.storeLinkLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storeLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.storeLinkLabel.Location = new System.Drawing.Point(15, 189);
            this.storeLinkLabel.Name = "storeLinkLabel";
            this.storeLinkLabel.Size = new System.Drawing.Size(130, 16);
            this.storeLinkLabel.TabIndex = 4;
            this.storeLinkLabel.TabStop = true;
            this.storeLinkLabel.Text = "Выбрать магазины";
            this.storeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StoreLinkLabel_LinkClicked);
            // 
            // storeRichTextBox
            // 
            this.storeRichTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.storeRichTextBox.Location = new System.Drawing.Point(18, 208);
            this.storeRichTextBox.Name = "storeRichTextBox";
            this.storeRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.storeRichTextBox.Size = new System.Drawing.Size(204, 122);
            this.storeRichTextBox.TabIndex = 5;
            this.storeRichTextBox.Text = "";
            this.storeRichTextBox.Visible = false;
            // 
            // productRichTextBox
            // 
            this.productRichTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.productRichTextBox.Location = new System.Drawing.Point(18, 352);
            this.productRichTextBox.Name = "productRichTextBox";
            this.productRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.productRichTextBox.Size = new System.Drawing.Size(204, 122);
            this.productRichTextBox.TabIndex = 6;
            this.productRichTextBox.Text = "";
            this.productRichTextBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // infoDataGridView2
            // 
            this.infoDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoDataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.infoDataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoDataGridView2.Location = new System.Drawing.Point(251, 374);
            this.infoDataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.infoDataGridView2.Name = "infoDataGridView2";
            this.infoDataGridView2.ReadOnly = true;
            this.infoDataGridView2.RowHeadersVisible = false;
            this.infoDataGridView2.Size = new System.Drawing.Size(966, 182);
            this.infoDataGridView2.TabIndex = 9;
            // 
            // StoreName
            // 
            this.StoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "Магазин";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 88;
            // 
            // Waremark
            // 
            this.Waremark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Waremark.DataPropertyName = "Waremark";
            this.Waremark.HeaderText = "Код товара";
            this.Waremark.Name = "Waremark";
            this.Waremark.ReadOnly = true;
            this.Waremark.Width = 108;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Наименование";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // SumTotalCount
            // 
            this.SumTotalCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SumTotalCount.DataPropertyName = "SumTotalCount";
            this.SumTotalCount.HeaderText = "Кол-во товара";
            this.SumTotalCount.Name = "SumTotalCount";
            this.SumTotalCount.ReadOnly = true;
            this.SumTotalCount.Width = 120;
            // 
            // AvgDaily
            // 
            this.AvgDaily.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AvgDaily.DataPropertyName = "AvgDaily";
            this.AvgDaily.HeaderText = "СрСутка";
            this.AvgDaily.Name = "AvgDaily";
            this.AvgDaily.ReadOnly = true;
            this.AvgDaily.Width = 89;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Waremark";
            this.Column1.HeaderText = "Код товара";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 108;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "SumTotalCount";
            this.Column3.HeaderText = "Кол-во товара";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "AvgDaily";
            this.Column4.HeaderText = "СрСутка";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(248, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Таблица 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(248, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Таблица 2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1230, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoDataGridView2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productRichTextBox);
            this.Controls.Add(this.storeRichTextBox);
            this.Controls.Add(this.storeLinkLabel);
            this.Controls.Add(this.ProductLinkLabel);
            this.Controls.Add(this.infoDataGridView);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1246, 614);
            this.MinimumSize = new System.Drawing.Size(1246, 614);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDataGridView;
        private System.Windows.Forms.LinkLabel ProductLinkLabel;
        private System.Windows.Forms.LinkLabel storeLinkLabel;
        private System.Windows.Forms.RichTextBox storeRichTextBox;
        private System.Windows.Forms.RichTextBox productRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView infoDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waremark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgDaily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace ApplicationsAndContracts.Views
{
    partial class ApplicationAddingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.currentRecordNumberValueLabel = new System.Windows.Forms.Label();
            this.currentRecordNumberLabel = new System.Windows.Forms.Label();
            this.recordCountValuelabel = new System.Windows.Forms.Label();
            this.recordCountLabel = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAliasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetSinceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetBeforeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.applicationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.applicationDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dceGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dceDataGridView = new System.Windows.Forms.DataGridView();
            this.DceNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DceAliasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gkLabel1 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.recordCountLabel1 = new System.Windows.Forms.Label();
            this.recordCountValueLabel1 = new System.Windows.Forms.Label();
            this.currentRecordNumberLabel1 = new System.Windows.Forms.Label();
            this.currentRecordNumberValueLabel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.changeDceButton = new System.Windows.Forms.Button();
            this.deleteDceButton = new System.Windows.Forms.Button();
            this.userModifyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.userModifyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userModifyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userDepartmentToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userDepartmentValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.phoneNumber1ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.phoneNumber1ValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.phoneNumber2ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.phoneNumber2ValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.faxNumberToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.faxNumberValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.productsGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.applicationGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.dceGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dceDataGridView)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.userModifyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.userModifyStatusStrip, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dceGroupBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.productsGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.applicationGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.29608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.35196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.35196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // productsGroupBox
            // 
            this.productsGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.productsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGroupBox.Location = new System.Drawing.Point(3, 254);
            this.productsGroupBox.Name = "productsGroupBox";
            this.productsGroupBox.Size = new System.Drawing.Size(1002, 179);
            this.productsGroupBox.TabIndex = 4;
            this.productsGroupBox.TabStop = false;
            this.productsGroupBox.Text = "Изделия";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.currentRecordNumberValueLabel, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.currentRecordNumberLabel, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.recordCountValuelabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.recordCountLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.productsDataGridView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel2, 5, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(996, 160);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // currentRecordNumberValueLabel
            // 
            this.currentRecordNumberValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentRecordNumberValueLabel.AutoSize = true;
            this.currentRecordNumberValueLabel.Location = new System.Drawing.Point(298, 136);
            this.currentRecordNumberValueLabel.Name = "currentRecordNumberValueLabel";
            this.currentRecordNumberValueLabel.Size = new System.Drawing.Size(13, 13);
            this.currentRecordNumberValueLabel.TabIndex = 9;
            this.currentRecordNumberValueLabel.Text = "0";
            // 
            // currentRecordNumberLabel
            // 
            this.currentRecordNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentRecordNumberLabel.AutoSize = true;
            this.currentRecordNumberLabel.Location = new System.Drawing.Point(163, 136);
            this.currentRecordNumberLabel.Name = "currentRecordNumberLabel";
            this.currentRecordNumberLabel.Size = new System.Drawing.Size(129, 13);
            this.currentRecordNumberLabel.TabIndex = 8;
            this.currentRecordNumberLabel.Text = "Номер текущей записи:";
            // 
            // recordCountValuelabel
            // 
            this.recordCountValuelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recordCountValuelabel.AutoSize = true;
            this.recordCountValuelabel.Location = new System.Drawing.Point(123, 136);
            this.recordCountValuelabel.Name = "recordCountValuelabel";
            this.recordCountValuelabel.Size = new System.Drawing.Size(13, 13);
            this.recordCountValuelabel.TabIndex = 7;
            this.recordCountValuelabel.Text = "0";
            // 
            // recordCountLabel
            // 
            this.recordCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recordCountLabel.AutoSize = true;
            this.recordCountLabel.Location = new System.Drawing.Point(3, 136);
            this.recordCountLabel.Name = "recordCountLabel";
            this.recordCountLabel.Size = new System.Drawing.Size(114, 13);
            this.recordCountLabel.TabIndex = 5;
            this.recordCountLabel.Text = "Количество записей:";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderColumn,
            this.ProductNumberColumn,
            this.ProductIndexColumn,
            this.ProductAliasColumn,
            this.SetSinceColumn,
            this.SetBeforeColumn});
            this.tableLayoutPanel4.SetColumnSpan(this.productsDataGridView, 6);
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.Size = new System.Drawing.Size(990, 120);
            this.productsDataGridView.TabIndex = 2;
            // 
            // OrderColumn
            // 
            this.OrderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderColumn.DataPropertyName = "Order";
            this.OrderColumn.FillWeight = 70F;
            this.OrderColumn.HeaderText = "Заказ";
            this.OrderColumn.Name = "OrderColumn";
            this.OrderColumn.ReadOnly = true;
            // 
            // ProductNumberColumn
            // 
            this.ProductNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNumberColumn.DataPropertyName = "ProductNumber";
            this.ProductNumberColumn.HeaderText = "№ Изделия";
            this.ProductNumberColumn.Name = "ProductNumberColumn";
            this.ProductNumberColumn.ReadOnly = true;
            // 
            // ProductIndexColumn
            // 
            this.ProductIndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductIndexColumn.DataPropertyName = "ProductIndex";
            this.ProductIndexColumn.HeaderText = "Индекс изделия";
            this.ProductIndexColumn.Name = "ProductIndexColumn";
            this.ProductIndexColumn.ReadOnly = true;
            // 
            // ProductAliasColumn
            // 
            this.ProductAliasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductAliasColumn.DataPropertyName = "ProductAlias";
            this.ProductAliasColumn.HeaderText = "Обозначение изделия";
            this.ProductAliasColumn.Name = "ProductAliasColumn";
            this.ProductAliasColumn.ReadOnly = true;
            // 
            // SetSinceColumn
            // 
            this.SetSinceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SetSinceColumn.DataPropertyName = "SetSince";
            this.SetSinceColumn.FillWeight = 70F;
            this.SetSinceColumn.HeaderText = "Комплект С";
            this.SetSinceColumn.Name = "SetSinceColumn";
            this.SetSinceColumn.ReadOnly = true;
            // 
            // SetBeforeColumn
            // 
            this.SetBeforeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SetBeforeColumn.DataPropertyName = "SetBefore";
            this.SetBeforeColumn.FillWeight = 70F;
            this.SetBeforeColumn.HeaderText = "Комплект ПО";
            this.SetBeforeColumn.Name = "SetBeforeColumn";
            this.SetBeforeColumn.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.deleteButton);
            this.flowLayoutPanel2.Controls.Add(this.addButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(730, 129);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(263, 28);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(185, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(104, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // applicationGroupBox
            // 
            this.applicationGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.applicationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.applicationGroupBox.Name = "applicationGroupBox";
            this.applicationGroupBox.Size = new System.Drawing.Size(361, 60);
            this.applicationGroupBox.TabIndex = 0;
            this.applicationGroupBox.TabStop = false;
            this.applicationGroupBox.Text = "Реквизиты заявки";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.applicationNumberLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.applicationDateLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.departmentLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // applicationNumberLabel
            // 
            this.applicationNumberLabel.AutoSize = true;
            this.applicationNumberLabel.Location = new System.Drawing.Point(3, 0);
            this.applicationNumberLabel.Name = "applicationNumberLabel";
            this.applicationNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.applicationNumberLabel.TabIndex = 0;
            this.applicationNumberLabel.Text = "Номер заявки";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 3;
            // 
            // applicationDateLabel
            // 
            this.applicationDateLabel.AutoSize = true;
            this.applicationDateLabel.Location = new System.Drawing.Point(127, 0);
            this.applicationDateLabel.Name = "applicationDateLabel";
            this.applicationDateLabel.Size = new System.Drawing.Size(72, 13);
            this.applicationDateLabel.TabIndex = 1;
            this.applicationDateLabel.Text = "Дата заявки";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(251, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(38, 13);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Отдел";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поставщик";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox8, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox9, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 3, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(996, 101);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(252, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(501, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(750, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(3, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(243, 20);
            this.textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(252, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(243, 20);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(501, 78);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(243, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(750, 78);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(243, 20);
            this.textBox9.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Код организации";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер договора";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата договора";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Новый договор";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ГК";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Исполнитель";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Контактные данные";
            // 
            // dceGroupBox
            // 
            this.dceGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.dceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dceGroupBox.Location = new System.Drawing.Point(3, 439);
            this.dceGroupBox.Name = "dceGroupBox";
            this.dceGroupBox.Size = new System.Drawing.Size(1002, 179);
            this.dceGroupBox.TabIndex = 5;
            this.dceGroupBox.TabStop = false;
            this.dceGroupBox.Text = "ДСЕ";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.dceDataGridView, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.gkLabel1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.colorPanel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.recordCountLabel1, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.recordCountValueLabel1, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.currentRecordNumberLabel1, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.currentRecordNumberValueLabel1, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 7, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(996, 160);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // dceDataGridView
            // 
            this.dceDataGridView.AllowUserToAddRows = false;
            this.dceDataGridView.AllowUserToDeleteRows = false;
            this.dceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DceNumberColumn,
            this.DceAliasColumn,
            this.DceNameColumn,
            this.OrderedCountColumn});
            this.tableLayoutPanel5.SetColumnSpan(this.dceDataGridView, 8);
            this.dceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dceDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dceDataGridView.Name = "dceDataGridView";
            this.dceDataGridView.ReadOnly = true;
            this.dceDataGridView.RowHeadersVisible = false;
            this.dceDataGridView.Size = new System.Drawing.Size(990, 120);
            this.dceDataGridView.TabIndex = 1;
            // 
            // DceNumberColumn
            // 
            this.DceNumberColumn.DataPropertyName = "DceNumber";
            this.DceNumberColumn.HeaderText = "№ ДСЕ";
            this.DceNumberColumn.Name = "DceNumberColumn";
            this.DceNumberColumn.ReadOnly = true;
            // 
            // DceAliasColumn
            // 
            this.DceAliasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DceAliasColumn.DataPropertyName = "DceAlias";
            this.DceAliasColumn.FillWeight = 70F;
            this.DceAliasColumn.HeaderText = "Обозначение ДСЕ";
            this.DceAliasColumn.Name = "DceAliasColumn";
            this.DceAliasColumn.ReadOnly = true;
            // 
            // DceNameColumn
            // 
            this.DceNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DceNameColumn.DataPropertyName = "DceName";
            this.DceNameColumn.HeaderText = "Наименование ДСЕ";
            this.DceNameColumn.Name = "DceNameColumn";
            this.DceNameColumn.ReadOnly = true;
            // 
            // OrderedCountColumn
            // 
            this.OrderedCountColumn.DataPropertyName = "OrderedCount";
            this.OrderedCountColumn.HeaderText = "Количество заказано";
            this.OrderedCountColumn.Name = "OrderedCountColumn";
            this.OrderedCountColumn.ReadOnly = true;
            this.OrderedCountColumn.Width = 140;
            // 
            // gkLabel1
            // 
            this.gkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gkLabel1.AutoSize = true;
            this.gkLabel1.Location = new System.Drawing.Point(49, 136);
            this.gkLabel1.Name = "gkLabel1";
            this.gkLabel1.Size = new System.Drawing.Size(97, 13);
            this.gkLabel1.TabIndex = 4;
            this.gkLabel1.Text = "Позиция закрыта";
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.colorPanel.BackColor = System.Drawing.Color.LightCyan;
            this.colorPanel.Location = new System.Drawing.Point(3, 133);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(40, 20);
            this.colorPanel.TabIndex = 2;
            // 
            // recordCountLabel1
            // 
            this.recordCountLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recordCountLabel1.AutoSize = true;
            this.recordCountLabel1.Location = new System.Drawing.Point(189, 136);
            this.recordCountLabel1.Name = "recordCountLabel1";
            this.recordCountLabel1.Size = new System.Drawing.Size(114, 13);
            this.recordCountLabel1.TabIndex = 5;
            this.recordCountLabel1.Text = "Количество записей:";
            // 
            // recordCountValueLabel1
            // 
            this.recordCountValueLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recordCountValueLabel1.AutoSize = true;
            this.recordCountValueLabel1.Location = new System.Drawing.Point(309, 136);
            this.recordCountValueLabel1.Name = "recordCountValueLabel1";
            this.recordCountValueLabel1.Size = new System.Drawing.Size(13, 13);
            this.recordCountValueLabel1.TabIndex = 7;
            this.recordCountValueLabel1.Text = "0";
            // 
            // currentRecordNumberLabel1
            // 
            this.currentRecordNumberLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentRecordNumberLabel1.AutoSize = true;
            this.currentRecordNumberLabel1.Location = new System.Drawing.Point(349, 136);
            this.currentRecordNumberLabel1.Name = "currentRecordNumberLabel1";
            this.currentRecordNumberLabel1.Size = new System.Drawing.Size(129, 13);
            this.currentRecordNumberLabel1.TabIndex = 8;
            this.currentRecordNumberLabel1.Text = "Номер текущей записи:";
            // 
            // currentRecordNumberValueLabel1
            // 
            this.currentRecordNumberValueLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.currentRecordNumberValueLabel1.AutoSize = true;
            this.currentRecordNumberValueLabel1.Location = new System.Drawing.Point(484, 136);
            this.currentRecordNumberValueLabel1.Name = "currentRecordNumberValueLabel1";
            this.currentRecordNumberValueLabel1.Size = new System.Drawing.Size(13, 13);
            this.currentRecordNumberValueLabel1.TabIndex = 9;
            this.currentRecordNumberValueLabel1.Text = "0";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.changeDceButton);
            this.flowLayoutPanel3.Controls.Add(this.deleteDceButton);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(806, 129);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(187, 28);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // changeDceButton
            // 
            this.changeDceButton.Location = new System.Drawing.Point(109, 3);
            this.changeDceButton.Name = "changeDceButton";
            this.changeDceButton.Size = new System.Drawing.Size(75, 23);
            this.changeDceButton.TabIndex = 0;
            this.changeDceButton.Text = "Изменить";
            this.changeDceButton.UseVisualStyleBackColor = true;
            // 
            // deleteDceButton
            // 
            this.deleteDceButton.Location = new System.Drawing.Point(28, 3);
            this.deleteDceButton.Name = "deleteDceButton";
            this.deleteDceButton.Size = new System.Drawing.Size(75, 23);
            this.deleteDceButton.TabIndex = 1;
            this.deleteDceButton.Text = "Удалить";
            this.deleteDceButton.UseVisualStyleBackColor = true;
            // 
            // userModifyStatusStrip
            // 
            this.userModifyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userModifyToolStripStatusLabel,
            this.userModifyValueToolStripStatusLabel,
            this.userDepartmentToolStripStatusLabel,
            this.userDepartmentValueToolStripStatusLabel,
            this.phoneNumber1ToolStripStatusLabel,
            this.phoneNumber1ValueToolStripStatusLabel,
            this.phoneNumber2ToolStripStatusLabel,
            this.phoneNumber2ValueToolStripStatusLabel,
            this.faxNumberToolStripStatusLabel,
            this.faxNumberValueToolStripStatusLabel});
            this.userModifyStatusStrip.Location = new System.Drawing.Point(0, 638);
            this.userModifyStatusStrip.Name = "userModifyStatusStrip";
            this.userModifyStatusStrip.Size = new System.Drawing.Size(1008, 24);
            this.userModifyStatusStrip.TabIndex = 6;
            this.userModifyStatusStrip.Text = "statusStrip1";
            // 
            // userModifyToolStripStatusLabel
            // 
            this.userModifyToolStripStatusLabel.Name = "userModifyToolStripStatusLabel";
            this.userModifyToolStripStatusLabel.Size = new System.Drawing.Size(130, 19);
            this.userModifyToolStripStatusLabel.Text = "Автор корректировки:";
            // 
            // userModifyValueToolStripStatusLabel
            // 
            this.userModifyValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.userModifyValueToolStripStatusLabel.Name = "userModifyValueToolStripStatusLabel";
            this.userModifyValueToolStripStatusLabel.Size = new System.Drawing.Size(116, 19);
            this.userModifyValueToolStripStatusLabel.Text = "####_Surname A.A.";
            // 
            // userDepartmentToolStripStatusLabel
            // 
            this.userDepartmentToolStripStatusLabel.Name = "userDepartmentToolStripStatusLabel";
            this.userDepartmentToolStripStatusLabel.Size = new System.Drawing.Size(43, 19);
            this.userDepartmentToolStripStatusLabel.Text = "Отдел:";
            // 
            // userDepartmentValueToolStripStatusLabel
            // 
            this.userDepartmentValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.userDepartmentValueToolStripStatusLabel.Name = "userDepartmentValueToolStripStatusLabel";
            this.userDepartmentValueToolStripStatusLabel.Size = new System.Drawing.Size(39, 19);
            this.userDepartmentValueToolStripStatusLabel.Text = "####";
            // 
            // phoneNumber1ToolStripStatusLabel
            // 
            this.phoneNumber1ToolStripStatusLabel.Name = "phoneNumber1ToolStripStatusLabel";
            this.phoneNumber1ToolStripStatusLabel.Size = new System.Drawing.Size(65, 19);
            this.phoneNumber1ToolStripStatusLabel.Text = "Телефон1:";
            // 
            // phoneNumber1ValueToolStripStatusLabel
            // 
            this.phoneNumber1ValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.phoneNumber1ValueToolStripStatusLabel.Name = "phoneNumber1ValueToolStripStatusLabel";
            this.phoneNumber1ValueToolStripStatusLabel.Size = new System.Drawing.Size(60, 19);
            this.phoneNumber1ValueToolStripStatusLabel.Text = "#######";
            // 
            // phoneNumber2ToolStripStatusLabel
            // 
            this.phoneNumber2ToolStripStatusLabel.Name = "phoneNumber2ToolStripStatusLabel";
            this.phoneNumber2ToolStripStatusLabel.Size = new System.Drawing.Size(65, 19);
            this.phoneNumber2ToolStripStatusLabel.Text = "Телефон2:";
            // 
            // phoneNumber2ValueToolStripStatusLabel
            // 
            this.phoneNumber2ValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.phoneNumber2ValueToolStripStatusLabel.Name = "phoneNumber2ValueToolStripStatusLabel";
            this.phoneNumber2ValueToolStripStatusLabel.Size = new System.Drawing.Size(60, 19);
            this.phoneNumber2ValueToolStripStatusLabel.Text = "#######";
            // 
            // faxNumberToolStripStatusLabel
            // 
            this.faxNumberToolStripStatusLabel.Name = "faxNumberToolStripStatusLabel";
            this.faxNumberToolStripStatusLabel.Size = new System.Drawing.Size(37, 19);
            this.faxNumberToolStripStatusLabel.Text = "Факс:";
            // 
            // faxNumberValueToolStripStatusLabel
            // 
            this.faxNumberValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.faxNumberValueToolStripStatusLabel.Name = "faxNumberValueToolStripStatusLabel";
            this.faxNumberValueToolStripStatusLabel.Size = new System.Drawing.Size(60, 19);
            this.faxNumberValueToolStripStatusLabel.Text = "#######";
            // 
            // ApplicationAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ApplicationAddingForm";
            this.Text = "Добавление заявки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.productsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.applicationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.dceGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dceDataGridView)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.userModifyStatusStrip.ResumeLayout(false);
            this.userModifyStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox applicationGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label applicationNumberLabel;
        private System.Windows.Forms.Label applicationDateLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox productsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label currentRecordNumberValueLabel;
        private System.Windows.Forms.Label currentRecordNumberLabel;
        private System.Windows.Forms.Label recordCountValuelabel;
        private System.Windows.Forms.Label recordCountLabel;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAliasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetSinceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetBeforeColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox dceGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DceNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DceAliasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DceNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedCountColumn;
        private System.Windows.Forms.Label gkLabel1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label recordCountLabel1;
        private System.Windows.Forms.Label recordCountValueLabel1;
        private System.Windows.Forms.Label currentRecordNumberLabel1;
        private System.Windows.Forms.Label currentRecordNumberValueLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button changeDceButton;
        private System.Windows.Forms.Button deleteDceButton;
        private System.Windows.Forms.StatusStrip userModifyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel userModifyToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userModifyValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userDepartmentToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userDepartmentValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel phoneNumber1ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel phoneNumber1ValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel phoneNumber2ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel phoneNumber2ValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel faxNumberToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel faxNumberValueToolStripStatusLabel;
    }
}
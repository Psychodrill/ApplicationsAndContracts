namespace ApplicationsAndContracts
{
    partial class MainForm
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
            this.supplyGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierNameTextBox = new System.Windows.Forms.TextBox();
            this.contractNumberTextBox = new System.Windows.Forms.TextBox();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.contractNumberLabel = new System.Windows.Forms.Label();
            this.contractDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contractDateLabel = new System.Windows.Forms.Label();
            this.applicationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationNumberLabel = new System.Windows.Forms.Label();
            this.applicationsDateLabel = new System.Windows.Forms.Label();
            this.applicationNumberTextBox = new System.Windows.Forms.TextBox();
            this.applicationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gkLabel = new System.Windows.Forms.Label();
            this.gkTextBox = new System.Windows.Forms.TextBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.productionGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.productNumberComboBox = new System.Windows.Forms.ComboBox();
            this.productNumberLabel = new System.Windows.Forms.Label();
            this.productIndexLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productAliasTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIndexComboBox = new System.Windows.Forms.ComboBox();
            this.productAliasLabel = new System.Windows.Forms.Label();
            this.dceGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dceNameTextBox = new System.Windows.Forms.TextBox();
            this.dceAliasTextBox = new System.Windows.Forms.TextBox();
            this.dceNumberTextBox = new System.Windows.Forms.TextBox();
            this.dceNumberLabel = new System.Windows.Forms.Label();
            this.dceAliasLabel = new System.Windows.Forms.Label();
            this.dceNameLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.departmentGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.applicationStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.notPerformedApplicationsRadioButton = new System.Windows.Forms.RadioButton();
            this.performedApplicationsRadioButton = new System.Windows.Forms.RadioButton();
            this.allApplicationsRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.userModifyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateModifyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.supplyGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.supplierGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.applicationGroupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.productionGroupBox.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.dceGroupBox.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.departmentGroupBox.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.applicationStatusGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.supplyGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productionGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // supplyGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.supplyGroupBox, 2);
            this.supplyGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.supplyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplyGroupBox.Location = new System.Drawing.Point(4, 4);
            this.supplyGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplyGroupBox.Name = "supplyGroupBox";
            this.supplyGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.supplyGroupBox.Size = new System.Drawing.Size(812, 152);
            this.supplyGroupBox.TabIndex = 6;
            this.supplyGroupBox.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.supplierGroupBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.applicationGroupBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.orderGroupBox, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(804, 129);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // supplierGroupBox
            // 
            this.supplierGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.supplierGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGroupBox.Location = new System.Drawing.Point(4, 4);
            this.supplierGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplierGroupBox.Name = "supplierGroupBox";
            this.supplierGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.SetRowSpan(this.supplierGroupBox, 2);
            this.supplierGroupBox.Size = new System.Drawing.Size(394, 122);
            this.supplierGroupBox.TabIndex = 0;
            this.supplierGroupBox.TabStop = false;
            this.supplierGroupBox.Text = "Поставщик";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.supplierNameTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.contractNumberTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.supplierNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.contractNumberLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.contractDateTimePicker, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.contractDateLabel, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(386, 99);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // supplierNameTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.supplierNameTextBox, 2);
            this.supplierNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierNameTextBox.Location = new System.Drawing.Point(4, 21);
            this.supplierNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplierNameTextBox.Name = "supplierNameTextBox";
            this.supplierNameTextBox.Size = new System.Drawing.Size(378, 22);
            this.supplierNameTextBox.TabIndex = 0;
            // 
            // contractNumberTextBox
            // 
            this.contractNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractNumberTextBox.Location = new System.Drawing.Point(4, 68);
            this.contractNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractNumberTextBox.Name = "contractNumberTextBox";
            this.contractNumberTextBox.Size = new System.Drawing.Size(185, 22);
            this.contractNumberTextBox.TabIndex = 2;
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.supplierNameLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.supplierNameLabel, 2);
            this.supplierNameLabel.Location = new System.Drawing.Point(4, 0);
            this.supplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(198, 17);
            this.supplierNameLabel.TabIndex = 3;
            this.supplierNameLabel.Text = "Наименование организации:";
            // 
            // contractNumberLabel
            // 
            this.contractNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contractNumberLabel.AutoSize = true;
            this.contractNumberLabel.Location = new System.Drawing.Point(4, 47);
            this.contractNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractNumberLabel.Name = "contractNumberLabel";
            this.contractNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.contractNumberLabel.TabIndex = 4;
            this.contractNumberLabel.Text = "№ договора:";
            // 
            // contractDateTimePicker
            // 
            this.contractDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractDateTimePicker.Location = new System.Drawing.Point(197, 68);
            this.contractDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.contractDateTimePicker.Name = "contractDateTimePicker";
            this.contractDateTimePicker.Size = new System.Drawing.Size(176, 22);
            this.contractDateTimePicker.TabIndex = 10;
            // 
            // contractDateLabel
            // 
            this.contractDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contractDateLabel.AutoSize = true;
            this.contractDateLabel.Location = new System.Drawing.Point(197, 47);
            this.contractDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractDateLabel.Name = "contractDateLabel";
            this.contractDateLabel.Size = new System.Drawing.Size(110, 17);
            this.contractDateLabel.TabIndex = 5;
            this.contractDateLabel.Text = "Дата договора:";
            // 
            // applicationGroupBox
            // 
            this.applicationGroupBox.Controls.Add(this.tableLayoutPanel6);
            this.applicationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationGroupBox.Location = new System.Drawing.Point(406, 4);
            this.applicationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.applicationGroupBox.Name = "applicationGroupBox";
            this.applicationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.SetRowSpan(this.applicationGroupBox, 2);
            this.applicationGroupBox.Size = new System.Drawing.Size(193, 122);
            this.applicationGroupBox.TabIndex = 2;
            this.applicationGroupBox.TabStop = false;
            this.applicationGroupBox.Text = "Заявка";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.applicationNumberLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.applicationsDateLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.applicationNumberTextBox, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.applicationDateTimePicker, 0, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(185, 99);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // applicationNumberLabel
            // 
            this.applicationNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applicationNumberLabel.AutoSize = true;
            this.applicationNumberLabel.Location = new System.Drawing.Point(4, 0);
            this.applicationNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicationNumberLabel.Name = "applicationNumberLabel";
            this.applicationNumberLabel.Size = new System.Drawing.Size(71, 17);
            this.applicationNumberLabel.TabIndex = 5;
            this.applicationNumberLabel.Text = "№ заявки";
            // 
            // applicationsDateLabel
            // 
            this.applicationsDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applicationsDateLabel.AutoSize = true;
            this.applicationsDateLabel.Location = new System.Drawing.Point(4, 47);
            this.applicationsDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicationsDateLabel.Name = "applicationsDateLabel";
            this.applicationsDateLabel.Size = new System.Drawing.Size(91, 17);
            this.applicationsDateLabel.TabIndex = 6;
            this.applicationsDateLabel.Text = "Дата заявки";
            // 
            // applicationNumberTextBox
            // 
            this.applicationNumberTextBox.Location = new System.Drawing.Point(4, 21);
            this.applicationNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.applicationNumberTextBox.Name = "applicationNumberTextBox";
            this.applicationNumberTextBox.Size = new System.Drawing.Size(175, 22);
            this.applicationNumberTextBox.TabIndex = 4;
            // 
            // applicationDateTimePicker
            // 
            this.applicationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.applicationDateTimePicker.Location = new System.Drawing.Point(4, 68);
            this.applicationDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.applicationDateTimePicker.Name = "applicationDateTimePicker";
            this.applicationDateTimePicker.Size = new System.Drawing.Size(175, 22);
            this.applicationDateTimePicker.TabIndex = 9;
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.orderGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGroupBox.Location = new System.Drawing.Point(607, 4);
            this.orderGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.SetRowSpan(this.orderGroupBox, 2);
            this.orderGroupBox.Size = new System.Drawing.Size(193, 122);
            this.orderGroupBox.TabIndex = 2;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Заказ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.gkLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gkTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.orderTextBox, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.orderLabel, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(185, 99);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // gkLabel
            // 
            this.gkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gkLabel.AutoSize = true;
            this.gkLabel.Location = new System.Drawing.Point(4, 0);
            this.gkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gkLabel.Name = "gkLabel";
            this.gkLabel.Size = new System.Drawing.Size(25, 17);
            this.gkLabel.TabIndex = 3;
            this.gkLabel.Text = "ГК";
            // 
            // gkTextBox
            // 
            this.gkTextBox.Location = new System.Drawing.Point(4, 21);
            this.gkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gkTextBox.Name = "gkTextBox";
            this.gkTextBox.Size = new System.Drawing.Size(177, 22);
            this.gkTextBox.TabIndex = 1;
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(4, 68);
            this.orderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(177, 22);
            this.orderTextBox.TabIndex = 2;
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(4, 47);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(47, 17);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Заказ";
            // 
            // productionGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.productionGroupBox, 2);
            this.productionGroupBox.Controls.Add(this.tableLayoutPanel8);
            this.productionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionGroupBox.Location = new System.Drawing.Point(4, 250);
            this.productionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.productionGroupBox.Name = "productionGroupBox";
            this.productionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.productionGroupBox.Size = new System.Drawing.Size(812, 201);
            this.productionGroupBox.TabIndex = 7;
            this.productionGroupBox.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.productGroupBox, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.dceGroupBox, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(804, 178);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.productGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGroupBox.Location = new System.Drawing.Point(4, 4);
            this.productGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.SetRowSpan(this.productGroupBox, 2);
            this.productGroupBox.Size = new System.Drawing.Size(394, 170);
            this.productGroupBox.TabIndex = 3;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Изделие";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.productNumberComboBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.productNumberLabel);
            this.tableLayoutPanel3.Controls.Add(this.productIndexLabel);
            this.tableLayoutPanel3.Controls.Add(this.productNameTextBox, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.productAliasTextBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.productNameLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.productIndexComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.productAliasLabel, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(386, 147);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // productNumberComboBox
            // 
            this.productNumberComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productNumberComboBox.FormattingEnabled = true;
            this.productNumberComboBox.Location = new System.Drawing.Point(4, 21);
            this.productNumberComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNumberComboBox.Name = "productNumberComboBox";
            this.productNumberComboBox.Size = new System.Drawing.Size(185, 24);
            this.productNumberComboBox.TabIndex = 4;
            // 
            // productNumberLabel
            // 
            this.productNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productNumberLabel.AutoSize = true;
            this.productNumberLabel.Location = new System.Drawing.Point(4, 0);
            this.productNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNumberLabel.Name = "productNumberLabel";
            this.productNumberLabel.Size = new System.Drawing.Size(110, 17);
            this.productNumberLabel.TabIndex = 6;
            this.productNumberLabel.Text = "Номер изделия";
            // 
            // productIndexLabel
            // 
            this.productIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productIndexLabel.AutoSize = true;
            this.productIndexLabel.Location = new System.Drawing.Point(197, 0);
            this.productIndexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productIndexLabel.Name = "productIndexLabel";
            this.productIndexLabel.Size = new System.Drawing.Size(115, 17);
            this.productIndexLabel.TabIndex = 7;
            this.productIndexLabel.Text = "Индекс изделия";
            // 
            // productNameTextBox
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.productNameTextBox, 2);
            this.productNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNameTextBox.Location = new System.Drawing.Point(4, 117);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(378, 22);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productAliasTextBox
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.productAliasTextBox, 2);
            this.productAliasTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productAliasTextBox.Location = new System.Drawing.Point(4, 70);
            this.productAliasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productAliasTextBox.Name = "productAliasTextBox";
            this.productAliasTextBox.Size = new System.Drawing.Size(378, 22);
            this.productAliasTextBox.TabIndex = 2;
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productNameLabel.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.productNameLabel, 2);
            this.productNameLabel.Location = new System.Drawing.Point(4, 96);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(165, 17);
            this.productNameLabel.TabIndex = 9;
            this.productNameLabel.Text = "Наименование изделия";
            // 
            // productIndexComboBox
            // 
            this.productIndexComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productIndexComboBox.FormattingEnabled = true;
            this.productIndexComboBox.Location = new System.Drawing.Point(197, 21);
            this.productIndexComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productIndexComboBox.Name = "productIndexComboBox";
            this.productIndexComboBox.Size = new System.Drawing.Size(185, 24);
            this.productIndexComboBox.TabIndex = 5;
            // 
            // productAliasLabel
            // 
            this.productAliasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.productAliasLabel.AutoSize = true;
            this.productAliasLabel.Location = new System.Drawing.Point(4, 49);
            this.productAliasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productAliasLabel.Name = "productAliasLabel";
            this.productAliasLabel.Size = new System.Drawing.Size(157, 17);
            this.productAliasLabel.TabIndex = 8;
            this.productAliasLabel.Text = "Обозначение изделия";
            // 
            // dceGroupBox
            // 
            this.dceGroupBox.Controls.Add(this.tableLayoutPanel7);
            this.dceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dceGroupBox.Location = new System.Drawing.Point(406, 4);
            this.dceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.dceGroupBox.Name = "dceGroupBox";
            this.dceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.SetRowSpan(this.dceGroupBox, 2);
            this.dceGroupBox.Size = new System.Drawing.Size(394, 170);
            this.dceGroupBox.TabIndex = 4;
            this.dceGroupBox.TabStop = false;
            this.dceGroupBox.Text = "ДСЕ";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.dceNameTextBox, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.dceAliasTextBox, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.dceNumberTextBox, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.dceNumberLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dceAliasLabel, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.dceNameLabel, 0, 4);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(385, 148);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // dceNameTextBox
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.dceNameTextBox, 3);
            this.dceNameTextBox.Location = new System.Drawing.Point(4, 115);
            this.dceNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dceNameTextBox.Name = "dceNameTextBox";
            this.dceNameTextBox.Size = new System.Drawing.Size(376, 22);
            this.dceNameTextBox.TabIndex = 2;
            // 
            // dceAliasTextBox
            // 
            this.dceAliasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel7.SetColumnSpan(this.dceAliasTextBox, 3);
            this.dceAliasTextBox.Location = new System.Drawing.Point(4, 68);
            this.dceAliasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dceAliasTextBox.Name = "dceAliasTextBox";
            this.dceAliasTextBox.Size = new System.Drawing.Size(376, 22);
            this.dceAliasTextBox.TabIndex = 3;
            // 
            // dceNumberTextBox
            // 
            this.dceNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dceNumberTextBox.Location = new System.Drawing.Point(4, 21);
            this.dceNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dceNumberTextBox.Name = "dceNumberTextBox";
            this.dceNumberTextBox.Size = new System.Drawing.Size(119, 22);
            this.dceNumberTextBox.TabIndex = 1;
            // 
            // dceNumberLabel
            // 
            this.dceNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dceNumberLabel.AutoSize = true;
            this.dceNumberLabel.Location = new System.Drawing.Point(4, 0);
            this.dceNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dceNumberLabel.Name = "dceNumberLabel";
            this.dceNumberLabel.Size = new System.Drawing.Size(84, 17);
            this.dceNumberLabel.TabIndex = 4;
            this.dceNumberLabel.Text = "Номер ДСЕ";
            // 
            // dceAliasLabel
            // 
            this.dceAliasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dceAliasLabel.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.dceAliasLabel, 2);
            this.dceAliasLabel.Location = new System.Drawing.Point(4, 47);
            this.dceAliasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dceAliasLabel.Name = "dceAliasLabel";
            this.dceAliasLabel.Size = new System.Drawing.Size(131, 17);
            this.dceAliasLabel.TabIndex = 5;
            this.dceAliasLabel.Text = "Обозначение ДСЕ";
            // 
            // dceNameLabel
            // 
            this.dceNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dceNameLabel.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.dceNameLabel, 2);
            this.dceNameLabel.Location = new System.Drawing.Point(4, 94);
            this.dceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dceNameLabel.Name = "dceNameLabel";
            this.dceNameLabel.Size = new System.Drawing.Size(139, 17);
            this.dceNameLabel.TabIndex = 6;
            this.dceNameLabel.Text = "Наименование ДСЕ";
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Controls.Add(this.departmentGroupBox);
            this.flowLayoutPanel2.Controls.Add(this.applicationStatusGroupBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 164);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(812, 78);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // departmentGroupBox
            // 
            this.departmentGroupBox.Controls.Add(this.tableLayoutPanel9);
            this.departmentGroupBox.Location = new System.Drawing.Point(4, 4);
            this.departmentGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.departmentGroupBox.Name = "departmentGroupBox";
            this.departmentGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.departmentGroupBox.Size = new System.Drawing.Size(131, 75);
            this.departmentGroupBox.TabIndex = 8;
            this.departmentGroupBox.TabStop = false;
            this.departmentGroupBox.Text = "Отдел";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.departmentComboBox, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.departmentLabel, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(123, 52);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(4, 21);
            this.departmentComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(113, 24);
            this.departmentComboBox.TabIndex = 0;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(4, 0);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(12, 17);
            this.departmentLabel.TabIndex = 1;
            this.departmentLabel.Text = " ";
            // 
            // applicationStatusGroupBox
            // 
            this.applicationStatusGroupBox.Controls.Add(this.notPerformedApplicationsRadioButton);
            this.applicationStatusGroupBox.Controls.Add(this.performedApplicationsRadioButton);
            this.applicationStatusGroupBox.Controls.Add(this.allApplicationsRadioButton);
            this.applicationStatusGroupBox.Location = new System.Drawing.Point(143, 4);
            this.applicationStatusGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.applicationStatusGroupBox.Name = "applicationStatusGroupBox";
            this.applicationStatusGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.applicationStatusGroupBox.Size = new System.Drawing.Size(288, 75);
            this.applicationStatusGroupBox.TabIndex = 9;
            this.applicationStatusGroupBox.TabStop = false;
            this.applicationStatusGroupBox.Text = "Статус заявки";
            // 
            // notPerformedApplicationsRadioButton
            // 
            this.notPerformedApplicationsRadioButton.AutoSize = true;
            this.notPerformedApplicationsRadioButton.Location = new System.Drawing.Point(137, 23);
            this.notPerformedApplicationsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.notPerformedApplicationsRadioButton.Name = "notPerformedApplicationsRadioButton";
            this.notPerformedApplicationsRadioButton.Size = new System.Drawing.Size(138, 21);
            this.notPerformedApplicationsRadioButton.TabIndex = 2;
            this.notPerformedApplicationsRadioButton.Text = "Невыполненные";
            this.notPerformedApplicationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // performedApplicationsRadioButton
            // 
            this.performedApplicationsRadioButton.AutoSize = true;
            this.performedApplicationsRadioButton.Location = new System.Drawing.Point(8, 47);
            this.performedApplicationsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.performedApplicationsRadioButton.Name = "performedApplicationsRadioButton";
            this.performedApplicationsRadioButton.Size = new System.Drawing.Size(122, 21);
            this.performedApplicationsRadioButton.TabIndex = 1;
            this.performedApplicationsRadioButton.Text = "Выполненные";
            this.performedApplicationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // allApplicationsRadioButton
            // 
            this.allApplicationsRadioButton.AutoSize = true;
            this.allApplicationsRadioButton.Checked = true;
            this.allApplicationsRadioButton.Location = new System.Drawing.Point(8, 23);
            this.allApplicationsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.allApplicationsRadioButton.Name = "allApplicationsRadioButton";
            this.allApplicationsRadioButton.Size = new System.Drawing.Size(102, 21);
            this.allApplicationsRadioButton.TabIndex = 0;
            this.allApplicationsRadioButton.TabStop = true;
            this.allApplicationsRadioButton.Text = "Все заявки";
            this.allApplicationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Controls.Add(this.applyButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(414, 489);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(402, 76);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(295, 6);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(181, 6);
            this.clearButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(67, 6);
            this.applyButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userModifyToolStripStatusLabel,
            this.dateModifyToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(820, 29);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // userModifyToolStripStatusLabel
            // 
            this.userModifyToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.userModifyToolStripStatusLabel.Name = "userModifyToolStripStatusLabel";
            this.userModifyToolStripStatusLabel.Size = new System.Drawing.Size(143, 24);
            this.userModifyToolStripStatusLabel.Text = "####_Surname A.A.";
            // 
            // dateModifyToolStripStatusLabel
            // 
            this.dateModifyToolStripStatusLabel.Name = "dateModifyToolStripStatusLabel";
            this.dateModifyToolStripStatusLabel.Size = new System.Drawing.Size(87, 24);
            this.dateModifyToolStripStatusLabel.Text = "##.##.####";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 569);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки и договоры";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.supplyGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.supplierGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.applicationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.orderGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.productionGroupBox.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.productGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.dceGroupBox.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.departmentGroupBox.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.applicationStatusGroupBox.ResumeLayout(false);
            this.applicationStatusGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox supplierGroupBox;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.GroupBox dceGroupBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.TextBox gkTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productAliasTextBox;
        private System.Windows.Forms.TextBox dceAliasTextBox;
        private System.Windows.Forms.TextBox dceNameTextBox;
        private System.Windows.Forms.TextBox dceNumberTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox supplierNameTextBox;
        private System.Windows.Forms.TextBox contractNumberTextBox;
        private System.Windows.Forms.Label supplierNameLabel;
        private System.Windows.Forms.Label contractNumberLabel;
        private System.Windows.Forms.Label contractDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label gkLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.GroupBox supplyGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox applicationGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label applicationNumberLabel;
        private System.Windows.Forms.TextBox applicationNumberTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox productNumberComboBox;
        private System.Windows.Forms.ComboBox productIndexComboBox;
        private System.Windows.Forms.Label productNumberLabel;
        private System.Windows.Forms.Label productIndexLabel;
        private System.Windows.Forms.Label productAliasLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label dceNumberLabel;
        private System.Windows.Forms.Label dceAliasLabel;
        private System.Windows.Forms.Label dceNameLabel;
        private System.Windows.Forms.Label applicationsDateLabel;
        private System.Windows.Forms.GroupBox productionGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox departmentGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.DateTimePicker contractDateTimePicker;
        private System.Windows.Forms.DateTimePicker applicationDateTimePicker;
        private System.Windows.Forms.ToolStripStatusLabel userModifyToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dateModifyToolStripStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox applicationStatusGroupBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.RadioButton notPerformedApplicationsRadioButton;
        private System.Windows.Forms.RadioButton performedApplicationsRadioButton;
        private System.Windows.Forms.RadioButton allApplicationsRadioButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button cancelButton;
    }
}


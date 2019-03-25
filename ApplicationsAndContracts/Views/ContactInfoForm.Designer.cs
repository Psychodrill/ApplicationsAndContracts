namespace ApplicationsAndContracts.Views
{
    partial class ContactInfoForm
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
            this.searchingLineTextBox = new System.Windows.Forms.TextBox();
            this.searchingButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dceDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.userModifyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.userModifyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userModifyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateModifyToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateModifyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dceDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.userModifyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.searchingLineTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchingButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.userModifyStatusStrip, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchingLineTextBox
            // 
            this.searchingLineTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchingLineTextBox.Location = new System.Drawing.Point(3, 43);
            this.searchingLineTextBox.Name = "searchingLineTextBox";
            this.searchingLineTextBox.Size = new System.Drawing.Size(387, 22);
            this.searchingLineTextBox.TabIndex = 0;
            // 
            // searchingButton
            // 
            this.searchingButton.AutoSize = true;
            this.searchingButton.Location = new System.Drawing.Point(396, 43);
            this.searchingButton.Name = "searchingButton";
            this.searchingButton.Size = new System.Drawing.Size(75, 27);
            this.searchingButton.TabIndex = 2;
            this.searchingButton.Text = "Найти!";
            this.searchingButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.dceDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список данных";
            // 
            // dceDataGridView
            // 
            this.dceDataGridView.AllowUserToAddRows = false;
            this.dceDataGridView.AllowUserToDeleteRows = false;
            this.dceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.TabNumberColumn,
            this.Phone1Column,
            this.Phone2Column,
            this.FaxColumn});
            this.dceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dceDataGridView.Location = new System.Drawing.Point(3, 18);
            this.dceDataGridView.MultiSelect = false;
            this.dceDataGridView.Name = "dceDataGridView";
            this.dceDataGridView.ReadOnly = true;
            this.dceDataGridView.RowHeadersVisible = false;
            this.dceDataGridView.RowTemplate.Height = 24;
            this.dceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dceDataGridView.ShowRowErrors = false;
            this.dceDataGridView.Size = new System.Drawing.Size(775, 345);
            this.dceDataGridView.TabIndex = 1;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameColumn.HeaderText = "Фамилия И.О.";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // TabNumberColumn
            // 
            this.TabNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TabNumberColumn.HeaderText = "Табельный номер";
            this.TabNumberColumn.Name = "TabNumberColumn";
            this.TabNumberColumn.ReadOnly = true;
            // 
            // Phone1Column
            // 
            this.Phone1Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone1Column.HeaderText = "Телефон 1";
            this.Phone1Column.Name = "Phone1Column";
            this.Phone1Column.ReadOnly = true;
            // 
            // Phone2Column
            // 
            this.Phone2Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone2Column.HeaderText = "Телефон 2";
            this.Phone2Column.Name = "Phone2Column";
            this.Phone2Column.ReadOnly = true;
            // 
            // FaxColumn
            // 
            this.FaxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FaxColumn.HeaderText = "Факс";
            this.FaxColumn.Name = "FaxColumn";
            this.FaxColumn.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(396, 448);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(310, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(229, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(141, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(53, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // userModifyStatusStrip
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.userModifyStatusStrip, 2);
            this.userModifyStatusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userModifyStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userModifyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userModifyToolStripStatusLabel,
            this.userModifyValueToolStripStatusLabel,
            this.dateModifyToolStripStatusLabel,
            this.dateModifyValueToolStripStatusLabel});
            this.userModifyStatusStrip.Location = new System.Drawing.Point(0, 485);
            this.userModifyStatusStrip.Name = "userModifyStatusStrip";
            this.userModifyStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.userModifyStatusStrip.Size = new System.Drawing.Size(787, 30);
            this.userModifyStatusStrip.TabIndex = 7;
            this.userModifyStatusStrip.Text = "statusStrip1";
            // 
            // userModifyToolStripStatusLabel
            // 
            this.userModifyToolStripStatusLabel.Name = "userModifyToolStripStatusLabel";
            this.userModifyToolStripStatusLabel.Size = new System.Drawing.Size(164, 25);
            this.userModifyToolStripStatusLabel.Text = "Автор корректировки:";
            // 
            // userModifyValueToolStripStatusLabel
            // 
            this.userModifyValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.userModifyValueToolStripStatusLabel.Name = "userModifyValueToolStripStatusLabel";
            this.userModifyValueToolStripStatusLabel.Size = new System.Drawing.Size(143, 25);
            this.userModifyValueToolStripStatusLabel.Text = "####_Surname A.A.";
            // 
            // dateModifyToolStripStatusLabel
            // 
            this.dateModifyToolStripStatusLabel.Name = "dateModifyToolStripStatusLabel";
            this.dateModifyToolStripStatusLabel.Size = new System.Drawing.Size(154, 25);
            this.dateModifyToolStripStatusLabel.Text = "Дата корректировки:";
            // 
            // dateModifyValueToolStripStatusLabel
            // 
            this.dateModifyValueToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.dateModifyValueToolStripStatusLabel.Name = "dateModifyValueToolStripStatusLabel";
            this.dateModifyValueToolStripStatusLabel.Size = new System.Drawing.Size(91, 25);
            this.dateModifyValueToolStripStatusLabel.Text = "##.##.####";
            // 
            // ContactInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ContactInfoForm";
            this.Text = "Контактные данные";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dceDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.userModifyStatusStrip.ResumeLayout(false);
            this.userModifyStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox searchingLineTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TabNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxColumn;
        private System.Windows.Forms.Button searchingButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip userModifyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel userModifyToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userModifyValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dateModifyToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dateModifyValueToolStripStatusLabel;
    }
}
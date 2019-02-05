namespace ApplicationsAndContracts.Views
{
    partial class ApplicationsAndContractsForm
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
            this.ApplicationsAndContractsTabControl = new System.Windows.Forms.TabControl();
            this.eer = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.applicationNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dceGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ApplicationsAndContractsTabControl.SuspendLayout();
            this.eer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.applicationsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            this.dceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationsAndContractsTabControl
            // 
            this.ApplicationsAndContractsTabControl.Controls.Add(this.eer);
            this.ApplicationsAndContractsTabControl.Controls.Add(this.tabPage2);
            this.ApplicationsAndContractsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplicationsAndContractsTabControl.ItemSize = new System.Drawing.Size(64, 18);
            this.ApplicationsAndContractsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ApplicationsAndContractsTabControl.Name = "ApplicationsAndContractsTabControl";
            this.ApplicationsAndContractsTabControl.SelectedIndex = 0;
            this.ApplicationsAndContractsTabControl.Size = new System.Drawing.Size(824, 582);
            this.ApplicationsAndContractsTabControl.TabIndex = 0;
            // 
            // eer
            // 
            this.eer.BackColor = System.Drawing.SystemColors.Control;
            this.eer.Controls.Add(this.tableLayoutPanel1);
            this.eer.Location = new System.Drawing.Point(4, 22);
            this.eer.Name = "eer";
            this.eer.Padding = new System.Windows.Forms.Padding(3);
            this.eer.Size = new System.Drawing.Size(816, 556);
            this.eer.TabIndex = 0;
            this.eer.Text = "Заявки";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.applicationsGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dceGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // applicationsGroupBox
            // 
            this.applicationsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.applicationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.applicationsGroupBox.Name = "applicationsGroupBox";
            this.applicationsGroupBox.Size = new System.Drawing.Size(804, 269);
            this.applicationsGroupBox.TabIndex = 0;
            this.applicationsGroupBox.TabStop = false;
            this.applicationsGroupBox.Text = "Заявки";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.applicationsDataGridView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 250);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // applicationsDataGridView
            // 
            this.applicationsDataGridView.AllowUserToAddRows = false;
            this.applicationsDataGridView.AllowUserToDeleteRows = false;
            this.applicationsDataGridView.AutoGenerateColumns = false;
            this.applicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicationNumberColumn,
            this.applicationDateColumn,
            this.supplierColumn,
            this.contractNumberColumn,
            this.contractDateColumn,
            this.gkColumn,
            this.statusColumn});
            this.tableLayoutPanel2.SetColumnSpan(this.applicationsDataGridView, 5);
            this.applicationsDataGridView.DataSource = this.applicationsBindingSource;
            this.applicationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.applicationsDataGridView.Name = "applicationsDataGridView";
            this.applicationsDataGridView.ReadOnly = true;
            this.applicationsDataGridView.RowHeadersVisible = false;
            this.tableLayoutPanel2.SetRowSpan(this.applicationsDataGridView, 2);
            this.applicationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicationsDataGridView.Size = new System.Drawing.Size(792, 174);
            this.applicationsDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Договоры";
            // 
            // applicationNumberColumn
            // 
            this.applicationNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.applicationNumberColumn.DataPropertyName = "ApplicationNumber";
            this.applicationNumberColumn.HeaderText = "№ заявки";
            this.applicationNumberColumn.Name = "applicationNumberColumn";
            this.applicationNumberColumn.ReadOnly = true;
            this.applicationNumberColumn.Width = 82;
            // 
            // applicationDateColumn
            // 
            this.applicationDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.applicationDateColumn.DataPropertyName = "ApplicationDate";
            this.applicationDateColumn.HeaderText = "Дата заявки";
            this.applicationDateColumn.Name = "applicationDateColumn";
            this.applicationDateColumn.ReadOnly = true;
            this.applicationDateColumn.Width = 97;
            // 
            // supplierColumn
            // 
            this.supplierColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierColumn.DataPropertyName = "Supplier";
            this.supplierColumn.HeaderText = "Поставщик";
            this.supplierColumn.Name = "supplierColumn";
            this.supplierColumn.ReadOnly = true;
            // 
            // contractNumberColumn
            // 
            this.contractNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.contractNumberColumn.DataPropertyName = "ContractNumber";
            this.contractNumberColumn.HeaderText = "№ договора";
            this.contractNumberColumn.Name = "contractNumberColumn";
            this.contractNumberColumn.ReadOnly = true;
            this.contractNumberColumn.Width = 93;
            // 
            // contractDateColumn
            // 
            this.contractDateColumn.DataPropertyName = "ContractDate";
            this.contractDateColumn.HeaderText = "Дата договора";
            this.contractDateColumn.Name = "contractDateColumn";
            this.contractDateColumn.ReadOnly = true;
            this.contractDateColumn.Width = 110;
            // 
            // gkColumn
            // 
            this.gkColumn.DataPropertyName = "GK";
            this.gkColumn.HeaderText = "ГК";
            this.gkColumn.Name = "gkColumn";
            this.gkColumn.ReadOnly = true;
            this.gkColumn.Width = 90;
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusColumn.DataPropertyName = "Status";
            this.statusColumn.HeaderText = "Статус";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Width = 66;
            // 
            // dceGroupBox
            // 
            this.dceGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.dceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dceGroupBox.Location = new System.Drawing.Point(3, 278);
            this.dceGroupBox.Name = "dceGroupBox";
            this.dceGroupBox.Size = new System.Drawing.Size(804, 269);
            this.dceGroupBox.TabIndex = 1;
            this.dceGroupBox.TabStop = false;
            this.dceGroupBox.Text = "Перечень ДСЕ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(126, 92);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ApplicationsAndContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ApplicationsAndContractsTabControl);
            this.Name = "ApplicationsAndContracts";
            this.Text = "Заявки и договоры";
            this.ApplicationsAndContractsTabControl.ResumeLayout(false);
            this.eer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.applicationsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            this.dceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ApplicationsAndContractsTabControl;
        private System.Windows.Forms.TabPage eer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox applicationsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView applicationsDataGridView;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.GroupBox dceGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
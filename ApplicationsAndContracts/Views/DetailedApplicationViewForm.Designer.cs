namespace ApplicationsAndContracts.Views
{
    partial class DetailedApplicationViewForm
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
            this.applicationGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.applicationNumberLabel = new System.Windows.Forms.Label();
            this.applicationDateLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.contractNumberLlabel = new System.Windows.Forms.Label();
            this.contractDateLlabel = new System.Windows.Forms.Label();
            this.customerContractLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.applicationGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.applicationGroupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // applicationGroupBox
            // 
            this.applicationGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.applicationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.applicationGroupBox.Name = "applicationGroupBox";
            this.applicationGroupBox.Size = new System.Drawing.Size(1002, 79);
            this.applicationGroupBox.TabIndex = 0;
            this.applicationGroupBox.TabStop = false;
            this.applicationGroupBox.Text = "Заявка";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.contractDateLlabel, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.applicationNumberLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.applicationDateLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.supplierLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.contractNumberLlabel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.customerContractLabel, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 5, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(996, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // applicationNumberLabel
            // 
            this.applicationNumberLabel.AutoSize = true;
            this.applicationNumberLabel.Location = new System.Drawing.Point(3, 20);
            this.applicationNumberLabel.Name = "applicationNumberLabel";
            this.applicationNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.applicationNumberLabel.TabIndex = 0;
            this.applicationNumberLabel.Text = "Номер заявки";
            // 
            // applicationDateLabel
            // 
            this.applicationDateLabel.AutoSize = true;
            this.applicationDateLabel.Location = new System.Drawing.Point(102, 20);
            this.applicationDateLabel.Name = "applicationDateLabel";
            this.applicationDateLabel.Size = new System.Drawing.Size(72, 13);
            this.applicationDateLabel.TabIndex = 1;
            this.applicationDateLabel.Text = "Дата заявки";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(201, 20);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(65, 13);
            this.supplierLabel.TabIndex = 2;
            this.supplierLabel.Text = "Поставщик";
            // 
            // contractNumberLlabel
            // 
            this.contractNumberLlabel.AutoSize = true;
            this.contractNumberLlabel.Location = new System.Drawing.Point(649, 20);
            this.contractNumberLlabel.Name = "contractNumberLlabel";
            this.contractNumberLlabel.Size = new System.Drawing.Size(71, 13);
            this.contractNumberLlabel.TabIndex = 3;
            this.contractNumberLlabel.Text = "№ Договора";
            // 
            // contractDateLlabel
            // 
            this.contractDateLlabel.AutoSize = true;
            this.contractDateLlabel.Location = new System.Drawing.Point(748, 20);
            this.contractDateLlabel.Name = "contractDateLlabel";
            this.contractDateLlabel.Size = new System.Drawing.Size(83, 13);
            this.contractDateLlabel.TabIndex = 4;
            this.contractDateLlabel.Text = "Дата договора";
            // 
            // customerContractLabel
            // 
            this.customerContractLabel.AutoSize = true;
            this.customerContractLabel.Location = new System.Drawing.Point(847, 20);
            this.customerContractLabel.Name = "customerContractLabel";
            this.customerContractLabel.Size = new System.Drawing.Size(124, 13);
            this.customerContractLabel.TabIndex = 5;
            this.customerContractLabel.Text = "Договор с заказчиком";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(201, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(442, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(649, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(93, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(748, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(93, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(847, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(146, 20);
            this.textBox6.TabIndex = 11;
            // 
            // DetailedApplicationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DetailedApplicationViewForm";
            this.Text = "Подробный просмотр заявки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.applicationGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox applicationGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label contractDateLlabel;
        private System.Windows.Forms.Label applicationNumberLabel;
        private System.Windows.Forms.Label applicationDateLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label contractNumberLlabel;
        private System.Windows.Forms.Label customerContractLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}
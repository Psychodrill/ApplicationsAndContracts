namespace ApplicationsAndContracts.Views
{
    partial class ContactInfoAddingForm
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
            this.tabNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Phone1Label = new System.Windows.Forms.Label();
            this.Phone2Label = new System.Windows.Forms.Label();
            this.FaxLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabNumberLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SurnameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.departmentLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.Phone1Label, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Phone2Label, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.FaxLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox3, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 335);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabNumberLabel
            // 
            this.tabNumberLabel.AutoSize = true;
            this.tabNumberLabel.Location = new System.Drawing.Point(3, 30);
            this.tabNumberLabel.Name = "tabNumberLabel";
            this.tabNumberLabel.Size = new System.Drawing.Size(127, 17);
            this.tabNumberLabel.TabIndex = 0;
            this.tabNumberLabel.Text = "Табельный номер";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 1;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(3, 75);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(168, 17);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия Имя Отчество";
            // 
            // textBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox2, 2);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(388, 22);
            this.textBox2.TabIndex = 3;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(3, 120);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(50, 17);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.Text = "Отдел";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 22);
            this.textBox3.TabIndex = 5;
            // 
            // Phone1Label
            // 
            this.Phone1Label.AutoSize = true;
            this.Phone1Label.Location = new System.Drawing.Point(3, 165);
            this.Phone1Label.Name = "Phone1Label";
            this.Phone1Label.Size = new System.Drawing.Size(76, 17);
            this.Phone1Label.TabIndex = 6;
            this.Phone1Label.Text = "Телефон1";
            // 
            // Phone2Label
            // 
            this.Phone2Label.AutoSize = true;
            this.Phone2Label.Location = new System.Drawing.Point(200, 165);
            this.Phone2Label.Name = "Phone2Label";
            this.Phone2Label.Size = new System.Drawing.Size(76, 17);
            this.Phone2Label.TabIndex = 8;
            this.Phone2Label.Text = "Телефон2";
            // 
            // FaxLabel
            // 
            this.FaxLabel.AutoSize = true;
            this.FaxLabel.Location = new System.Drawing.Point(3, 210);
            this.FaxLabel.Name = "FaxLabel";
            this.FaxLabel.Size = new System.Drawing.Size(43, 17);
            this.FaxLabel.TabIndex = 10;
            this.FaxLabel.Text = "Факс";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 258);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 33);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Location = new System.Drawing.Point(113, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 27);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(20, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 27);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 185);
            this.maskedTextBox1.Mask = "+7(___)___-__-__";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox2.Location = new System.Drawing.Point(200, 185);
            this.maskedTextBox2.Mask = "+7(___)___-__-__";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBox2.TabIndex = 15;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox3.Location = new System.Drawing.Point(3, 230);
            this.maskedTextBox3.Mask = "+7(___)___-__-__";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(191, 22);
            this.maskedTextBox3.TabIndex = 16;
            // 
            // ContactInfoAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(412, 380);
            this.Name = "ContactInfoAddingForm";
            this.Text = "Добавление контактных данных";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tabNumberLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Phone1Label;
        private System.Windows.Forms.Label Phone2Label;
        private System.Windows.Forms.Label FaxLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationsAndContracts.DataAccess;
using ApplicationsAndContracts.Models;
using ApplicationsAndContracts.Converters;
using ApplicationsAndContracts.Helpers;


namespace ApplicationsAndContracts
{
    public partial class MainForm : Form
    {
        private DataService dataService;

        private SupplierList supplierList;

        private int supplierCode;
        private string supplierName;

        public MainForm()
        {
            this.dataService = new DataService();
            this.supplierName = "";

            InitializeComponent();

            #region Actions
            this.Load += new EventHandler(MainForm_Load);

            this.supplierNameTextBox.TextChanged += new EventHandler(SupplierNameTextBox_Changed);
            this.supplierNameTextBox.Validating += new CancelEventHandler(supplierNameTextBox_Validating);

            #endregion
        }

        private void supplierNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var supplierName = converter.Parse(this.supplierNameTextBox.Text);
                this.supplierList.GetSupplier(supplierName);
                this.supplierName = supplierName;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.supplierNameTextBox.Text = converter.Format(supplierName);
            }
        }

        private void SupplierNameTextBox_Changed(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var supplierName = converter.TryParse(this.supplierNameTextBox.Text);
            var currentSupplier = this.supplierList.TryGetSupplier(supplierName);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.supplierList = SupplierList.GetSupplierList();
            this.supplierNameTextBox.AutoCompleteCustomSource.AddRange(this.supplierList.Select(x => x.SupplierName.Trim()).ToArray());
            
        }



    }
}

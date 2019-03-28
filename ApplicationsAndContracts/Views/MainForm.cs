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
        private ContractList contractList;

        //private int supplierCode;
        private string supplierName;
        //private string contractId;
        private string contractNumber;
        //private string contractDate;
        public MainForm()
        {
            this.dataService = new DataService();
            this.supplierName = string.Empty;
            this.contractNumber = string.Empty;

            InitializeComponent();

            #region Actions
            this.Load += new EventHandler(MainForm_Load);

            this.supplierNameTextBox.TextChanged += new EventHandler(supplierNameTextBox_TextChanged);
            this.supplierNameTextBox.Validating += new CancelEventHandler(supplierNameTextBox_Validating);

            this.contractNumberTextBox.TextChanged += new EventHandler(contractNumberTextBox_TextChanged);
            this.contractNumberTextBox.Validating += new CancelEventHandler(contractNumberTextBox_Validating);
            #endregion
        }

        private void contractNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var contractNumber = converter.Parse(this.contractNumberTextBox.Text);
                this.contractList.GetContract(contractNumber);
                this.contractNumber = contractNumber;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.contractNumberTextBox.Text = converter.Format(contractNumber);
            };
        }

        private void contractNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var contractNumber = converter.TryParse(this.contractNumberTextBox.Text);
            var currentContract = this.contractList.TryGetContract(contractNumber);
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

        private void supplierNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var supplierName = converter.TryParse(this.supplierNameTextBox.Text);
            var currentSupplier = this.supplierList.TryGetSupplier(supplierName);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.supplierList = SupplierList.GetSupplierList();
            this.supplierNameTextBox.AutoCompleteCustomSource.AddRange(this.supplierList.Select(x => x.SupplierName.Trim()).ToArray());
            this.contractList = ContractList.GetContractList();
            this.contractNumberTextBox.AutoCompleteCustomSource.AddRange(this.contractList.Select(x => x.ContractNumber.Trim()).ToArray());
        }



    }
}

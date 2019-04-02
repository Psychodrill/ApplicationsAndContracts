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
using System.Text.RegularExpressions;


namespace ApplicationsAndContracts
{
    public partial class MainForm : Form
    {
        private DataService dataService;

        private SupplierList supplierList;
        private ContractList contractList;
        private ApplicationList applicationList;
        private StateContractList stateContractList;

        //private int supplierCode;
        private string supplierName;
        //private string contractId;
        private string contractNumber;
        private DateTime contractDate;

        private string applicationNumber;
        private DateTime applicationDate;
        private byte applicationStatus;

        private int contractId;
        private string stateContractNumber;

        public MainForm()
        {
            this.dataService = new DataService();
            this.supplierName = string.Empty;
            this.contractNumber = string.Empty;
            this.contractDate = DateTime.MinValue;
            this.applicationNumber = string.Empty;
            this.stateContractNumber = string.Empty;

            InitializeComponent();

            #region Actions
            this.Load += new EventHandler(MainForm_Load);

            this.supplierNameTextBox.TextChanged += new EventHandler(supplierNameTextBox_TextChanged);
            this.supplierNameTextBox.Validating += new CancelEventHandler(supplierNameTextBox_Validating);

            this.contractNumberTextBox.TextChanged += new EventHandler(contractNumberTextBox_TextChanged);
            this.contractNumberTextBox.Validating += new CancelEventHandler(contractNumberTextBox_Validating);

            this.contractDateComboBox.TextChanged += new EventHandler(contractDateComboBox_TextChanged);
            this.contractDateComboBox.Validating += new CancelEventHandler(contractDateComboBox_Validating);

            this.applicationNumberTextBox.TextChanged += new EventHandler(applicationNumberTextBox_TextChanged);
            this.applicationNumberTextBox.Validating += new CancelEventHandler(applicationNumberTextBox_Validating);

            this.applicationDateComboBox.TextChanged += new EventHandler(applicationDateComboBox_TextChanged);
            this.applicationDateComboBox.Validating += new CancelEventHandler(applicationDateComboBox_Validating);

            this.gkTextBox.TextChanged += new EventHandler(gkTextBox_TextChanged);
            this.gkTextBox.Validating += new CancelEventHandler(gkTextBox_Validating);

            this.cancelButton.Click += new EventHandler(cancelButton_Click);
            #endregion
        }

        private void gkTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var stateContractNumber = converter.Parse(this.gkTextBox.Text);
                this.stateContractList.GetStateContractNumber(stateContractNumber);
                this.stateContractNumber = stateContractNumber;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.gkTextBox.Text = converter.Format(stateContractNumber);
            }
        }

        private void gkTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var stateContractNumber = converter.TryParse(gkTextBox.Text);
            var currentStateContract = stateContractList.TryGetContract(stateContractNumber);
        }

        private void applicationDateComboBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new DateConverter();
            try
            {
                var applicationDate = converter.Parse(this.applicationDateComboBox.Text);
                this.applicationList.GetApplicationDate(Convert.ToDateTime(applicationDate));
                this.applicationDate = Convert.ToDateTime(applicationDate);
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.applicationDateComboBox.Text = converter.Format(applicationDate);
            }
        }

        private void applicationDateComboBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new DateConverter();
            var applicationDate = converter.TryParse(this.applicationDateComboBox.Text);
            var currentApplication = applicationList.TryGetApplication(applicationNumber);
        }

        private void applicationNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var applicationNumber = converter.Parse(this.applicationNumberTextBox.Text);
                this.applicationList.GetApplication(applicationNumber);
                this.applicationNumber = applicationNumber;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.applicationNumberTextBox.Text = converter.Format(applicationNumber);
            }

        }

        private void applicationNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var applicationNumber = converter.TryParse(this.applicationNumberTextBox.Text);
            var currentApplication = applicationList.TryGetApplication(applicationNumber); 
        }

        private void contractDateComboBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new DateConverter();
            try
            {
                var contractDate = converter.Parse(this.contractDateComboBox.Text);
                this.contractList.GetContractDate(Convert.ToDateTime(contractDate));
                this.contractDate = Convert.ToDateTime(contractDate);

            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.contractDateComboBox.Text = converter.Format(contractDate);
            }
        }

        private void contractDateComboBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new DateConverter();

            var contractDate = converter.TryParse(contractDateComboBox.Text);
            var currentContract = contractList.TryGetContract(contractNumber);

        }

        private void contractNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var contractNumber = converter.Parse(this.contractNumberTextBox.Text);
                this.contractList.GetContractNumber(contractNumber);
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

            }
        }

        private void contractNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var contractNumber = converter.TryParse(this.contractNumberTextBox.Text);
            var currentContract =  contractList.TryGetContract(contractNumber);
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

        private bool IsMatchingDigitRange(string textparameter)
        {
            Regex filter = new Regex(@"\d\b\d?");
            return filter.IsMatch(textparameter);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.supplierList = SupplierList.GetSupplierList();
            this.supplierNameTextBox.AutoCompleteCustomSource.AddRange(this.supplierList.Select(x => x.SupplierName.Trim()).ToArray());

            this.contractList = ContractList.GetContractList();
            this.contractNumberTextBox.AutoCompleteCustomSource.AddRange(this.contractList.Select(x => x.ContractNumber.Trim()).ToArray());
            this.contractDateComboBox.DataSource = this.contractList.GetContractDateList();
            this.contractDateComboBox.AutoCompleteCustomSource.AddRange(this.contractList.Select(x => x.ContractDate.ToShortDateString()).ToArray());


            this.applicationList = ApplicationList.GetApplicationList();
            this.applicationNumberTextBox.AutoCompleteCustomSource.AddRange(this.applicationList.Select(x => x.ApplicationNumber.Trim()).ToArray());
            this.applicationDateComboBox.DataSource = this.applicationList.GetApplicationDateList();
            this.applicationDateComboBox.AutoCompleteCustomSource.AddRange(this.applicationList.Select(x => x.ApplicationDate.ToShortDateString()).ToArray());

            this.stateContractList = StateContractList.GetStateContractList();
            this.gkTextBox.AutoCompleteCustomSource.AddRange(this.stateContractList.Select(x => x.StateContractNumber.Trim()).ToArray());


        }
              
        void cancelButton_Click (object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

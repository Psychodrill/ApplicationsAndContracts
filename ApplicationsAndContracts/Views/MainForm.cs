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
using ApplicationsAndContracts.Views;


namespace ApplicationsAndContracts
{
    public partial class MainForm : Form
    {
        private DataService dataService;
        private SupplierList supplierList;
        private ContractList contractList;
        private ApplicationList applicationList;
        private StateContractList stateContractList;
        private OrderList orderList;
        private ProductList productList;
        private DceList dceList;
        



        //private int supplierCode;
        private string supplierName;
        //private string contractId;
        private string contractNumber;
        private DateTime contractDate;

        private string applicationNumber;
        private DateTime applicationDate;
        private byte applicationStatus;
        private string department;

        private int stateContractId;
        private string stateContractNumber;

        private int applicationId;
        private int orderNumber;

        private int idInd;
        private int productNumber;
        private string productIndex;
        private string productName;
        private string productAlias;

        private int dceNumber;
        private string dceAlias;
        private string dceName;


        public Criteria Criteria { get; private set; }
        public Catalog Catalog { get; private set; }

        public event EventHandler GoToApplicationsAndContractsForm;

        public MainForm()
        {
            this.dataService = new DataService();
            this.supplierName = string.Empty;
            this.contractNumber = string.Empty;
            this.contractDate = DateTime.Today; 
            this.applicationNumber = string.Empty;
            this.applicationDate = DateTime.Today;
            this.stateContractNumber = string.Empty;
            this.orderNumber = -1;
            this.department = string.Empty;
            this.productNumber = -1;
            this.productIndex = string.Empty;
            this.productAlias = string.Empty;
            this.productName = string.Empty;
            this.dceNumber = -1;
            this.dceAlias = string.Empty;
            this.dceName = string.Empty;


            InitializeComponent();

            #region Actions
            this.Load += new EventHandler(MainForm_Load);

            this.supplierNameTextBox.TextChanged += new EventHandler(supplierNameTextBox_TextChanged);
            this.supplierNameTextBox.Validating += new CancelEventHandler(supplierNameTextBox_Validating);

            this.contractNumberTextBox.TextChanged += new EventHandler(contractNumberTextBox_TextChanged);
            this.contractNumberTextBox.Validating += new CancelEventHandler(contractNumberTextBox_Validating);

            this.contractDateComboBox.TextChanged += new EventHandler(contractDateComboBox_TextChanged);
            this.contractDateComboBox.Validating += new CancelEventHandler(contractDateComboBox_Validating);
            this.contractDateComboBox.Format += new ListControlConvertEventHandler(minValueDate_Format);

            this.applicationNumberTextBox.TextChanged += new EventHandler(applicationNumberTextBox_TextChanged);
            this.applicationNumberTextBox.Validating += new CancelEventHandler(applicationNumberTextBox_Validating);

            this.applicationDateComboBox.TextChanged += new EventHandler(applicationDateComboBox_TextChanged);
            this.applicationDateComboBox.Validating += new CancelEventHandler(applicationDateComboBox_Validating);
            this.applicationDateComboBox.Format += new ListControlConvertEventHandler(minValueDate_Format);

            this.gkTextBox.TextChanged += new EventHandler(gkTextBox_TextChanged);
            this.gkTextBox.Validating += new CancelEventHandler(gkTextBox_Validating);

            this.orderTextBox.TextChanged += new EventHandler(orderTextBox_TextChanged);
            this.orderTextBox.Validating += new CancelEventHandler(orderTextBox_Validating);

            this.productIndexComboBox.TextChanged += new EventHandler(productIndexComboBox_TextChanged);
            this.productIndexComboBox.Validating += new CancelEventHandler(productIndexComboBox_Validating);
            this.productIndexComboBox.Format += new ListControlConvertEventHandler(emptyText_Format);
            
            this.productNumberComboBox.TextChanged += new EventHandler(productNumberComboBox_TextChanged);
            this.productNumberComboBox.Validating += new CancelEventHandler(productNumberComboBox_Validating);
            this.productNumberComboBox.Format += new ListControlConvertEventHandler(minusOneValue_Format);

            this.productAliasTextBox.TextChanged += new EventHandler(productAliasTextBox_TextChanged);
            this.productAliasTextBox.Validating += new CancelEventHandler(productAliasTextBox_Validating);

            this.productNameTextBox.TextChanged += new EventHandler(productNameTextBox_TextChanged);
            this.productNameTextBox.Validating += new CancelEventHandler(productNameTextBox_Validating);

            this.dceNumberComboBox.TextChanged += new EventHandler(dceNumberComboBox_TextChanged);
            this.dceNumberComboBox.Validating += new CancelEventHandler(dceNumberComboBox_Validating);
            this.dceNumberComboBox.Format += new ListControlConvertEventHandler(minusOneValue_Format);

            this.dceAliasTextBox.TextChanged += new EventHandler(dceAliasTextBox_TextChanged);
            this.dceAliasTextBox.Validating += new CancelEventHandler(dceAliasTextBox_Validating);

            this.dceNameTextBox.TextChanged += new EventHandler(dceNameTextBox_TextChanged);
            this.dceNameTextBox.Validating += new CancelEventHandler(dceNameTextBox_Validating);

            this.departmentComboBox.Format += new ListControlConvertEventHandler(emptyText_Format);

            this.clearButton.Click += new EventHandler(clearButton_Click);
            this.applyButton.Click += new EventHandler(applyButton_Click);


            this.cancelButton.Click += new EventHandler(cancelButton_Click);
            #endregion
        }



        private void dceNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var dceName = converter.TryParse(this.dceNameTextBox.Text);
            var currentDce = this.dceList.TryGetDceName(dceName);
        }

        private void dceNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var dceName = converter.Parse(this.dceNameTextBox.Text);
                this.dceList.GetDceNumber(dceNumber);
                this.dceName = dceName;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.dceNameTextBox.Text = converter.Format(dceName);
            }
        }

        private void dceAliasTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var dceAlias = converter.Parse(this.dceAliasTextBox.Text);
                this.dceList.GetDceAlias(dceAlias);
                this.dceAlias = dceAlias;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.dceAliasTextBox.Text = converter.Format(dceAlias);
            }
        }

        private void dceAliasTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var dceName = converter.TryParse(this.dceAliasTextBox.Text);
            var currentDce = this.dceList.TryGetDceAlias(dceAlias);
        }

        private void dceNumberComboBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new IntConverter();
            try
            {
                var dceNumber = converter.Parse(this.dceNumberComboBox.Text);
                this.dceList.GetDceNumber(dceNumber);
                this.dceNumber = dceNumber;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.dceNumberComboBox.Text = converter.Format(dceNumber);
            }
        }

        private void dceNumberComboBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new IntConverter();
            var dceNumber = converter.TryParse(this.dceNumberComboBox.Text);
            var currentDce = this.dceList.TryGetDceNumber(dceNumber);
            if (IsMatchingDigitRange(this.dceNumberComboBox.Text)) return;
            else this.dceNumberComboBox.SelectedItem = dceList.GetDceNumberList().First();
        }

        private void productNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var productName = converter.Parse(this.productNameTextBox.Text);
                this.productList.GetProductName(productName);
                this.productName = productName;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.productNameTextBox.Text = converter.Format(productName);
            }
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var productName = converter.TryParse(this.productNameTextBox.Text);
            var currentProduct = this.productList.TryGetProductName(productName);
        }

        private void productAliasTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var productAlias = converter.Parse(this.productAliasTextBox.Text);
                this.productList.GetProductAlias(productAlias);
                this.productAlias = productAlias;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.productAliasTextBox.Text = converter.Format(productAlias);
            }
        }

        private void productAliasTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var productAlias = converter.TryParse(this.productAliasTextBox.Text);
            var currentProduct = this.productList.TryGetProductAlias(productAlias);
        }

        private void productNumberComboBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new IntConverter();
            try
            {
                var productNumber = converter.Parse(this.productNumberComboBox.Text);
                this.productList.GetProductNumber(productNumber);
                this.productNumber = productNumber;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.productNumberComboBox.Text = converter.Format(productNumber);
            }
        }

        private void productNumberComboBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new IntConverter();
            var productNumber = converter.TryParse(this.productNumberComboBox.Text);
            var currentProduct = this.productList.TryGetProductNumber(productNumber);
            if (IsMatchingDigitRange(this.productNumberComboBox.Text)) return;
            else this.productNumberComboBox.SelectedItem = productList.GetProductNumberList().First();
        }

        private void productIndexComboBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new StrConverter();
            try
            {
                var productIndex = converter.Parse(this.productIndexComboBox.Text);
                this.productList.GetProductIndex(productIndex);
                this.productIndex = productIndex;
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message);
            }
            finally
            {
                this.productIndexComboBox.Text = converter.Format(productIndex);
            };
        }

        private void productIndexComboBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new StrConverter();
            var productIndex = converter.TryParse(this.productIndexComboBox.Text);
            var currentProduct = this.productList.TryGetProductIndex(productIndex);
        }

        private void orderTextBox_Validating(object sender, CancelEventArgs e)
        {
            var converter = new IntConverter();

            try
            {
                var orderNumber = converter.Parse(orderTextBox.Text);
                this.orderList.GetOrder(orderNumber);
                this.orderNumber = orderNumber;
                
            }
            catch (ApplicationException ex)
            {
                e.Cancel = true;
                Methods.ShowInfo(this, ex.Message); 
            }
            finally
            {
                this.orderTextBox.Text = converter.Format(this.orderNumber);  
            }
        }

        private void orderTextBox_TextChanged(object sender, EventArgs e)
        {
            var converter = new IntConverter();
            var orderNumber = converter.TryParse(orderTextBox.Text);
            var currentOrder = orderList.TryGetOrder(orderNumber);
            if (IsMatchingDigitRange(this.orderTextBox.Text)) return;
            else this.orderTextBox.Clear();
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

            this.orderList = OrderList.GetOrderList();
            this.orderTextBox.AutoCompleteCustomSource.AddRange(this.orderList.Select(x => x.OrderNumber.ToString()).ToArray());

            this.departmentComboBox.DataSource = this.applicationList.GetDepartmentList();

            this.productList = ProductList.GetProductList();
            this.productNumberComboBox.DataSource = this.productList.GetProductNumberList();
            this.productNumberComboBox.AutoCompleteCustomSource.AddRange(this.productList.Select(x => x.ProductNumber.ToString()).ToArray());
            this.productIndexComboBox.DataSource = this.productList.GetProductIndexList();
            this.productIndexComboBox.AutoCompleteCustomSource.AddRange(this.productList.Select(x => x.ProductIndex.Trim()).ToArray());
            this.productAliasTextBox.AutoCompleteCustomSource.AddRange(this.productList.Select(x => x.ProductAlias.Trim()).ToArray());
            this.productNameTextBox.AutoCompleteCustomSource.AddRange(this.productList.Select(x => x.ProductName.Trim()).ToArray());

            this.dceList = DceList.GetDceList();
            this.dceNumberComboBox.DataSource = this.dceList.GetDceNumberList();
            this.dceNumberComboBox.AutoCompleteCustomSource.AddRange(this.dceList.Select(x => x.DceNumber.ToString()).ToArray());
            this.dceAliasTextBox.AutoCompleteCustomSource.AddRange(this.dceList.Select(x => x.DceAlias.Trim()).ToArray());
            this.dceNameTextBox.AutoCompleteCustomSource.AddRange(this.dceList.Select(x => x.DceName.Trim()).ToArray());

        }
        

        private void minValueDate_Format(object sender, ListControlConvertEventArgs e)
        {
            Helpers.Methods.MinValueDateFormat(e);
        }

        void minusOneValue_Format(object sender, ConvertEventArgs e)
        {
            Helpers.Methods.MinusOneValueFormat(e);
        }

        void emptyText_Format(object sender, ListControlConvertEventArgs e)
        {
            Helpers.Methods.EmptyTextFormat(e);
        }

        void clearButton_Click (object sender,  EventArgs e)
        {
            this.supplierNameTextBox.Clear();
            this.contractNumberTextBox.Clear();
            this.contractDateComboBox.SelectedItem = this.contractList.GetContractDateList().First();
            this.applicationNumberTextBox.Clear();
            this.applicationDateComboBox.SelectedItem = this.applicationList.GetApplicationDateList().First();
            this.gkTextBox.Clear();
            this.orderTextBox.Clear();
            this.departmentComboBox.SelectedItem = this.applicationList.GetDepartmentList().First();
            this.productNumberComboBox.SelectedItem = this.productList.GetProductNumberList().First();
            this.productIndexComboBox.SelectedItem = this.productList.GetProductIndexList().First();
            this.productAliasTextBox.Clear();
            this.productNameTextBox.Clear();
            this.dceNumberComboBox.SelectedItem=this.dceList.GetDceNumberList().First();
            this.dceAliasTextBox.Clear();
            this.dceNameTextBox.Clear();

        }

        void applyButton_Click(object sender, EventArgs e)
        {
            if (!IsAnyFieldFilled(
                                  this.supplierName,
                                  this.contractNumber,
                                  this.contractDate,
                                  this.applicationNumber,
                                  this.applicationDate,
                                  this.department,
                                  this.stateContractNumber,
                                  this.orderNumber,
                                  this.productNumber,
                                  this.productIndex,
                                  this.productAlias,
                                  this.productName,
                                  this.dceNumber,
                                  this.dceAlias,
                                  this.dceName))
            {
                var messageText = Methods.SearchingCriteriaIsEmpty();
                Methods.ShowInfo(messageText);
                return;
            }
            else
                this.Criteria = this.CreateCriteria();

            var rows = SplashScreenForm.ExecuteAsync<IEnumerable<DataRow>>(this, this.GetCatalogRowsFromDB);
            if (!this.IsExistedInDB(rows)) return;
            this.Catalog = Catalog.CreateFrom(rows);
            var handler = this.GoToApplicationsAndContractsForm;
            if (handler != null) handler(this, EventArgs.Empty);

        }

        private bool IsExistedInDB(IEnumerable<DataRow> rows)
        {
            if (rows.Count() > 0) return true;
            var messageText = Methods.QueryIsOutOfRangeMessage();
            Methods.ShowInfo(messageText);
            return false;
        }

        private bool IsAnyFieldFilled(string supplierName,
                                      string contractNumber,
                                      DateTime contractDate,
                                      string applicationNumber,
                                      DateTime applicationDate,
                                      string department,
                                      string stateContractNumber,
                                      int orderNumber,
                                      int productNumber,
                                      string productIndex,
                                      string productAlias,
                                      string productName,
                                      int dceNumber,
                                      string dceAlias,
                                      string dceName)
        {
            if (this.supplierName == string.Empty &&
                this.contractNumber == string.Empty &&
                this.contractDate == DateTime.MinValue &&
                this.applicationNumber == string.Empty &&
                this.applicationDate == DateTime.MinValue &&
                this.stateContractNumber == string.Empty &&
                this.orderNumber == -1 &&
                this.productNumber == -1 &&
                this.productIndex == string.Empty &&
                this.productAlias == string.Empty &&
                this.productName == string.Empty &&
                this.dceNumber == -1 &&
                this.dceAlias == string.Empty &&
                this.dceName == string.Empty &&
                this.department == string.Empty)
            {

                return false;
            }
            else return true;
        }

        private Criteria CreateCriteria()
        {
            return Criteria.CreateFrom(this.supplierName,
                                      this.contractNumber,
                                      this.contractDate,
                                      this.applicationNumber,
                                      this.applicationDate,
                                      this.department,
                                      this.stateContractNumber,
                                      this.orderNumber,
                                      this.productNumber,
                                      this.productIndex,
                                      this.productAlias,
                                      this.productName,
                                      this.dceNumber,
                                      this.dceAlias,
                                      this.dceName);
        }

        private IEnumerable<DataRow> GetCatalogRowsFromDB()
        {
            return this.dataService.GetCatalog(this.Criteria);
        }

        void cancelButton_Click (object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

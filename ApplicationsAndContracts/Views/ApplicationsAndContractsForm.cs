using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationsAndContracts.DataAccess;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Views
{
    public partial class ApplicationsAndContractsForm : Form
    {

        private DataService dataService;
        private Criteria criteria;
        private Catalog catalog;
        private ApplicationCatalog applicationCatalog;
        private DceCatalog dceCatalog;
        private SupplierCatalog supplierCatalog;
        private ContractCatalog contractCatalog;


        private ApplicationCatalogItem applicationCatalogItem
        {
            get
            {
                if (this.applicationsBindingSource.Position < 0) return null;

                return this.applicationCatalog[this.applicationsBindingSource.Position];
                
            }
        }

        private SupplierCatalogItem supplierCatalogItem
        {
            get
            {
                if (this.suppliersBindingSource.Position < 0) return null;
                return this.supplierCatalog[this.suppliersBindingSource.Position];
            }
        }

        
        


        public ApplicationsAndContractsForm(Criteria criteria, Catalog catalog)
        {
            this.dataService = new DataService();
            this.criteria = criteria;
            this.catalog = catalog;

            InitializeComponent();

            this.Load += new EventHandler(ApplicationsAndContractsForm_Load);
            this.applicationsBindingSource.PositionChanged += new EventHandler(applicationBindingSource_PositionChanged);
            this.dceBindingSource.PositionChanged += new EventHandler(dceBindingSource_PositionChanged);
            this.suppliersBindingSource.PositionChanged += new EventHandler(suppliersBindingSource_PositionChanged);

            this.applicationsDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(applicationsDataGridView_CellFormating);
            this.suppliersDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(suppliersDataGridView_CellFormatting);

            this.detailedButton.Click += new EventHandler(detailedButton_Click);
        }

        private void suppliersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex<0) return;
            this.PaintRowsSupplier(e);
        }

        private void applicationsDataGridView_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex<0) return;
            
            this.FormatAndPaintRowsApplications(e);
        }

        private void suppliersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.GetContractCatalog();
        }

        private void applicationBindingSource_PositionChanged(object sender, EventArgs e)
        {

            this.GetDceCatalog();
            this.currentRecordNumberValueLabel.Text = (this.applicationsBindingSource.Position + 1).ToString();
            this.recordCountValueLabel1.Text = this.dceCatalog.Count.ToString();


        }

        private void dceBindingSource_PositionChanged(object sender, EventArgs e)
        {

            //this.GetDceCatalog();
                       
            this.currentRecordNumberValueLabel1.Text = (this.dceBindingSource.Position + 1).ToString();

        }


        private void ApplicationsAndContractsForm_Load(object sender, EventArgs e)
        {

            this.applicationCatalog = ApplicationCatalog.CreateFrom(catalog);
            this.applicationsBindingSource.DataSource= this.applicationCatalog;
            this.supplierCatalog = SupplierCatalog.CreateFrom(catalog);
            this.suppliersBindingSource.DataSource = this.supplierCatalog;

            this.recordCountValueLabel.Text = this.applicationCatalog.Count.ToString();
            this.currentRecordNumberValueLabel.Text = (this.applicationsBindingSource.Position + 1).ToString();

            this.recordCountValueLabel1.Text = this.dceCatalog.Count.ToString();
            this.currentRecordNumberValueLabel1.Text = (this.dceBindingSource.Position + 1).ToString();

        }

        private void GetContractCatalog()
        {
            if (this.catalog == null || this.supplierCatalog == null) return;
            this.contractCatalog = ContractCatalog.CreateFrom(this.catalog, this.supplierCatalogItem);
            this.contractsBindingSource.DataSource = this.contractCatalog;
        }


        private void GetDceCatalog() 
         {
            if (this.catalog == null || this.applicationCatalog == null) return;
            this.dceCatalog = DceCatalog.CreateFrom(this.catalog, this.applicationCatalogItem);
            this.dceBindingSource.DataSource = this.dceCatalog;
        }

        private void FormatAndPaintRowsApplications(DataGridViewCellFormattingEventArgs e)
        {
            var catalogItem = this.applicationCatalog[e.RowIndex];
            if (catalogItem == null) return;
            if (catalogItem.StateContract.ReasonId == 8 /*||
                catalogItem.StateContract.IdGoz == string.Empty ||
                catalogItem.StateContract.IdKazn == string.Empty*/) e.CellStyle.BackColor = this.colorPanel.BackColor;
            if (catalogItem.ApplicationStatus == 1) e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);

        }

        private void PaintRowsSupplier(DataGridViewCellFormattingEventArgs e)
        {
            var catalogItem = this.supplierCatalog[e.RowIndex];
            if (catalogItem == null) return;
            if (SupplierCatalog.IsApplicationsExecuted(catalogItem, this.catalog)) e.CellStyle.BackColor = this.colorPanel2.BackColor;
        }


        void detailedButton_Click(object sender, EventArgs e)
        {
            //var rows = SplashScreenForm.ExecuteAsync<IEnumerable<ApplicationCatalogItem>>(this, this.GetProductList);
            var detailedApplicationForm = new DetailedApplicationForm(this.applicationCatalogItem, this.catalog, this.dceCatalog);
            detailedApplicationForm.Show();

        }

        //private IEnumerable<ApplicationCatalogItem> GetProductList()
        //{
        //    ;
        //}

        void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }


}

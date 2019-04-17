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
        private CurrentContractCatalog currentContractCatalog;



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
            this.suppliersBindingSource.PositionChanged += new EventHandler(suppliersBindingSource_PositionChanged);
            this.applicationsDataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(applicationsDataGridView_CellFormating);
            
        }

        private void applicationsDataGridView_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex<0) return;


            this.FormatAndPaintRows(e);
        }

        private void suppliersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.GetContractCatalog();
        }

        private void applicationBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.GetDceCatalog();
        }

        private void ApplicationsAndContractsForm_Load(object sender, EventArgs e)
        {

            this.applicationCatalog = ApplicationCatalog.CreateFrom(catalog);
            this.applicationsBindingSource.DataSource= this.applicationCatalog;
            this.supplierCatalog = SupplierCatalog.CreateFrom(catalog);
            this.suppliersBindingSource.DataSource = this.supplierCatalog;
             
        }

        private void GetContractCatalog()
        {
            if (this.catalog == null || this.supplierCatalog == null) return;
            this.currentContractCatalog = CurrentContractCatalog.CreateFrom(this.catalog, this.supplierCatalogItem);
            this.contractsBindingSource.DataSource = this.currentContractCatalog;
        }


        private void GetDceCatalog() 
         {
            if (this.catalog == null || this.applicationCatalog == null) return;
            this.dceCatalog = DceCatalog.CreateFrom(this.catalog, this.applicationCatalogItem);
            this.dceBindingSource.DataSource = this.dceCatalog;
        }

        private void FormatAndPaintRows (DataGridViewCellFormattingEventArgs e)
        {
            var catalogItem = this.applicationCatalog[e.RowIndex];
            if (catalogItem == null) return;
            if (catalogItem.StateContract.ReasonId == 8 /*||
                catalogItem.StateContract.IdGoz == string.Empty ||
                catalogItem.StateContract.IdKazn == string.Empty*/) e.CellStyle.BackColor = this.colorPanel.BackColor;
            if (catalogItem.ApplicationStatus == 1) e.CellStyle.Font.Italic = true;/* = new Font (e.CellStyle.Font, e.CellStyle.Font.Italic==t); /*this.applicationsDataGridView.RowsDefaultCellStyle.Font=*/

        }



    }
}

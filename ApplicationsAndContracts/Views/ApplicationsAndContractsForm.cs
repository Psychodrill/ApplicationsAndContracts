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



        private ApplicationCatalogItem applicationCatalogItem
        {
            get
            {
                if (this.applicationsBindingSource.Position < 0) return null;

                return this.applicationCatalog[this.applicationsBindingSource.Position];
                
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


        private void GetDceCatalog() 
         {
            if (this.catalog == null || this.applicationCatalog == null) return;
            this.dceCatalog = DceCatalog.CreateFrom(this.catalog, this.applicationCatalogItem);
            this.dceBindingSource.DataSource = this.dceCatalog;
        }

    }
}

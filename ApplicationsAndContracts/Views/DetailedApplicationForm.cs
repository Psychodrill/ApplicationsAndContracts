using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationsAndContracts.Models;
using ApplicationsAndContracts.DataAccess;

namespace ApplicationsAndContracts.Views
{

    //test string change1
    
        //test string change2
        //test strint change3
    public partial class DetailedApplicationForm : Form
    {
        private DataService dataService;
        private ProductCatalog productCatalog;
        private DceCatalog dceCatalog;
        private Catalog catalog;
        private ApplicationCatalogItem applicationCatalogItem;

        private ProductCatalogItem productCatalogItem
        {
            get
            {
                if (this.productsBindingSource.Position < 0) return null;

                return this.productCatalog[this.productsBindingSource.Position];

            }
        }

        public DetailedApplicationForm(ApplicationCatalogItem applicationCatalogItem, Catalog catalog, DceCatalog dceCatalog)
        {
            this.applicationCatalogItem = applicationCatalogItem;
            this.catalog = catalog;

            InitializeComponent();
            this.Load += new EventHandler(DetailedApplicationForm_Load);

            this.productsBindingSource.PositionChanged += new EventHandler(productsBindingSource_PositionChanged);
           
        }



        private void DetailedApplicationForm_Load(object sender, EventArgs e)
        {
            this.applicationNumberTextBox.Text = applicationCatalogItem.ApplicationNumber;
            this.applicationDateTextBox.Text = applicationCatalogItem.ApplicationDate.ToShortDateString();
            this.supplierNameTextBox.Text = applicationCatalogItem.SupplierName;
            this.contractNumberTextBox.Text = applicationCatalogItem.ContractNumber;
            this.contractDateTextBox.Text = applicationCatalogItem.ContractDate.ToShortDateString();
            this.stateContractNumberTextBox.Text = applicationCatalogItem.StateContractNumber;

            this.productCatalog = ProductCatalog.CreateFrom(catalog, applicationCatalogItem);

            //this.productCatalog = ProductCatalog.CreateFrom(applicationCatalogItem);
            this.productsBindingSource.DataSource = this.productCatalog;



        }

        private void productsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            GetDceCatalog();
            
        }

        private void GetDceCatalog()
        {
            if (this.catalog==null||this.applicationCatalogItem == null) return;
            this.dceCatalog = DceCatalog.CreateFrom(this.catalog, this.applicationCatalogItem, this.productCatalogItem);
            this.dceBindingSource.DataSource = this.dceCatalog;
        }
    }
}

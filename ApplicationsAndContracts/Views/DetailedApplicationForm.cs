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
    public partial class DetailedApplicationForm : Form
    {
        private DataService dataService;
        private ProductCatalog productCatalog;
        private DceCatalog dceCatalog;
        private ApplicationCatalogItem applicationCatalogItem;
        public DetailedApplicationForm(ApplicationCatalogItem applicationCatalogItem)
        {
            this.applicationCatalogItem = applicationCatalogItem;
            //this.productCatalog = new ProductCatalog();
            //this.dceCatalog = new DceCatalog();

            InitializeComponent();
            this.Load += new EventHandler(DetailedApplicationForm_Load);
           
        }

        private void DetailedApplicationForm_Load(object sender, EventArgs e)
        {
            this.applicationNumberTextBox.Text = applicationCatalogItem.ApplicationNumber;
            this.applicationDateTextBox.Text = applicationCatalogItem.ApplicationDate.ToShortDateString();
            this.supplierNameTextBox.Text = applicationCatalogItem.SupplierName;
            this.contractNumberTextBox.Text = applicationCatalogItem.ContractNumber;
            this.contractDateTextBox.Text = applicationCatalogItem.ContractDate.ToShortDateString();
            this.stateContractNumberTextBox.Text = applicationCatalogItem.StateContractNumber;


            this.productCatalog = ProductCatalog.CreateFrom(applicationCatalogItem);



        }
    }
}

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
        public ApplicationsAndContractsForm(Criteria criteria, Catalog catalog)
        {
            this.dataService = new DataService();
            this.criteria = criteria;
            this.catalog = catalog;

            InitializeComponent();

            this.Load += new EventHandler(ApplicationsAndContractsForm_Load);
        }

        private void ApplicationsAndContractsForm_Load(object sender, EventArgs e)
        {
            this.applicationsBindingSource.DataSource= this.catalog;
        }
    }
}

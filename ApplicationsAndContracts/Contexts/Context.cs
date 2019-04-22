using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationsAndContracts.Views;

namespace ApplicationsAndContracts.Contexts
{
    public class Context:ApplicationContext
    {
        public Context()
        {
            var mainForm = new MainForm();
            mainForm.GoToApplicationsAndContractsForm += new EventHandler(mainForm_GoToApplicationsAndContractsForm);
            this.MainForm = mainForm;
        }

        private void mainForm_GoToApplicationsAndContractsForm(object sender, EventArgs e)
        {
            var mainForm = (MainForm)sender;
            var ApplicationsAndContractsForm = new ApplicationsAndContractsForm(mainForm.Criteria, mainForm.Catalog);
            ApplicationsAndContractsForm.FormClosing += new FormClosingEventHandler(ApplicationsAndContractsForm_FormClosing);
            this.MainForm = ApplicationsAndContractsForm;
            this.MainForm.Show();
            mainForm.Hide();
            
        }

        //private void applicationsAndContractsForm_GoToDetailedApplicationForm(object sender, EventArgs e)
        //{
        //    var applicationsAndContractsForm = (ApplicationsAndContractsForm)sender;
        //    var DetailedApplicationForm = new DetailedApplicationForm(applicationsAndContractsForm)
        //}

        private void ApplicationsAndContractsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var ApplicationsAndContractsForm = (ApplicationsAndContractsForm)sender;
            var mainForm = (MainForm)Application.OpenForms["MainForm"];
            this.MainForm = mainForm;
            ApplicationsAndContractsForm.FormClosing -= new FormClosingEventHandler(ApplicationsAndContractsForm_FormClosing);
            ApplicationsAndContractsForm.Close();
            MainForm.Show();
        }
    }
}

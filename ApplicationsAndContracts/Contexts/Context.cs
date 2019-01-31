using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationsAndContracts.Contexts
{
    class Context:ApplicationContext
    {
        public Context()
        {
            var mainForm = new MainForm();
            this.MainForm = mainForm;
        }
    }
}

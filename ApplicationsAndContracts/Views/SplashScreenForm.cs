using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationsAndContracts.Views
{
    public partial class SplashScreenForm : Form
    {
        public Task<object> AsyncTask { get; private set; }


        public SplashScreenForm(Func<object> method)
        {
            InitializeComponent();
            this.AsyncTask = Task.Factory.StartNew(method);
            this.AsyncTask.ContinueWith(task => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        public static T ExecuteAsync<T>(Form owner, Func<object> method)
        {
            var splashScreenForm = new SplashScreenForm(method);
            splashScreenForm.ShowDialog(owner);
            return (T)splashScreenForm.AsyncTask.Result;
        }
    }
}

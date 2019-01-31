using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
 


namespace ApplicationsAndContracts.Helpers
{
    class Methods
    {
        /// <summary>
        /// Set Language
        /// </summary>
        /// <returns></returns>
       public static InputLanguage SetRussianLanguage()
        {
            return InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        }
        
        //public static void AllowPressKeys(KeyEventArgs e)
        //{
        //    e.Handled = ((!Char.IsDigit(e.)) && (!Char.IsControl(e.KeyChar)));
        //} 

        /// <summary>
        /// describes show dialog messagebox
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="text"></param>
        public static void ShowInfo(Form owner, string text)
        {
            MessageBox.Show(owner, text, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// describes showinfo dialog messagebox
        /// </summary>
        /// <param name="text"></param>
        public static void ShowInfo( string text)
        {
            MessageBox.Show(text, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       /// <summary>
       /// describes showquestion dialog messagebox
       /// </summary>
       /// <param name="text"></param>
       /// <returns></returns>
        public static bool ShowQuestion(string text)
        {
            var dResult = MessageBox.Show(text, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dResult==DialogResult.Yes;
        }

        /// <summary>
        /// Clear combocox
        /// </summary>
        /// <param name="control"></param>
        public static void ClearComboBox (object control)
        {
            var cmbBox = control as ComboBox;
            if (cmbBox == null) return;
            if (cmbBox.Items.Count > 0) cmbBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Clear textbox
        /// </summary>
        /// <param name="control"></param>
        public static void ClearTextBoxes (object control)
        {
            var txtBox = control as TextBox;
            if (txtBox == null) return;
            txtBox.Clear();
        }
        /// <summary>
        /// Checking and assigned value when it -1
        /// </summary>
        /// <param name="e"></param>
        public static void MinusOneValueFormat(ConvertEventArgs e)
        {
            if (Convert.ToInt32(e.Value)==-1) 
                e.Value = Resources.UnselectedText;
        }
        /// <summary>
        /// Checking and assigned value when it 255
        /// </summary>
        /// <param name="e"></param>
        public static void TwoHundredFiftyFiveValueFormat(ConvertEventArgs e)
        {
            if (Convert.ToInt16(e.Value) == 255)
                e.Value = Resources.UnselectedText;
        }
        /// <summary>
        /// Checking and assigned value when it empty
        /// </summary>
        /// <param name="e"></param>
        public static void EmptyTextFormat(ConvertEventArgs e)
        {
            if (e.Value.ToString() == "")
                e.Value = Resources.UnselectedText;
        }
        /// <summary>
        /// Show dialog messagebox "query is out of range"
        /// </summary>
        /// <returns></returns>
        public static string QueryIsOutOfRangeMessage()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Resources.QueryIsOutOfRangeText);
            sb.AppendLine(Resources.ChangeQueryText);
            return sb.ToString();
        }
        /// <summary>
        /// Show dialog messagebox "searching criteria is empty"
        /// </summary>
        /// <returns></returns>
        public static string SearchingCriteriaIsEmpty()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Resources.EmptySearchingCriteriaText);
            sb.AppendLine(Resources.ChangeQueryText);
            return sb.ToString();
        }

    }
}

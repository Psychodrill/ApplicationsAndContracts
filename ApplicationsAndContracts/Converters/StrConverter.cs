using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Converters
{
    class StrConverter
    {
        public string Parse(string value)
        {
            if (value == null || value == "" || value == Resources.UnselectedText) return "";// Resources.unselectedText;
            else return value.Trim();
            //throw new ApplicationException(Resources.IncorrectValueText);
        }

        public string TryParse(string value)
        {
            try
            {
                return Parse(value);
            }
            catch (ApplicationException)
            {
                return "";
            }
        }

        public string Format(string value)
        {
            if (value == "") return Resources.UnselectedText;
            return value;
        }
    }
}

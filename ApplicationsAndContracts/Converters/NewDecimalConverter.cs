using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Converters
{
    class NewDecimalConverter
    {
        public decimal Parse(string value)
        {
            if (value == null || value == "" || value == Resources.UnselectedText) return -1;
            decimal result = 0;
            if (decimal.TryParse(value, out result)) return result;
            throw new ApplicationException(Resources.IncorrectValueText);
        }

        public decimal TryParse(string value)
        {
            try
            {
                return Parse(value);
            }
            catch (ApplicationException)
            {
                return -1;
            }
        }

        public string Format(decimal value)
        {
            if (value == -1) return "";
            return value.ToString();
        }
    }
}

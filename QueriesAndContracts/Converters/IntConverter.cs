using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Converters
{
    public class IntConverter
    {
        public int Parse(string value)
        {
            if (value == null || value == "" || value == Resources.UnselectedText) return -1;
            int result = 0;
            if (int.TryParse(value, out result)) return result;
            throw new ApplicationException(Resources.IncorrectValueText);
        }

        public int TryParse(string value)
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

        public string Format(int value)
        {
            if (value == -1) return "";
            return value.ToString();
        }
    }
}
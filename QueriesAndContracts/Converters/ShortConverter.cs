using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Converters
{
    class ShortConverter
    {
        public short Parse(string value)
        {
            if (value == null || value == "" || value == Resources.UnselectedText) return -1;
            short result = 0;
            if (short.TryParse(value, out result)) return result;
            throw new ApplicationException(Resources.IncorrectValueText);
        }

        public short TryParse(string value)
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

        public string Format(short value)
        {
            if (value == -1) return Resources.UnselectedText;
            return value.ToString();
        }
    }
}

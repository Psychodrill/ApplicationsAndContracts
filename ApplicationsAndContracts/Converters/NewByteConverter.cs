using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Converters
{
    class NewByteConverter
    {
        public byte Parse(string value)
        {
            if (value == null || value == "" || value == Resources.UnselectedText) return 255;
            byte result = 0;
            if (byte.TryParse(value, out result)) return result;
            throw new ApplicationException(Resources.IncorrectValueText);
        }

        public byte TryParse(string value)
        {
            try
            {
                return Parse(value);
            }
            catch (ApplicationException)
            {
                return 255;
            }
        }

        public string Format(byte value)
        {
            if (value == 255) return Resources.UnselectedText;
            return value.ToString();
        }
    }
}

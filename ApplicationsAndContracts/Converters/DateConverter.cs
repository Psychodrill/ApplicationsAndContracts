using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Converters
{
    public class DateConverter
    {
        public DateTime Parse(string value)
        {
            if (value == null || value == string.Empty || value == Resources.UnselectedText)
                return DateTime.MaxValue;
            else
            {
                try
                {
                   return Convert.ToDateTime(value);
                }
                catch (Exception)
                {
                   return DateTime.MaxValue;
                }
            }

        }

        public DateTime TryParse(string value)
        {
            try
            {
                return Parse(value);
            }
            catch (ApplicationException)
            {
                return DateTime.MaxValue;
            }
        }


        public string Format(DateTime value)
        {
            if (value == DateTime.MaxValue) return Resources.UnselectedText;
            return value.ToShortDateString();
            //throw new ApplicationException(Resources.IncorrectValueText);
        }



    }
}

﻿using System;
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
        //public DateTime Parse(DateTime value)
        //{
        //    if (value == null || value == string.Empty || value == Resources.UnselectedText)
        //        return DateTime.MinValue;
        //    //DateTime result = DateTime.MinValue;
        //    //if (DateTime.TryParse(value.ToShortDateString(), out result)) return result;
        //    else return Convert.ToDateTime(value);
        //    throw new ApplicationException(Resources.IncorrectValueText);
        //}



        //public DateTime TryParse(DateTime value)
        //{
        //    try
        //    {
        //        return Parse(value);
        //    }
        //    catch (ApplicationException)
        //    {
        //        return DateTime.MinValue;
        //    }
        //}

        public string Parse(string value)
        {
            if (value == null || value == string.Empty || value == Resources.UnselectedText)
                return string.Empty;
            else  return value;
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
                return string.Empty;
            }
        }

        public string Format(DateTime value)
        {
            if (value == DateTime.MinValue) return Resources.UnselectedText;
            return value.ToShortDateString();
            //throw new ApplicationException(Resources.IncorrectValueText);
        }


        private bool IsDataTypeRange(string textparameter)
        {
            Regex filter = new Regex(@"\d\b\d?");
            return filter.IsMatch(textparameter);

        }

    }
}

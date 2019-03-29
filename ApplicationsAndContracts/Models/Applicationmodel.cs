using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 



namespace ApplicationsAndContracts.Models
{
    public class Applicationmodel
    {
        public static Applicationmodel CreateFrom(DataRow row)
        {
            var result = new Applicationmodel();
            result.ApplicationNumber = row.Field<string>("ApplicationNumber");
            result.ApplicationDate = row.Field<DateTime>("ApplicationDate");
            result.ApplicationStatus = row.Field<byte>("ApplicationStatus");
            return result;
        }


        Applicationmodel()
        {

        }

        public static Applicationmodel Empty()
        {
            var result = new Applicationmodel();
            result.ApplicationNumber = string.Empty;
            result.ApplicationDate = DateTime.MinValue;
            result.ApplicationStatus = 255;
            return result;
        }
                
        public string ApplicationNumber { get; private set; }
        public DateTime ApplicationDate { get; private set; }
        public byte ApplicationStatus { get; private set; }
    }
}

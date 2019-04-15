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
            result.ApplicationId = row.Field<int>("ApplicationId");
            result.ApplicationNumber = row.Field<string>("ApplicationNumber");
            result.ApplicationDate = row.Field<DateTime>("ApplicationDate");
            result.StateContractId = row.Field<int>("StateContractId");
            result.ApplicationStatus = row.Field<byte>("ApplicationStatus");
            result.Department = row.Field<string>("Department");
            return result;
        }

        public static Applicationmodel CreateFrom(ApplicationCatalogItem applicationCatalogItem)
        {
            var result = new Applicationmodel();
            result.ApplicationId = applicationCatalogItem.ApplicationId;
            result.ApplicationNumber = applicationCatalogItem.ApplicationNumber;
            result.ApplicationDate = applicationCatalogItem.ApplicationDate;
            result.ApplicationStatus = applicationCatalogItem.ApplicationStatus;
            result.Department = applicationCatalogItem.Department;
            return result;
        }

        public static Applicationmodel CreateFrom(CatalogItem catalogItem)
        {
            var result = new Applicationmodel();
            result.ApplicationId = catalogItem.ApplicationId;
            result.ApplicationNumber = catalogItem.ApplicationNumber;
            result.ApplicationDate = catalogItem.ApplicationDate;
            result.ApplicationStatus = catalogItem.ApplicationStatus;
            result.Department = catalogItem.Department;
            return result;
        }


        Applicationmodel()
        {

        }

        public static Applicationmodel Empty()
        {
            var result = new Applicationmodel();
            result.ApplicationId = -1;
            result.ApplicationNumber = string.Empty;
            result.ApplicationDate = DateTime.MaxValue;
            result.StateContractId = -1;
            result.ApplicationStatus = 255;
            result.Department = string.Empty;
            return result;
        }
        
        public int ApplicationId { get; private set; }        
        public string ApplicationNumber { get; private set; }
        public DateTime ApplicationDate { get; private set; }
        public int StateContractId { get; private set; }
        public byte ApplicationStatus { get; private set; }

        public string Department { get; private set; }
    }
}

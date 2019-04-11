using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
    public class CatalogItem
    {
        public static CatalogItem CreateFrom(DataRow row)
        {
            var result = new CatalogItem();

            result.ApplicationCatalogItem = ApplicationCatalogItem.CreateFrom(row);
            return result;
        }















        public ApplicationCatalogItem ApplicationCatalogItem { get; private set; }
        







        public string ApplicationNumber { get { return this.ApplicationCatalogItem.ApplicationNumber; } }
        public DateTime ApplicationDate { get { return this.ApplicationCatalogItem.ApplicationDate; } }
        public byte ApplicationStatus { get {return this.ApplicationCatalogItem.ApplicationStatus; } }

        public string Department { get { return this.ApplicationCatalogItem.Department; } }
        public string SupplierName { get { return this.ApplicationCatalogItem.SupplierName; } }
        public string ContractNumber { get { return this.ApplicationCatalogItem.ContractNumber; } }
        public DateTime ContractDate { get { return this.ApplicationCatalogItem.ContractDate; } }
        public string StateContractNumber { get { return this.ApplicationCatalogItem.StateContractNumber; } }
    }

}

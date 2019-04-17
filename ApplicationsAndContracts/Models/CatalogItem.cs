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
            result.Dce = Dce.CreateFrom(row);
            result.SupplierCatalogItem = SupplierCatalogItem.CreateFrom(row);
            result.CurrentContractCatalogItem = CurrentContractCatalogItem.CreateFrom(row);

            return result;
        }




        



        public ApplicationCatalogItem ApplicationCatalogItem { get; private set; }
        //public DceQuantityCatalogItem DceQuantityCatalogItem { get; private set; }
        public Dce Dce { get; private set; }
        public SupplierCatalogItem SupplierCatalogItem { get; private set; }
        public CurrentContractCatalogItem CurrentContractCatalogItem { get; private set; }






        public string ApplicationNumber { get { return this.ApplicationCatalogItem.ApplicationNumber; } }
        public DateTime ApplicationDate { get { return this.ApplicationCatalogItem.ApplicationDate; } }
        public byte ApplicationStatus { get {return this.ApplicationCatalogItem.ApplicationStatus; } }

        public string Department { get { return this.ApplicationCatalogItem.Department; } }
        public string SupplierName { get { return this.ApplicationCatalogItem.SupplierName; } }
        public int ContractId { get { return this.ApplicationCatalogItem.ContractId; } }
        public string ContractNumber { get { return this.ApplicationCatalogItem.ContractNumber; } }
        public DateTime ContractDate { get { return this.ApplicationCatalogItem.ContractDate; } }
        public int StateContractId { get { return this.ApplicationCatalogItem.StateContractId; } }
        public string StateContractNumber { get { return this.ApplicationCatalogItem.StateContractNumber; } }
        public int ApplicationId { get { return this.Dce.ApplicationId; } }
        public int DceNumber { get { return this.Dce.DceNumber; } }
        public string DceAlias { get { return this.Dce.DceAlias; } }
        public string DceName { get { return this.Dce.DceName; } }
        public decimal Quantity { get { return this.Dce.Quantity; } }

    }

}

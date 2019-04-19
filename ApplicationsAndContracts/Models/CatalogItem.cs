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
        //public static CatalogItem CreateFrom(DataRow row)
        //{
        //    var result = new CatalogItem();

        //    result.ApplicationCatalogItem = ApplicationCatalogItem.CreateFrom(row);
        //    result.Dce = Dce.CreateFrom(row);
        //    result.SupplierCatalogItem = SupplierCatalogItem.CreateFrom(row);
        //    result.CurrentContractCatalogItem = CurrentContractCatalogItem.CreateFrom(row);

        //    return result;
        //}

        public static CatalogItem CreateFrom(DataRow row)
        {
            var result = new CatalogItem();

            result.Applicationmodel = Applicationmodel.CreateFrom(row);
            result.Dce = Dce.CreateFrom(row);
            result.DceQuantity = DceQuantity.CreateFrom(row);
            result.Supplier = Supplier.CreateFrom(row);
            result.Contract = Contract.CreateFrom(row);
            result.StateContract = StateContract.CreateFrom(row);

            return result;
        }








        public Applicationmodel Applicationmodel { get; private set; }
        //public DceQuantityCatalogItem DceQuantityCatalogItem { get; private set; }
        public Dce Dce { get; private set; }
        public DceQuantity DceQuantity{ get; private set; }
        public Supplier Supplier { get; private set; }
        public Contract Contract { get; private set; }
        public StateContract StateContract { get; private set; }
        //public CurrentContractCatalogItem CurrentContractCatalogItem { get; private set; }





        public int ApplicationId { get { return this.Applicationmodel.ApplicationId; } }
        public string ApplicationNumber { get { return this.Applicationmodel.ApplicationNumber; } }
        public DateTime ApplicationDate { get { return this.Applicationmodel.ApplicationDate; } }
        public byte ApplicationStatus { get {return this.Applicationmodel.ApplicationStatus; } }
        public string Department { get { return this.Applicationmodel.Department; } }

        public int SupplierCode { get { return this.Supplier.SupplierCode; } }
        public string SupplierName { get { return this.Supplier.SupplierName; } }

        public int ContractId { get { return this.Contract.ContractId; } }
        public string ContractNumber { get { return this.Contract.ContractNumber; } }
        public DateTime ContractDate { get { return this.Contract.ContractDate; } }

        public int StateContractId { get { return this.StateContract.StateContractId; } }
        public string StateContractNumber { get { return this.StateContract.StateContractNumber; } }
        public int ReasonId { get { return this.StateContract.ReasonId; } }
        public string IdGoz { get { return this.StateContract.IdGoz; } }
        public string IdKazn { get { return this.StateContract.IdKazn; } }


        public int DceNumber { get { return this.Dce.DceNumber; } }
        public string DceAlias { get { return this.Dce.DceAlias; } }
        public string DceName { get { return this.Dce.DceName; } }
        public decimal Quantity { get { return this.DceQuantity.Quantity; } }

    }

}

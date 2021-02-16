using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class ContractCatalogItem
    {
        //public static CurrentContractCatalogItem CreateFrom(DataRow row)
        //{
        //    var result = new CurrentContractCatalogItem();
        //    result.Refresh(row);
        //    return result;
        //}

        //public static CurrentContractCatalogItem CreateFrom(CurrentContractCatalogItem currentContractCatalogItem)
        //{
        //    var result = new CurrentContractCatalogItem();
        //    //result.Refresh(currentContractCatalogItem);
        //    return result;
        //}

        public static ContractCatalogItem CreateFrom(CatalogItem catalogItem)
        {
            var result = new ContractCatalogItem();
            result.Refresh(catalogItem);
            return result;
        }

        //public void Refresh(DataRow row)
        //{
        //    this.Applicationmodel = Applicationmodel.CreateFrom(row);
        //    //this.Supplier = Supplier.CreateFrom(row);
        //    //this.Contract = Contract.CreateFrom(row);
        //    this.StateContract = StateContract.CreateFrom(row);
        //}

        //public void Refresh(ApplicationCatalogItem applicationCatalogItem)
        //{
        //    this.Applicationmodel = Applicationmodel.CreateFrom(applicationCatalogItem);
        //    //this.Supplier = Supplier.CreateFrom(applicationCatalogItem);
        //    //this.Contract = Contract.CreateFrom(applicationCatalogItem);
        //    this.StateContract = StateContract.CreateFrom(applicationCatalogItem);

        //}        public override bool Equals(object obj)

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var item = (ContractCatalogItem)obj;
            if (this.ApplicationNumber != item.ApplicationNumber) return false;
            if (this.ApplicationDate != item.ApplicationDate) return false;
            if (this.StateContractNumber != item.StateContractNumber) return false;
            if (this.ApplicationStatus != item.ApplicationStatus) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var sb = new StringBuilder();

            sb.Append(this.ApplicationNumber);
            sb.Append(this.ApplicationDate);
            sb.Append(this.StateContractNumber);
            sb.Append(this.ApplicationStatus);
            return sb.ToString().GetHashCode();
        }

    

        public void Refresh(CatalogItem catalogItem)
        {
            this.Applicationmodel = Applicationmodel.CreateFrom(catalogItem);
            //this.Supplier = Supplier.CreateFrom(catalogItem);
            //this.Contract = Contract.CreateFrom(catalogItem);
            this.StateContract = StateContract.CreateFrom(catalogItem);

        }


        public Applicationmodel Applicationmodel { get; private set; }
        //public Supplier Supplier { get; private set; }
        //public Contract Contract { get; private set; }
        public StateContract StateContract { get; private set; }


        //public int ApplicationId { get { return this.Applicationmodel.ApplicationId; } }
        public string ApplicationNumber { get { return this.Applicationmodel.ApplicationNumber; } }
        public DateTime ApplicationDate { get { return this.Applicationmodel.ApplicationDate; } }
        //public int StateContractId {get { return this.Applicationmodel.StateContractId; }}
        public byte ApplicationStatus { get { return this.Applicationmodel.ApplicationStatus; } }
        //public string Department { get { return this.Applicationmodel.Department; } }
        //public string SupplierName { get { return this.Supplier.SupplierName; } }
        //public string ContractNumber { get { return this.Contract.ContractNumber; } }
        //public DateTime ContractDate { get { return this.Contract.ContractDate; } }
        public string StateContractNumber { get { return this.StateContract.StateContractNumber; } }

    }
}

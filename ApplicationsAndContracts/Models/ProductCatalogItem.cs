using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class ProductCatalogItem
    {
        //public static ProductCatalogItem CreateFrom(Product product)
        //{
        //    var result = new ProductCatalogItem();
        //    result.Refresh(catalogItem);
        //    return result;
        //}



        public void Refresh(CatalogItem catalogItem)
        {
            this.Applicationmodel = Applicationmodel.CreateFrom(catalogItem);
            this.Supplier = Supplier.CreateFrom(catalogItem);
            this.Contract = Contract.CreateFrom(catalogItem);
            this.StateContract = StateContract.CreateFrom(catalogItem);

        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var item = (ApplicationCatalogItem)obj;
            if (this.ApplicationNumber != item.ApplicationNumber) return false;
            if (this.ApplicationDate != item.ApplicationDate) return false;
            if (this.SupplierName != item.SupplierName) return false;
            if (this.ContractNumber != item.ContractNumber) return false;
            if (this.ContractDate != item.ContractDate) return false;
            if (this.StateContractNumber != item.StateContractNumber) return false;
            if (this.ApplicationStatus != item.ApplicationStatus) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var sb = new StringBuilder();

            sb.Append(this.ApplicationNumber);
            sb.Append(this.ApplicationDate);
            sb.Append(this.SupplierName);
            sb.Append(this.ContractNumber);
            sb.Append(this.ContractDate);
            sb.Append(this.StateContractNumber);
            sb.Append(this.ApplicationStatus);
            return sb.ToString().GetHashCode();
        }




        public Applicationmodel Applicationmodel { get; private set; }
        public Supplier Supplier { get; private set; }
        public Contract Contract { get; private set; }
        public StateContract StateContract { get; private set; }


        public int ApplicationId { get { return this.Applicationmodel.ApplicationId; } }
        public string ApplicationNumber { get { return this.Applicationmodel.ApplicationNumber; } }
        public DateTime ApplicationDate { get { return this.Applicationmodel.ApplicationDate; } }
        //public int StateContractId { get { return this.Applicationmodel.StateContractId; } }
        public byte ApplicationStatus { get { return this.Applicationmodel.ApplicationStatus; } }
        public string Department { get { return this.Applicationmodel.Department; } }
        public string SupplierName { get { return this.Supplier.SupplierName; } }
        public int ContractId { get { return this.Contract.ContractId; } }
        public string ContractNumber { get { return this.Contract.ContractNumber; } }
        public DateTime ContractDate { get { return this.Contract.ContractDate; } }
        public int StateContractId { get { return this.StateContract.StateContractId; } }
        public string StateContractNumber { get { return this.StateContract.StateContractNumber; } }
        public int ReasonId { get { return this.StateContract.ReasonId; } }
        public string IdGoz { get { return this.StateContract.IdGoz; } }
        public string IdKazn { get { return this.StateContract.IdKazn; } }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class SupplierCatalogItem
    {
        //public static SupplierCatalogItem CreateFrom(DataRow row)
        //{
        //    var result = new SupplierCatalogItem();
        //    result.Refresh(row);
        //    return result;
        //}

        //public static SupplierCatalogItem CreateFrom(SupplierCatalogItem supplierCatalogItem)
        //{
        //    var result = new SupplierCatalogItem();
        //    result.Refresh(supplierCatalogItem);
        //    return result;
        //}

        public static SupplierCatalogItem CreateFrom(CatalogItem catalogItem)
        {
            var result = new SupplierCatalogItem();
            result.Refresh(catalogItem);
            return result;
        }

        //public void Refresh(DataRow row)
        //{
        //    this.Applicationmodel = Applicationmodel.CreateFrom(row);
        //    this.Supplier = Supplier.CreateFrom(row);
        //    this.Contract = Contract.CreateFrom(row);
        //    this.StateContract = StateContract.CreateFrom(row);
        //}

        //public void Refresh(SupplierCatalogItem supplierCatalogItem)
        //{
        //    //this.Applicationmodel = Applicationmodel.CreateFrom(applicationCatalogItem);
        //    this.Supplier = Supplier.CreateFrom(supplierCatalogItem);
        //    this.Contract = Contract.CreateFrom(supplierCatalogItem);
        //    this.StateContract = StateContract.CreateFrom(supplierCatalogItem);

        //}

        public void Refresh(CatalogItem catalogItem)
        {
            //this.Applicationmodel = Applicationmodel.CreateFrom(catalogItem);
            this.Supplier = Supplier.CreateFrom(catalogItem);
            this.Contract = Contract.CreateFrom(catalogItem);
            this.StateContract = StateContract.CreateFrom(catalogItem);

        }



        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var item = (SupplierCatalogItem)obj;
            if (this.SupplierName != item.SupplierName) return false;
            if (this.ContractId != item.ContractId) return false;
            if (this.ContractNumber != item.ContractNumber) return false;
            if (this.ContractDate != item.ContractDate) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var sb = new StringBuilder();

            sb.Append(this.SupplierName);
            sb.Append(this.ContractId);
            sb.Append(this.ContractNumber);
            sb.Append(this.ContractDate);
            return sb.ToString().GetHashCode();
        }


        //public Applicationmodel Applicationmodel { get; private set; }
        public Supplier Supplier { get; private set; }
        public Contract Contract { get; private set; }
        public StateContract StateContract { get; private set; }


        //public int ApplicationId { get { return this.Applicationmodel.ApplicationId; } }
        //public string ApplicationNumber { get { return this.Applicationmodel.ApplicationNumber; } }
        //public DateTime ApplicationDate { get { return this.Applicationmodel.ApplicationDate; } }
        //public byte ApplicationStatus { get { return this.Applicationmodel.ApplicationStatus; } }
        //public string Department { get { return this.Applicationmodel.Department; } }
        //public int SupplierCode { get { return this.Supplier.SupplierCode; } }
        public string SupplierName { get { return this.Supplier.SupplierName; } }
        public int ContractId { get { return this.Contract.ContractId; } }
        public string ContractNumber { get { return this.Contract.ContractNumber; } }
        public DateTime ContractDate { get { return this.Contract.ContractDate; } }
        public int StateContractId { get { return this.StateContract.StateContractId; } }
        //public string StateContractNumber { get { return this.StateContract.StateContractNumber; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
    public class ApplicationCatalogItem
    {
        public static ApplicationCatalogItem CreateFrom(DataRow row)
        {
            var result = new ApplicationCatalogItem();
            result.Refresh(row);
            return result;
        }

        public void Refresh(DataRow row)
        {
            this.Applicationmodel = Applicationmodel.CreateFrom(row);
            this.Supplier = Supplier.CreateFrom(row);
            this.Contract = Contract.CreateFrom(row);
            this.StateContract = StateContract.CreateFrom(row);
        }



        public Applicationmodel Applicationmodel { get; private set; }
        public Supplier Supplier { get; private set; }
        public Contract Contract { get; private set; }
        public StateContract StateContract { get; private set; }


        public string ApplicationNumber { get { return this.Applicationmodel.ApplicationNumber; } }
        public DateTime ApplicationDate { get { return this.Applicationmodel.ApplicationDate; } }
        public byte ApplicationStatus { get { return this.Applicationmodel.ApplicationStatus; } }
        public string SupplierName { get { return this.Supplier.SupplierName; } }
        public string ContractNumber { get { return this.Contract.ContractNumber; } }
        public DateTime ContractDate { get { return this.Contract.ContractDate; } }
        public string StateContractNumber { get { return this.StateContract.StateContractNumber; } }

    }
}

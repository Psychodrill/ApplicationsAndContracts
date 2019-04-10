using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationsAndContracts.Models
{
    public class Criteria
    {
        public static Criteria CreateFrom (string supplierName,
                                          string contractNumber,
                                          DateTime contractDate,
                                          string applicationNumber,
                                          DateTime applicationDate,
                                          string department,
                                          byte applicationStatus,
                                          string stateContractNumber,
                                          int orderNumber,
                                          int productNumber,
                                          string productIndex,
                                          string productAlias,
                                          string productName,
                                          int dceNumber,
                                          string dceAlias,
                                          string dceName)
        {
            var result = new Criteria();
            result.SupplierName = supplierName;
            result.ContractNumber = contractNumber;
            result.ContractDate = contractDate;
            result.ApplicationNumber = applicationNumber;
            result.ApplicationDate = applicationDate;
            result.Department = stateContractNumber;
            result.ApplicationStatus = applicationStatus;
            result.StateContractNumber = stateContractNumber;
            result.OrderNumber = orderNumber;
            result.ProductNumber = productNumber;
            result.ProductIndex = productIndex;
            result.ProductAlias = productAlias;
            result.ProductName = productName;
            result.DceNumber = dceNumber;
            result.DceAlias = dceAlias;
            result.DceName = dceName;
            return result;
        }


        public Criteria()
        {
                       
        }



        public string SupplierName { get; private set; }
        public string ContractNumber { get; private set; }
        public DateTime ContractDate { get; private set; }
        public string ApplicationNumber { get; private set; }
        public DateTime ApplicationDate { get; private set; }
        public string Department { get; private set; } 
        public byte ApplicationStatus { get; private set; }
        public string StateContractNumber { get; private set; }
        public int OrderNumber { get; private set; }
        public int ProductNumber { get; private set; }
        public string ProductIndex { get; private set; }
        public string ProductAlias { get; private set; }
        public string ProductName { get; private set; }
        public int DceNumber { get; private set; }
        public string DceAlias { get; private set; }
        public string DceName { get; private set; }




    }
}

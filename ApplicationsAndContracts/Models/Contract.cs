using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class Contract
    {
        
        public static Contract CreateFrom(DataRow row)
        {

            var result = new Contract();
            result.ContractId = row.Field<int>("ContractId");
            if (result.ContractId == -1) return Contract.InFutureTime();
                //return Contract.Empty();
            result.ContractNumber = row.Field<string>("ContractNumber");
            result.ContractDate = row.Field<DateTime>("ContractDate");
            return result;
       


        }

        public static Contract CreateFrom(ApplicationCatalogItem applicationCatalogItem)
        {
            var result = new Contract();
            result.ContractId = applicationCatalogItem.ContractId;
            result.ContractNumber = applicationCatalogItem.ContractNumber;
            result.ContractDate = applicationCatalogItem.ContractDate;
            return result;
        }

        public static Contract CreateFrom(SupplierCatalogItem suppliercatalogItem)
        {
            var result = new Contract();
            result.ContractId = suppliercatalogItem.ContractId;
            result.ContractNumber = suppliercatalogItem.ContractNumber;
            result.ContractDate = suppliercatalogItem.ContractDate;
            return result;
        }

        public static Contract CreateFrom(CatalogItem catalogItem)
        {
            var result = new Contract();
            result.ContractId = catalogItem.ContractId;
            result.ContractNumber = catalogItem.ContractNumber; /*==string.Empty?result.ContractNumber="В счёт будущего контракта": result.ContractNumber = catalogItem.ContractNumber;*/
            result.ContractDate = catalogItem.ContractDate;
            return result;
        }

        public Contract()
        {
        }
        
        public static Contract Empty()
        {
            var result = new Contract();
            result.ContractId = -1;
            result.ContractNumber = string.Empty;
            result.ContractDate = DateTime.MaxValue;
            return result;
        }

        public static Contract InFutureTime()
        {
            var result = new Contract();
            result.ContractId = -1;
            result.ContractNumber = "в счёт будущего договора";
            result.ContractDate = DateTime.MinValue;
            return result;
        }



        public int ContractId { get; private set; }
        public string ContractNumber { get;  private set; }
        public DateTime ContractDate { get; private set; }

    }
}

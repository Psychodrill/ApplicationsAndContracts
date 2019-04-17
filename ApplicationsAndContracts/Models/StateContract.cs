using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class StateContract
    {
        public static StateContract CreateFrom(DataRow row)
        {
            var result = new StateContract();
            result.StateContractId = row.Field<int>("StateContractId");
            result.StateContractNumber = row.Field<string>("StateContractNumber");
            result.ReasonId = row.Field<int>("ReasonId");
            result.IdGoz = row.Field<string>("IdGoz");
            result.IdKazn = row.Field<string>("IdKazn");
            //if (result.StateContractId == null) result.StateContractId = -1;
            return result;
        }

        public static StateContract CreateFrom(ApplicationCatalogItem applicationCatalogItem)
        {
            var result = new StateContract();
            result.StateContractNumber = applicationCatalogItem.StateContractNumber;
            return result;
        }

        public static StateContract CreateFrom(CatalogItem catalogItem)
        {
            var result = new StateContract();
            result.StateContractId = catalogItem.StateContractId;
            result.StateContractNumber = catalogItem.StateContractNumber;
            result.ReasonId = catalogItem.ReasonId;
            result.IdGoz = catalogItem.IdGoz;
            result.IdGoz = catalogItem.IdKazn;
            return result;
        }

        public static StateContract CreateFrom(SupplierCatalogItem supplierCatalogItem)
        {
            var result = new StateContract();
            result.StateContractId = supplierCatalogItem.StateContractId;
            //result.StateContractNumber = supplierCatalogItem.StateContractNumber;
            return result;
        }


        public StateContract()
        {
        }

        public static StateContract Empty()
        {
            var result = new StateContract();
            result.StateContractId = -1;
            result.StateContractNumber = string.Empty;
            return result;
        }

        

        public int StateContractId { get; private set; }
        public string StateContractNumber { get; private set; }
        public int ReasonId { get; private set; }
        public string IdGoz { get; private set; }
        public string IdKazn { get; private set; }
    }
}

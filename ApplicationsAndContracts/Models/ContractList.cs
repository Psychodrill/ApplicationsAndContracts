using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Helpers;
using ApplicationsAndContracts.DataAccess;


namespace ApplicationsAndContracts.Models
{
    public class ContractList:List<Contract>
    {        
        public static ContractList GetContractList ()
        {
            var rows = new DataService().GetContractList();
            var list = rows.Select(row => Contract.CreateFrom(row)).ToList();
            var result = new ContractList(list);
            return result;
        }

        public Contract GetContract (string contractNumber)
        {
            if (contractNumber == string.Empty) return Contract.Empty();
            var result = this.FirstOrDefault(x => x.ContractNumber == contractNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ContractIsOutOfRangeText, contractNumber));
        }



        public Contract TryGetContract (string contractNumber)
        {
            try
            {
               return GetContract(contractNumber);
            }
            catch (ApplicationException)
            {
                return Contract.Empty();
            }
        }


        private ContractList(IEnumerable<Contract> collection) : base(collection)
        {
        }


    }
}

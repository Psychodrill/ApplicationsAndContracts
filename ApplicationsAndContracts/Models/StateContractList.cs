using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.DataAccess;
using System.Data;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Models
{
    public class StateContractList:List<StateContract>
    {
        public static StateContractList GetStateContractList()
        {
            var rows = new DataService().GetStateContractList();
            var list = rows.Select(row => StateContract.CreateFrom(row)).ToList();
            var result = new StateContractList(list);
            return result;
        }

        public StateContract GetStateContractNumber(string contractNumber)
        {
            if (contractNumber == string.Empty) return StateContract.Empty();
            var result = this.FirstOrDefault(x => x.ContractNumber == contractNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ContractIsOutOfRangeText, contractNumber));
        }


        public StateContract TryGetContract(string contractNumber)
        {
            try
            {
                return GetStateContractNumber(contractNumber);
            }
            catch (ApplicationException)
            {
                return StateContract.Empty();
            }
        }




        private StateContractList(IEnumerable<StateContract> items) : base(items)
        {

        } 
    }
}

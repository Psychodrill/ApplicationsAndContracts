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
            result.ContractId = row.Field<int>("ContractId");
            result.StateContractNumber = row.Field<string>("ContractNumber");
            return result;
        }

        public StateContract()
        {
        }

        public static StateContract Empty()
        {
            var result = new StateContract();
            result.StateContractNumber = string.Empty;
            return result;
        }

        

        public int ContractId { get; private set; }
        public string StateContractNumber { get; private set; }

    }
}

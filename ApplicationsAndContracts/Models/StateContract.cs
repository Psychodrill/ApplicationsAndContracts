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
            //result.StateContractId = row.Field<int>("StateContractId");
            result.StateContractNumber = row.Field<string>("StateContractNumber");
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

        

        public int StateContractId { get; private set; }
        public string StateContractNumber { get; private set; }

    }
}

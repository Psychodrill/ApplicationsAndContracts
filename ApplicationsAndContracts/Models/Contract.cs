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
            result.ContractNumber = row.Field<string>("ContractNumber");
            result.ContractDate = row.Field<DateTime>("ContractDate");
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




        public int ContractId { get; private set; }
        public string ContractNumber { get;  private set; }
        public DateTime ContractDate { get; private set; }

    }
}

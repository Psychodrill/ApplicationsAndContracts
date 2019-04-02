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

        public Contract GetContractNumber (string contractNumber)
        {
            if (contractNumber == string.Empty) return Contract.Empty();
            var result = this.FirstOrDefault(x => x.ContractNumber == contractNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ContractIsOutOfRangeText, contractNumber));
        }

        public Contract GetContractDate (DateTime contractDate)
        {
            if (contractDate == DateTime.MinValue) return Contract.Empty();
            var result = this.FirstOrDefault(x => x.ContractDate == contractDate);
            if (result!= null) return result;
            throw new ApplicationException(string.Format(Resources.ContractDateIsOutOfRangeText, contractDate)); 
        }

        public List<DateTime> GetContractDateList()
        {
            var result = this.Select(x => x.ContractDate).Distinct().OrderBy(x => x).ToList();
            return result;
        }



        public Contract TryGetContract (string contractNumber)
        {
            try
            {
               return GetContractNumber(contractNumber);
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

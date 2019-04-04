using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationsAndContracts.DataAccess;
using ApplicationsAndContracts.Helpers;


namespace ApplicationsAndContracts.Models
{
    public class DceList:List<Dce>
    {
        public static DceList GetDceList()
        {
            var rows = new DataService().GetDceList();
            var list = rows.Select(row => Dce.CreateFrom(row));
            var result = new DceList(list);
            return result;
        }


        public Dce GetDceNumber(int dceNumber)
        {
            if (dceNumber == -1) return Dce.Empty();
            var result = this.FirstOrDefault(x => x.DceNumber == dceNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.DceIsOutOfRangeText, dceNumber));

        }

        public Dce GetDceAlias(string dceAlias)
        {
            if (dceAlias == string.Empty|| dceAlias==null) return Dce.Empty();
            var result = this.FirstOrDefault(x => x.DceAlias.ToUpper() == dceAlias.ToUpper());
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.DceIsOutOfRangeText, dceAlias));

        }

        public Dce GetDceName(string dceName)
        {
            if (dceName == string.Empty||dceName==null) return Dce.Empty();
            var result = this.FirstOrDefault(x => x.DceName.ToUpper() == dceName.ToUpper());
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.DceIsOutOfRangeText, dceName));

        }

        public List<int> GetDceNumberList()
        {
            var result = this.Select(x => x.DceNumber).Distinct().OrderBy(x => x).ToList();
            return result;
        }



        public List<string> GetDceAliasList()
        {
            var result = this.Select(x => x.DceAlias).Distinct().OrderBy(x => x).ToList();
            return result;
        }

        public List<string> GetDceNameList()
        {
            var result = this.Select(x => x.DceName).Distinct().OrderBy(x => x).ToList();
            return result;
        }


        public Dce TryGetDceNumber(int dceNumber)
        {
            try
            {
                return GetDceNumber(dceNumber);
            }
            catch (ApplicationException)
            {
                return Dce.Empty();
            }
        }

        public Dce TryGetDceAlias(string dceAlias)
        {
            try
            {
                return GetDceAlias(dceAlias);
            }
            catch (ApplicationException)
            {
                return Dce.Empty();
            }
        }

        public Dce TryGetDceName(string dceName)
        {
            try
            {
                return GetDceName(dceName);
            }
            catch (ApplicationException)
            {
                return Dce.Empty();
            }
        }


        private DceList(IEnumerable<Dce>items): base(items)
        {

        }
    }
}

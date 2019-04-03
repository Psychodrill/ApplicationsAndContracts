using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.DataAccess;
using ApplicationsAndContracts.Helpers;

namespace ApplicationsAndContracts.Models
{
    public class ApplicationList:List<Applicationmodel>
    {
        public static ApplicationList GetApplicationList()
        {
            var rows = new DataService().GetApplicationList();
            var list = rows.Select(row => Applicationmodel.CreateFrom(row)).ToList();
            var result = new ApplicationList(list);
            return result;
        }

        public Applicationmodel GetApplication(string applicationNumber)
        {
            if (applicationNumber == string.Empty) return Applicationmodel.Empty();
            var result = this.FirstOrDefault(x => x.ApplicationNumber == applicationNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ApplicationIsOutOfRangeText, applicationNumber));
        }

        public Applicationmodel GetApplicationDate(DateTime applicationDate)
        {
            if (applicationDate == DateTime.MinValue) return Applicationmodel.Empty();
            var result = this.FirstOrDefault(x => x.ApplicationDate == applicationDate);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ApplicationDateIsOutOfRange, applicationDate));
        }

        public List<DateTime> GetApplicationDateList()
        {
            var result = this.Select(x => x.ApplicationDate).Distinct().OrderBy(x => x).ToList();
            return result;
        }

        public List <string> GetDepartmentList()
        {
            var result = this.Select(x => x.Department).Distinct().OrderBy(x => x).ToList();
            return result;
        }



        public Applicationmodel TryGetApplication(string applicationNumber)
        {
            try
            {
                return GetApplication(applicationNumber);
            }
            catch (ApplicationException)
            {
                return Applicationmodel.Empty();
            }
        }

        private ApplicationList(IEnumerable<Applicationmodel> items):base(items)
        {

        }
    }
}

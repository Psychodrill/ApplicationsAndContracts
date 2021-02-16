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
            result.Add(Dce.Empty());
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
            var result = this.FirstOrDefault(x => x.DceAlias.Trim().ToUpper() == dceAlias.ToUpper());
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.DceIsOutOfRangeText, dceAlias));

        }

        public Dce GetDceName(string dceName)
        {
            if (dceName == string.Empty||dceName==null) return Dce.Empty();
            var result = this.FirstOrDefault(x => x.DceName.Trim().ToUpper() == dceName.ToUpper());
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

        
        //public List<Dce> GetDce(int? dceNumber, string dceAlias, string dceName)
        //{
        //    Dce result;
        //    if (dceNumber != -1)
        //    {
        //        result = this.FirstOrDefault(x => x.DceNumber == dceNumber);
        //        if (result != null) dceNumber = result.DceNumber;
        //        else result= Dce.Empty();
        //        dceNumber = null;
        //    }
        //    else if (dceAlias != string.Empty)
        //    {
        //        result = this.FirstOrDefault(x => x.DceAlias.Trim().ToUpper() == dceAlias.ToUpper());
        //        if (result != null) dceAlias = result.DceAlias;
        //        else result = Dce.Empty();
        //    }
        //    else if (dceName != string.Empty)
        //    {
        //        result = this.FirstOrDefault(x => x.DceName.Trim().ToUpper() == dceName.ToUpper());
        //        if (result != null) dceName = result.DceName;
        //        else result = Dce.Empty();
        //    }

        //    List<Dce> innerlist = DceList.GetDceList().Where(x =>x.DceNumber==dceNumber)
        //                                              .Where(x =>x.DceAlias==dceAlias)
        //                                              .Where(x=>x.DceName==dceName).OrderBy(x=>x.DceNumber).ToList();

        //    //List<Dce> innerlist1 = DceList.GetDceList().Where(x => x.DceNumber == dceNumber)
        //    //                                          .Where(x => x.DceAlias == dceAlias)
        //    //                                          .Where(x => x.DceName == dceName).OrderBy(x => x.DceNumber).ToList();

        //    return innerlist;

        //    //DceList dceList1 = new DceList(DceList.GetDceList());
        //    //List<Dce> dceList2 = new List<Dce>();

        //    //Dce result;
        //    ////if (dceNumber != -1)
        //    ////{
        //    ////    result = this.FirstOrDefault(x => x.DceNumber == dceNumber);
        //    ////    if (result != null) dceNumber=result.DceNumber;
        //    ////} 
        //    ////else if (dceAlias != string.Empty)
        //    ////{
        //    ////    result = this.FirstOrDefault(x => x.DceAlias.Trim().ToUpper() == dceAlias.ToUpper());
        //    ////    if (result != null) dceAlias=result.DceAlias;
        //    ////}
        //    ////else if(dceName != string.Empty)
        //    ////{
        //    ////    result = this.FirstOrDefault(x => x.DceName.Trim().ToUpper() == dceName.ToUpper());
        //    ////    if (result != null) dceName=result.DceName;
        //    ////}

        //    //dceList1 = DceList.GetDceList().SelectMany(x =>x.DceNumber==dceNumber).Intersect(DceList.GetDceList().Select(x => x.DceAlias== dceAlias));
        //    //    //Where(x => x.DceAlias == dceAlias).Where(x=>x.DceName==dceName).Distinct().ToList();
        //    //return dceList;

        //    //dceList = GetDceNumberList().Select(x=>x.DceNumber==).Distinct().OrderBy(x=>x);

            

        //    ////if (result != null) return result;
        //    ////throw new ApplicationException(string.Format(Resources.DceIsOutOfRangeText, dceNumber));
        //}


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

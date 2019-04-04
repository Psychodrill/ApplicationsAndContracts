using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class Dce
    {
        public static Dce CreateFrom(DataRow row)
        {
            var result = new Dce();
            result.ApplicationId = row.Field<int>("ApplicationId");
            result.DceNumber = row.Field<int>("DceNumber");
            result.DceAlias = row.Field<string>("DceAlias");
            result.DceName = row.Field<string>("DceName");
            if (result.ApplicationId == null) result.ApplicationId=-1;
            if (result.DceNumber == null) result.DceNumber = -1;
            if (result.DceAlias == null) result.DceAlias = string.Empty;
            if (result.DceName == null) result.DceName = string.Empty;
            return result;
        }

        Dce()
        {

        }

        public static Dce Empty()
        {
            var result = new Dce();
            result.ApplicationId = -1;
            result.DceNumber = -1;
            result.DceAlias = string.Empty;
            result.DceName = string.Empty;
            return result;
        }
        
        

        public int ApplicationId { get; private set; }

        public int DceNumber { get; private set; }

        public string DceAlias { get; private set; }

        public string DceName { get; private set; }
    }
       
    
}

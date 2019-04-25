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
            result.Quantity = row.Field<decimal>("Quantity");
            if (result.ApplicationId == null) result.ApplicationId=-1;
            if (result.DceNumber == null) result.DceNumber = -1;
            if (result.DceAlias == null) result.DceAlias = string.Empty;
            if (result.DceName == null) result.DceName = string.Empty;

            return result;
        }

        internal static Dce CreateFrom(CatalogItem catalogItem)
        {
            var result = new Dce();
            result.ApplicationId = catalogItem.ApplicationId;
            result.DceNumber = catalogItem.DceNumber;
            result.DceAlias = catalogItem.DceAlias;
            result.DceName   = catalogItem.DceName;
            result.Quantity = catalogItem.Quantity;
            return result;
        }

        internal static Dce CreateFrom(Dce dce)
        {
            var result = new Dce();
            result.ApplicationId = dce.ApplicationId;
            result.DceNumber = dce.DceNumber;
            result.DceAlias = dce.DceAlias;
            result.DceName = dce.DceName;
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
            result.Quantity = decimal.MinusOne;
            return result;
        }
        
        

        public int ApplicationId { get; private set; }

        public int DceNumber { get; private set; }

        public string DceAlias { get; private set; }

        public string DceName { get; private set; }
        public decimal Quantity { get; private set; }
    }
       
    
}

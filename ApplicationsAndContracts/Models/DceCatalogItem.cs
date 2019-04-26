using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.Models
{
    public class DceCatalogItem
    {

        public static DceCatalogItem CreateFrom(CatalogItem catalogItem)
        {
            var result = new DceCatalogItem();
            result.Refresh(catalogItem);
            return result;
        }

        public static DceCatalogItem CreateFrom(Dce dce, DceQuantity dceQuantity)
        {
            var result = new DceCatalogItem();
            result.Refresh(dce, dceQuantity);
            return result;
        }

        private void Refresh(Dce dce, DceQuantity dceQuantity)
        {
            
            this.Dce = Dce.CreateFrom(dce);
            this.DceQuantity=DceQuantity.CreateFrom(dceQuantity);
        }

        public void Refresh(CatalogItem catalogItem)
        {
            this.Dce = Dce.CreateFrom(catalogItem);
            this.DceQuantity = DceQuantity.CreateFrom(catalogItem);
            

        }

        //public void Refresh (CatalogItem catalogItem, )




        //internal static DceCatalogItem CreateFrom(CatalogItem catalogItem)
        //{
        //    var result = new DceCatalogItem();
        //    result.ApplicationId = catalogItem.ApplicationId;
        //    result.DceNumber = catalogItem.DceNumber;
        //    result.DceAlias = catalogItem.DceAlias;
        //    result.DceName = catalogItem.DceName;
        //    result.Quantity = catalogItem.Quantity;
        //    return result;
        //}



        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var item = (DceCatalogItem)obj;
            if (this.ApplicationId != item.ApplicationId) return false;
            if (this.DceNumber != item.DceNumber) return false;
            if (this.DceName != item.DceName) return false;
            if (this.DceAlias != item.DceAlias) return false;
            if (this.Quantity != item.Quantity) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var sb = new StringBuilder();

            sb.Append(this.ApplicationId);
            sb.Append(this.DceNumber);
            sb.Append(this.DceAlias);
            sb.Append(this.DceName);
            sb.Append(this.Quantity);
            return sb.ToString().GetHashCode();

        }



        public Dce Dce {get; private set;}
        public DceQuantity DceQuantity { get; private set; }



        public int ApplicationId { get { return Dce.ApplicationId; } }

        public int DceNumber { get {return Dce.DceNumber; } }

        public string DceAlias { get { return Dce.DceAlias; } }

        public string DceName { get { return Dce.DceName; } }
        public decimal Quantity { get { return DceQuantity.Quantity; } }
    }
}

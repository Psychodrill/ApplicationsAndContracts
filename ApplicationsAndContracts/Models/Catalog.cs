using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models.Abstract;


namespace ApplicationsAndContracts.Models
{
    public class Catalog:SupportSortingList<CatalogItem>
    {
        public static Catalog (IEnumerable<DataRow> rows)
        {
            var result = new Catalog();
            result.RefreshFrom(rows);
            return result;
        }

        private Catalog()
        {
            this.innerList = new List<CatalogItem>();
        }

        private List<CatalogItem> innerList;

        public void RefreshFrom (IEnumerable<DataRow> rows)
        {
            this.Clear();
                foreach (var row in rows)
                this.Add(CatalogItem.CreateFrom(row));
        }

        public void Add(CatalogItem item)
        {
            this.innerList.Add(item);
            base.Add(item);
        }
    }
}

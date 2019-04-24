using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApplicationsAndContracts.Models;
using ApplicationsAndContracts.Models.Abstract;

namespace ApplicationsAndContracts.Models
{
     public class ProductCatalog:SupportSortingList<ProductCatalogItem>
    {
        public static ProductCatalog CreateFrom (ApplicationCatalogItem applicationCatalogItem)
        {


            ProductCatalog catalog = new ProductCatalog();
            var list = catalog.Select(catalogItem => ProductCatalogItem.CreateFrom(catalogItem)).Distinct()/*.OrderBy(x => x.ApplicationId)*/.ToList();
            var result = new ProductCatalog(list);
            return result;


        }

        public static ProductCatalog CreateFrom(List<Product> catalog)
        {


            var list = catalog.Select(catalogItem => ProductCatalogItem.CreateFrom(catalogItem)).Distinct().OrderBy(x => x.ProductName).ToList();
            var result = new ProductCatalog(list);
            return result;


        }

        private ProductCatalog()
        {
            var productList = ProductList.GetProductList();
            var orderList = OrderList.GetOrderList();
            ProductCatalog productCatalog = new ProductCatalog();
            //var  productCatalog = productList.Select(x => x.ApplicationId).ToList();
            //var productCatalog = productList. .Join<Product,Order,Order,ProductCatalogItem>(orderList, productList.Select(x=>x.ApplicationId), orderList.Select(x=>x.ApplicationId),productList.Select(x=>x.ApplicationId).ToList();
            //var productCatalog = productList.Where(listItem =>listItem.ApplicationId==orderList.);

            foreach ( var item in productCatalog)
                this.Add(ProductCatalogItem.CreateFrom(item));




        }

        //public void RefreshFrom(IEnumerable<DataRow> rows)
        //{
        //    this.Clear();
        //    foreach (var row in rows)
        //        this.Add(CatalogItem.CreateFrom(row));
        //}

        //public static explicit operator ProductCatalog(ProductList v)
        //{

        //    foreach (var Product in v)
        //    {
        //        ProductCatalogItem.CreateFrom(ProductCatalogItem)

        //    }
        //    return new ProductCatalog();
        //}

        private ProductCatalog (List <ProductCatalogItem>items): base(items)
        {

        }

       

        //Refresh()
        //{
        //    IEnumerable<Product> innerList = ProductList.GetProductList();
        //    return innerList;

        //}


        //public List<Product> GetProductList()
        //{
        //    var result = this.Select(x => x.ApplicationDate).Distinct().OrderByDescending(x => x).ToList();
        //    return result;
        //}
    }
}

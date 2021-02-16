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
        public ProductCatalog productCatalog;

        //public static ProductCatalog CreateFrom (ApplicationCatalogItem applicationCatalogItem)
        //{
                        
        //    ProductCatalog innerlist = Create();
        //    var list = innerlist.Where(catalogItem => (applicationCatalogItem.ApplicationId==catalogItem.ApplicationId)).Distinct().OrderBy(x => x.ApplicationId).ToList();
        //    var result = new ProductCatalog(list);
        //    return result;
            
        //}

        public static ProductCatalog CreateFrom(Catalog catalog, ApplicationCatalogItem applicationCatalogItem)
        {

            //productCatalog innerList = Create();

            var list = catalog.Select(catalogItem => ProductCatalogItem.CreateFrom(catalogItem))
                              .Where(catalogItem => (applicationCatalogItem.ApplicationId == catalogItem.ApplicationId))
                              .Distinct().OrderBy(x => x.OrderNumber).ToList();
            var result = new ProductCatalog(list);
            return result;

        }

        //public static ProductCatalog CreateFrom(List<ProductCatalogItem> catalog)
        //{

        //    var list = catalog.Select(catalogItem => ProductCatalogItem.CreateFrom(catalogItem)).Distinct().OrderBy(x => x.ProductName).ToList();
        //    var result = new ProductCatalog(list);
        //    return result;

        //}

        //public static  ProductCatalog Create()
        //{
        //    var productList = ProductList.GetProductList();
        //    var orderList = OrderList.GetOrderList();
        //    //ProductCatalog productCatalog = new ProductCatalog();
        //    //var  productCatalog = productList.Select(x => x.ApplicationId).ToList();
        //    var innerList = productList.Join(orderList, p => p.ApplicationId, o => o.ApplicationId, (p, o) => ProductCatalogItem.CreateFrom(p, o)).ToList();
        //    ProductCatalog productCatalog = new ProductCatalog(innerList);
        //    return productCatalog;

        //    //var productCatalog = productList.Where(listItem =>listItem.ApplicationId==orderList.);

        //    /// Cool way, but not public elements 
        //    ////var result = from p in productList
        //    ////             join o in orderList
        //    ////             on p.ApplicationId equals o.ApplicationId
        //    ////             select ProductCatalogItem.CreateFrom(p, o);



        //    //foreach (var product in productList)
        //    //    foreach (var order in orderList)
        //    //        if (product.ApplicationId == order.ApplicationId)
        //    //        {
        //    //            this.Add(ProductCatalogItem.CreateFrom(product, order));
        //    //        }

        //}

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

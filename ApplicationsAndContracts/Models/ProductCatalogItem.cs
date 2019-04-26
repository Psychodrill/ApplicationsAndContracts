using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ApplicationsAndContracts.Models
{
    public class ProductCatalogItem
    {
        public static ProductCatalogItem CreateFrom(ProductCatalogItem productCatalogItem)
        {
            var result = new ProductCatalogItem();
            result.Refresh(productCatalogItem);
            return result;
        }

        public static ProductCatalogItem CreateFrom(Product product)
        {
            var result = new ProductCatalogItem();
            result.Refresh(product);
            //result.Refresh(order);
            return result;
        }

        public static ProductCatalogItem CreateFrom(CatalogItem catalogItem)
        {
            var result = new ProductCatalogItem();
            result.Refresh(catalogItem);
            return result;

        }

        public static ProductCatalogItem CreateFrom(Product product, Order order)
        {
            var result = new ProductCatalogItem();
            result.Refresh(product);
            result.Refresh(order);
            return result;

        }

        //public static ProductCatalogItem CreateFrom (CatalogItem catalogItem)
        //{
        //    var result = new ProductCatalogItem();
        //    result.
        //}



        public void Refresh(ProductCatalogItem productCatalogItem)
        {
            this.Product = Product.CreateFrom(productCatalogItem);
            this.Order = Order.CreateFrom(productCatalogItem);


        }

        public void Refresh(Product product)
        {
            this.Product = Product.CreateFrom(product);
            //this.Order = Order.CreateFrom(product);
        }

        public void Refresh(Order order)
        {
            this.Order = Order.CreateFrom(order);
            //this.Order = Order.CreateFrom(product);
        }

        public void Refresh (CatalogItem catalogItem)
        {
            this.Product = Product.CreateFrom(catalogItem);
            this.Order = Order.CreateFrom(catalogItem);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var item = (ProductCatalogItem)obj;
            if (this.ProductNumber != item.ProductNumber) return false;
            if (this.ProductIndex != item.ProductIndex) return false;
            if (this.ProductAlias != item.ProductAlias) return false;
            if (this.ProductName != item.ProductName) return false;
            if (this.ApplicationId != item.ApplicationId) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var sb = new StringBuilder();

            sb.Append(this.ProductNumber);
            sb.Append(this.ProductIndex);
            sb.Append(this.ProductAlias);
            sb.Append(this.ProductName);
            sb.Append(this.ApplicationId);
            return sb.ToString().GetHashCode();
        }




        public Product Product { get; private set; }
        public Order Order { get; private set; }
        


        public int? IdInd { get { return this.Product.IdInd; } }
        public int? ProductNumber { get { return this.Product.ProductNumber; } }

        public string ProductIndex { get { return this.Product.ProductIndex; } }
        public string ProductAlias { get { return this.Product.ProductAlias; } }
        public string ProductName { get { return this.Product.ProductName; } }
        public int? ApplicationId { get { return this.Product.ApplicationId; } }
        public int? OrderNumber { get { return this.Order.OrderNumber; } }
        public int? SetFrom { get { return this.Order.SetFrom; } }
        public int? SetTo { get { return this.Order.SetTo; } }
        //public int ApplicationId { get { return this.Order.ApplicationId; } }


    }
}


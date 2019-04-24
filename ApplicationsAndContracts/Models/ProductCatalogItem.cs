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

        public static ProductCatalogItem CreateFrom(Product product, Order order)
        {
            var result = new ProductCatalogItem();
            result.Refresh(product);
            result.Refresh(order);
            return result;

        }

        //public static ProductCatalogItem Create()
        //{
        //    var result = new ProductCatalogItem();
        //    result.Product = Product.CreateFrom()
        //}



        public void Refresh(ProductCatalogItem productCatalogItem)
        {
            this.Product = Product.CreateFrom(productCatalogItem);
            //this.Order = Order.CreateFrom(productCatalogItem);


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

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    var item = (ApplicationCatalogItem)obj;
        //    if (this.ApplicationNumber != item.ApplicationNumber) return false;
        //    if (this.ApplicationDate != item.ApplicationDate) return false;
        //    if (this.SupplierName != item.SupplierName) return false;
        //    if (this.ContractNumber != item.ContractNumber) return false;
        //    if (this.ContractDate != item.ContractDate) return false;
        //    if (this.StateContractNumber != item.StateContractNumber) return false;
        //    if (this.ApplicationStatus != item.ApplicationStatus) return false;
        //    return true;
        //}

        //public override int GetHashCode()
        //{
        //    var sb = new StringBuilder();

        //    sb.Append(this.ApplicationNumber);
        //    sb.Append(this.ApplicationDate);
        //    sb.Append(this.SupplierName);
        //    sb.Append(this.ContractNumber);
        //    sb.Append(this.ContractDate);
        //    sb.Append(this.StateContractNumber);
        //    sb.Append(this.ApplicationStatus);
        //    return sb.ToString().GetHashCode();
        //}




        public Product Product { get; private set; }
        public Order Order { get; private set; }
        


        public int? IdInd { get { return this.Product.IdInd; } }
        public int? ProductNumber { get { return this.Product.ProductNumber; } }

        public string ProductIndex { get { return this.Product.ProductIndex; } }
        public string ProductAlias { get { return this.Product.ProductAlias; } }
        public string ProductName { get { return this.Product.ProductName; } }
        public int? ApplicationId { get { return this.Product.ApplicationId; } }
        public int OrderNumber { get { return this.Order.OrderNumber; } }
        public int SetFrom { get { return this.Order.SetFrom; } }
        public int SetTo { get { return this.Order.SetTo; } }
        //public int ApplicationId { get { return this.Order.ApplicationId; } }


    }
}


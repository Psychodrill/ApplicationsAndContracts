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
    public class ProductList:List<Product>
    {
        public static ProductList GetProductList()
        {
            var rows = new DataService().GetProductList();
            var list = rows.Select(row => Product.CreateFrom(row));
            var result = new ProductList(list);
            return result;
        }

        public  Product GetProduct(int idInt)
        {
            if (idInt == -1) return Product.Empty();
            var result = this.FirstOrDefault(x => x.IdInd == idInt);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, idInt));
        }

        public Product GetProductNumber(int productNumber)
        {
            if (productNumber == -1) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ProductNumber == productNumber);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, productNumber));
        }

        public Product GetProductIndex (string productIndex)
        {
            if (productIndex == string.Empty) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ProductIndex == productIndex);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, productIndex));
        }

        public Product GetProductName(string productName)
        {
            if (productName == string.Empty) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ProductName == productName);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, productName));
        }

        public Product GetProductAlias(string productAlias)
        {
            if (productAlias == string.Empty) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ProductAlias == productAlias);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, productAlias));
        }

        public Product GetApplicationId(int applicationId)
        {
            if (applicationId == -1) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ApplicationId == applicationId);
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, applicationId));
        }

        public List<int> GetProductNumberList()
        {
            var result = this.Select(x => x.ProductNumber).Distinct().OrderBy(x => x).ToList();
            return result;
        }

        public List<string> GetProductIndexList()
        {
            var result = this.Select(x => x.ProductIndex).Distinct().OrderBy(x => x).ToList();
            return result;
        }

        public List<string> GetProductNameList()
        {
            var result = this.Select(x => x.ProductName).Distinct().OrderBy(x => x).ToList();
            return result;
        }

        public List<string> GetProductAliasList()
        {
            var result = this.Select(x => x.ProductAlias).Distinct().OrderBy(x => x).ToList();
            return result;
        }


        public Product TryGetProduct(string productName)
        {
            try
            {
                return GetProductName(productName);
            }
            catch (ApplicationException)
            {
                return Product.Empty();
            }
        }

        private ProductList(IEnumerable<Product> items) : base(items)
        {

        }
    }
}

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
            result.Add(Product.Empty());
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
            var result = this.FirstOrDefault(x => x.ProductIndex.Trim().ToUpper() == productIndex.ToUpper());
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, productIndex));
        }

        public Product GetProductName(string productName)
        {
            if (productName == string.Empty) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ProductName.Trim().ToUpper() == productName.ToUpper());
            if (result != null) return result;
            throw new ApplicationException(string.Format(Resources.ProductIsOutOfRangeText, productName));
        }

        public Product GetProductAlias(string productAlias)
        {
            if (productAlias == string.Empty) return Product.Empty();
            var result = this.FirstOrDefault(x => x.ProductAlias.Trim().ToUpper() == productAlias);
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

        public List<int?> GetProductNumberList()
        {
            var result = this.Select(x => x.ProductNumber).Distinct().OrderBy(x => x).ToList();
            return result;
        }

        public List<string> GetProductIndexList()
        {
            var result = this.Select(x => x.ProductIndex.Trim()).Distinct().OrderBy(x => x).ToList();
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


        public Product TryGetProductNumber(int productNumber)
        {
            try
            {
                return GetProductNumber(productNumber);
            }
            catch (ApplicationException)
            {
                return Product.Empty();
            }
        }

        public Product TryGetProductIndex(string productIndex)
        {
            try
            {
                return GetProductIndex(productIndex);
            }
            catch (ApplicationException)
            {
                return Product.Empty();
            }
        }

        public Product TryGetProductAlias(string productAlias)
        {
            try
            {
                return GetProductAlias(productAlias);
            }
            catch (ApplicationException)
            {
                return Product.Empty();
            }
        }

        public Product TryGetProductName(string productName)
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

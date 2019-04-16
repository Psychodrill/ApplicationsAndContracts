using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ApplicationsAndContracts.Models;

namespace ApplicationsAndContracts.DataAccess
{
    class DataService
    {
        public DataService()
        {
            //TODO: Выбор сервера
            //SqlHelper.Initialize("880_SQL", "MTS_1");
            SqlHelper.Initialize("RESERV", "MTS_1_Test");
        }


        public DataRow GetSDS()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetSDS, parameters);
            var result = rows.AsEnumerable().FirstOrDefault();
            return result;
        }

        public IEnumerable<DataRow> GetSupplierList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetSupplierList, parameters);
            var result =  rows.AsEnumerable();
            return result;
        }

        public IEnumerable<DataRow> GetContractList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetContractList, parameters);
            var result = rows.AsEnumerable();
            return result;
        }
        public IEnumerable<DataRow> GetApplicationList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetApplicationList, parameters);
            var result = rows.AsEnumerable();
            return result;
        }

        public IEnumerable<DataRow>GetStateContractList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetStateContractList, parameters);
            var result = rows.AsEnumerable();
            return result;
        }

        public IEnumerable<DataRow>GetOrderList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetOrderList, parameters);
            var result = rows.AsEnumerable();
            return result;
        }

        public IEnumerable<DataRow> GetProductList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetProductList, parameters);
            var result = rows.AsEnumerable();
            return result;
        }

        public IEnumerable<DataRow> GetDceList()
        {
            var parameters = new SqlParameter[0];
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetDceList, parameters);
            var result = rows.AsEnumerable();
            return result;
        }

        public IEnumerable<DataRow> GetCatalog(Criteria criteria)
        {
            var parameters = new SqlParameter[16];
            //parameters = new SqlParameter("applicationId");
            parameters[0] = new SqlParameter("supplierName", criteria.SupplierName);
            parameters[1] = new SqlParameter("contractNumber", criteria.ContractNumber);
            parameters[2] = new SqlParameter("contractDate", criteria.ContractDate);
            parameters[3] = new SqlParameter("applicationNumber", criteria.ApplicationNumber);
            parameters[4] = new SqlParameter("applicationDate", criteria.ApplicationDate);
            parameters[5] = new SqlParameter("applicationStatus", criteria.ApplicationStatus);
            parameters[6] = new SqlParameter("department", criteria.Department);

            parameters[7] = new SqlParameter("stateContractNumber", criteria.StateContractNumber);
            parameters[8] = new SqlParameter("orderNumber", criteria.OrderNumber);
            parameters[9] = new SqlParameter("productNumber", criteria.ProductNumber);
            parameters[10] = new SqlParameter("productIndex", criteria.ProductIndex);
            parameters[11] = new SqlParameter("productAlias", criteria.ProductAlias);
            parameters[12] = new SqlParameter("productName", criteria.ProductName);
            parameters[13] = new SqlParameter("dceNumber", criteria.DceNumber);
            parameters[14] = new SqlParameter("dceAlias", criteria.DceAlias);
            parameters[15] = new SqlParameter("dceName", criteria.DceName);
            var rows = SqlHelper.ExecuteSqlCommand(SQL.GetCatalog, parameters);
            var result =rows.AsEnumerable();
            return result;
        }


    }
}

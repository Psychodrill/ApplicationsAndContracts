using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
    }
}

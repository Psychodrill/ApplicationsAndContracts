﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationsAndContracts.Models
{
    class Supplier
    {
        public static Supplier CreateFrom (DataRow row)
        {
            var result = new Supplier();
            result.SupplierCode = row.Field<int>("SupplierCode");
            result.SupplierName = row.Field<string>("SupplierName");
            return result;
        }

        public Supplier()
        {

        }

        public int SupplierCode { get; private set; }
        public string SupplierName { get; private set; }
    }
}

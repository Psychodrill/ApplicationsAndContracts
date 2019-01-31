using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationsAndContracts.DataAccess
{
    class SQL
    {
        internal const string GetSDS = @"
                SELECT [UserRole],
                       [UserName],
                       [UserDepartment],
                       [Date]
                  FROM [dbo].[ft_WorkWithDce_GetSDS]()";
    }
}

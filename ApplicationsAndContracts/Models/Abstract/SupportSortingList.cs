using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ApplicationsAndContracts.Models.Abstract
{
    public class SupportSortingList<T>:BindingList<T>
    {
        private ListSortDirection sortDirection;
        private PropertyDescriptor sortProperty;

        public SupportSortingList() : base()
        {
            sortDirection = ListSortDirection.Ascending;
            sortProperty = null;
        }
        public SupportSortingList(IList<T>source): base(source)
        {

        }
    }
}

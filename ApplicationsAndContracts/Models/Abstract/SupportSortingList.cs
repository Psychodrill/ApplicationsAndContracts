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

        public ListSortDirection SortDirection
        {
            get { return sortDirection; }
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return sortDirection; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return sortProperty; }
        }

        protected override void ApplySortCore (PropertyDescriptor prop, ListSortDirection direction)
        {
            this.sortProperty = prop;
            this.sortDirection = direction;
            ((List<T>)Items).Sort(Compare);
        }

        private int Compare (T a, T b)
        {
            int sortOrderModifier = sortDirection == ListSortDirection.Ascending ? 1 : -1;
            var propA = sortProperty.GetValue(a) as IComparable;
            var propB = sortProperty.GetValue(b) as IComparable;
            int compareResult = 0;

            if (propA==null)
            {
                if (propB == null)
                {
                    compareResult = 0;
                }
                else
                {
                    compareResult = -1;
                }
                    
            }
            else
            {
                if (propB == null)
                {
                    compareResult = 1;
                }
                else
                {
                    compareResult = propA.CompareTo(propB);
                }
            }
            compareResult *= sortOrderModifier;
            return compareResult;
        }

    }
}

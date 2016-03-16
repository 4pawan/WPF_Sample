using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.ViewModel;

namespace Demo1.Repository
{
    public class PagingCondition : ICondition
    {
        private PaginationViewModel paging;
        private EmpFormViewModel model;

        public PagingCondition(PaginationViewModel paging, EmpFormViewModel model)
        {
            this.paging = paging;
            this.model = model;
        }


        public bool Evaluate()
        {
            int index = paging.PeopleList.IndexOf(model);
            return index >= paging.itemPerPage * paging.CurrentPageIndex && index < paging.itemPerPage * (paging.CurrentPageIndex + 1);
        }
    }
}

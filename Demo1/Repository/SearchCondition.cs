using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.ViewModel;

namespace Demo1.Repository
{
    public class SearchCondition : ICondition
    {
        private PaginationViewModel paging;
        private EmpFormViewModel model;

        public SearchCondition(PaginationViewModel paging, EmpFormViewModel model)
        {
            this.paging = paging;
            this.model = model;
        }


        public bool Evaluate()
        {
            string keyToSrch = "AAA1";
            int index = model.Id - 1;

            if (index >= paging.itemPerPage * paging.CurrentPageIndex && index < paging.itemPerPage * (paging.CurrentPageIndex + 1) && model.Name.Contains(keyToSrch))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

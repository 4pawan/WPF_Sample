using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.ViewModel;

namespace Demo1.Repository
{
    public class SearchById : ICondition
    {
        private PaginationViewModel paging;
        private EmpFormViewModel model;

        public SearchById(PaginationViewModel paging, EmpFormViewModel model)
        {
            this.paging = paging;
            this.model = model;
        }


        public bool Evaluate()
        {

            if (string.IsNullOrEmpty(paging.SearchById) || model.Name.Contains(paging.SearchById))
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

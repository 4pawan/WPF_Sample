using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.ViewModel;

namespace Demo1.Repository
{
    public class SearchByName : ICondition
    {
        private PaginationViewModel paging;
        private EmpFormViewModel model;

        public SearchByName(PaginationViewModel paging, EmpFormViewModel model)
        {
            this.paging = paging;
            this.model = model;
        }


        public bool Evaluate()
        {
            if (string.IsNullOrEmpty(paging.SearchByName) || model.Name.Contains(paging.SearchByName))
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

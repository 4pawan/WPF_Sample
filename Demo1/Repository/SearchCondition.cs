﻿using System;
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
        private ICondition srchById;
        private ICondition srchByName;
        private ICondition pagingCondition;

        public SearchCondition(PaginationViewModel paging, EmpFormViewModel model)
        {
            this.paging = paging;
            this.model = model;
            srchById = new SearchById(paging, model);
            srchByName = new SearchByName(paging, model);
            pagingCondition = new PagingCondition(paging, model);
        }


        public bool Evaluate()
        {
            if (pagingCondition.Evaluate() && srchById.Evaluate() && srchByName.Evaluate())
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

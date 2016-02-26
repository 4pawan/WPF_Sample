using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Enum;

namespace Demo1.ViewModel
{
    public class SortColumnViewModel
    {
        private MainViewModel _viewModel;

        public SortDir IdSortOrder { get; set; }
        public SortDir NameSortOrder { get; set; }



        public SortColumnViewModel(MainViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public SortColumnViewModel()
        {
            
        }

    }
}

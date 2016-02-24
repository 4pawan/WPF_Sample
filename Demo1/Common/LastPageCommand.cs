using System;
using System.Windows.Input;
using Demo1.ViewModel;

namespace Demo1.Common
{
    class LastPageCommand : ICommand
    {
        private PaginationViewModel  viewModel;

        public LastPageCommand(PaginationViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.CurrentPage != viewModel.TotalPages;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            viewModel.ShowLastPage();
        }
    }
}

using System;
using System.Windows.Input;
using Demo1.ViewModel;

namespace Demo1.Common
{
    class NextPageCommand : ICommand
    {
        private PaginationViewModel viewModel;

        public NextPageCommand(PaginationViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.TotalPages - 1 > viewModel.CurrentPageIndex;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            viewModel.ShowNextPage();
        }
    }
}

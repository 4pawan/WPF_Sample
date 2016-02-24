using System;
using System.Windows.Input;
using Demo1.ViewModel;

namespace Demo1.Common
{
    class FirstPageCommand : ICommand
    {
        private PaginationViewModel viewModel;

        public FirstPageCommand(PaginationViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.CurrentPageIndex != 0;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            viewModel.ShowFirstPage();
        }
    }
}

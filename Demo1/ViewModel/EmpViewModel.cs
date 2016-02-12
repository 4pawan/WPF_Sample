using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Demo1.Common;
using Demo1.Model;
using Demo1.Service;
using GalaSoft.MvvmLight.Command;

namespace Demo1.ViewModel
{
    public class EmpViewModel : ViewModelBase
    {
        private ObservableCollection<EmpModel> empList;
        public ICommand ImportCommand { get; set; }

        private ICommand _searchCommand;
        public ICommand NavigateToForm { get; set; }
        public ICommand SearchCommand
        {
            get { return _searchCommand; }
            set { _searchCommand = value; }
        }

        private bool _isImportDataVisible;

        public bool IsImportDataVisible
        {
            get { return _isImportDataVisible; }
            set
            {
                _isImportDataVisible = value;
                OnPropertyChanged();
            }
        }


        private bool _isSearchVissible;

        public bool IsSearchVisible
        {
            get { return _isSearchVissible; }
            set
            {
                _isSearchVissible = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<EmpModel> EmpList
        {
            get { return empList; }
            set
            {
                empList = value;
            }
        }



        public EmpViewModel()
        {

            EmpList = EmpService.GetEmpList();

            ImportCommand = new RelayCommand(() =>
            {
                IsImportDataVisible = true;
                IsSearchVisible = false;
            }, () => true);

            SearchCommand = new RelayCommand(() =>
            {
                IsImportDataVisible = false;
                IsSearchVisible = true;
            }, () => true);

            NavigateToForm = new RelayCommand(() =>
            {
                IsImportDataVisible = false;
                IsSearchVisible = true;
            }, () => true);

            IsImportDataVisible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Demo1.Common;
using Demo1.Model;
using Demo1.Service;
using GalaSoft.MvvmLight.Command;

namespace Demo1.ViewModel
{
    public class EmpViewModel : ViewModelBase
    {
        private ObservableCollection<EmpFormViewModel> empList;
        public CollectionViewSource ViewList { get; set; }
        public ICommand ImportCommand { get; set; }

        public PaginationViewModel Paging
        {
            get { return _paging; }
            set
            {
                _paging = value;
                OnPropertyChanged();
            }
        }


        private ICommand _searchCommand;

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
        private PaginationViewModel _paging;

        public bool IsSearchVisible
        {
            get { return _isSearchVissible; }
            set
            {
                _isSearchVissible = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<EmpFormViewModel> EmpList
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

            ViewList = new CollectionViewSource();
            ViewList.Source = EmpList;
            //ViewList.Filter += new FilterEventHandler(view_Filter);
            Paging = new PaginationViewModel();
            Paging.PeopleList = empList;
            Paging.ViewList = ViewList;

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

            IsImportDataVisible = true;
        }
    }
}

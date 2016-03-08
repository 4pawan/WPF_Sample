using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Demo1.Common;
using Demo1.Enum;
using Demo1.Model;
using Demo1.Service;
using GalaSoft.MvvmLight.Command;

namespace Demo1.ViewModel
{
    public class EmpViewModel : ViewModelBase
    {
        private ObservableCollection<EmpFormViewModel> _empList;
        //public CollectionViewSource ViewList { get; set; }
        public ICommand ImportCommand { get; set; }
        public ICommand SortCommand1 { get; set; }
        public SortColumnViewModel SortColumn { get; set; }

        public ICommand NavigateToForm { get; set; }

        public EmpFormViewModel EmpFormViewModel
        {
            get { return _empFormViewModel; }
            set
            {
                _empFormViewModel = value;
                OnPropertyChanged();
            }
        }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
                Paging.ViewList.View.Refresh();
            }
        }


        public EmpFormViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }


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
        private EmpFormViewModel _selectedItem;
        private EmpFormViewModel _empFormViewModel;

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
            get { return _empList; }
            set
            {
                _empList = value;
            }
        }



        public EmpViewModel()
        {
            //SortColumn = new SortColumnViewModel();
            EmpList = EmpService.GetEmpList();

            //ViewList = new CollectionViewSource();
            //ViewList.Source = EmpList;
            Paging = new PaginationViewModel
            {
                PeopleList = _empList,
                //ViewList = (CollectionViewSource)EmpList
            };
            Paging.ViewList.Filter += ViewList_Filter;


            ImportCommand = new RelayCommand(() =>
            {
                IsImportDataVisible = true;
                IsSearchVisible = false;
            }, () => true);

            SearchCommand = new RelayCommand(() =>
            {
                IsImportDataVisible = false;
                IsSearchVisible = true;
                EmpFormViewModel = new EmpFormViewModel();
            }, () => true);


            NavigateToForm = new RelayCommand<dynamic>(vm =>
            {
                this.IsImportDataVisible = false;
                this.IsSearchVisible = true;

                if (vm != null) EmpFormViewModel = vm;
            });

            SortCommand1 = new RelayCommand<dynamic>(item =>
            {
                if (string.Equals(item, "Name", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (SortColumn.NameSortOrder == SortDir.Descending)
                    {
                        Paging.ViewList.SortDescriptions.Clear();
                        Paging.ViewList.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                        SortColumn.NameSortOrder = SortDir.Ascending;
                    }
                    else
                    {
                        Paging.ViewList.SortDescriptions.Clear();
                        Paging.ViewList.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Descending));
                        SortColumn.NameSortOrder = SortDir.Descending;
                    }
                }

                if (string.Equals(item, "Id", StringComparison.InvariantCultureIgnoreCase))
                {

                    // Paging.ViewList.View.Filter(propfull=) implement filter based on textBox 

                    if (SortColumn.NameSortOrder == SortDir.Descending)
                    {
                        Paging.ViewList.SortDescriptions.Clear();
                        Paging.ViewList.SortDescriptions.Add(new SortDescription("Id", ListSortDirection.Ascending));
                        SortColumn.NameSortOrder = SortDir.Ascending;
                    }
                    else
                    {
                        Paging.ViewList.SortDescriptions.Clear();
                        Paging.ViewList.SortDescriptions.Add(new SortDescription("Id", ListSortDirection.Descending));
                        SortColumn.NameSortOrder = SortDir.Descending;
                    }
                }

            }, item => true);

            IsImportDataVisible = true;
        }


        private void ViewList_Filter(object sender, FilterEventArgs e)
        {
            //var obj = e.Item as Model;
            //if (obj != null)
            //{
            //    if (obj.Name.Contains("Max"))
            //        e.Accepted = true;
            //    else
            //        e.Accepted = false;
            //}
            //var ed = new Enumerable<string>();




            int index = ((EmpFormViewModel)e.Item).Id - 1;
            if (index >= Paging.itemPerPage * Paging.CurrentPageIndex && index < Paging.itemPerPage * (Paging.CurrentPageIndex + 1))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }

        }
    }
}

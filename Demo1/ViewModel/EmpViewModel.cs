﻿using System;
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
        private ObservableCollection<EmpFormViewModel> empList;
        public CollectionViewSource ViewList { get; set; }
        public ICommand ImportCommand { get; set; }
        public ICommand SortCommand { get; set; }

        public SortColumnViewModel SortColumn { get; set; }



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
            SortColumn = new SortColumnViewModel();
            EmpList = EmpService.GetEmpList();

            ViewList = new CollectionViewSource();
            ViewList.Source = EmpList;
            Paging = new PaginationViewModel
            {
                PeopleList = empList,
                ViewList = ViewList
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
            }, () => true);

            SortCommand = new RelayCommand<dynamic>(item =>
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

using Demo1.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace Demo1.ViewModel
{
    public class PaginationViewModel : ViewModelBase
    {
        #region Commands
        public ICommand PreviousCommand { get; private set; }
        public ICommand NextCommand { get; private set; }
        public ICommand FirstCommand { get; private set; }
        public ICommand LastCommand { get; private set; }
        #endregion

        #region Fields And Properties
        private int itemPerPage = 15;
        private int itemcount;
        private int _currentPageIndex;
        public int CurrentPageIndex
        {
            get { return _currentPageIndex; }
            set
            {
                _currentPageIndex = value;
                OnPropertyChanged("CurrentPage");
            }
        }
        public int CurrentPage
        {
            get { return _currentPageIndex + 1; }
        }

        private int _totalPages;
        public int TotalPages
        {
            get { return _totalPages; }
            private set
            {
                _totalPages = value;
                OnPropertyChanged("TotalPage");
            }
        }

        public CollectionViewSource ViewList { get; set; }
        private ObservableCollection<EmpFormViewModel> _empList = new ObservableCollection<EmpFormViewModel>();
        public ReadOnlyObservableCollection<EmpFormViewModel> PeopleList
        {
            get { return new ReadOnlyObservableCollection<EmpFormViewModel>(_empList); }
        }
        #endregion

        #region Pagination Methods
        public void ShowNextPage()
        {
            CurrentPageIndex++;
            ViewList.View.Refresh();
        }

        public void ShowPreviousPage()
        {
            CurrentPageIndex--;
            ViewList.View.Refresh();
        }

        public void ShowFirstPage()
        {
            CurrentPageIndex = 0;
            ViewList.View.Refresh();
        }

        public void ShowLastPage()
        {
            CurrentPageIndex = TotalPages - 1;
            ViewList.View.Refresh();
        }

        void view_Filter(object sender, FilterEventArgs e)
        {
            int index = ((EmpFormViewModel)e.Item).Id - 1;
            if (index >= itemPerPage * CurrentPageIndex && index < itemPerPage * (CurrentPageIndex + 1))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }

        private void CalculateTotalPages()
        {
            if (itemcount % itemPerPage == 0)
            {
                TotalPages = (itemcount / itemPerPage);
            }
            else
            {
                TotalPages = (itemcount / itemPerPage) + 1;
            }
        }
        #endregion

        public PaginationViewModel()
        {
            populateList();

            ViewList = new CollectionViewSource();
            ViewList.Source = PeopleList;
            ViewList.Filter += view_Filter;

            CurrentPageIndex = 0;
            itemcount = _empList.Count;
            CalculateTotalPages();

            NextCommand = new RelayCommand(ShowNextPage, () => TotalPages - 1 > CurrentPageIndex);

            PreviousCommand = new RelayCommand(ShowPreviousPage, () => CurrentPageIndex != 0);

            FirstCommand = new RelayCommand(ShowFirstPage, () => CurrentPageIndex != 0);

            LastCommand = new RelayCommand(ShowLastPage, () => CurrentPage != TotalPages);
        }

        private void populateList()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    peopleList.Add(new Person(i, "Jack", "Black"));
            //}
        }
    }
}

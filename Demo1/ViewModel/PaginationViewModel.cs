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
        public ICommand PreviousCommand { get; set; }
        public ICommand NextCommand { get; set; }
        public ICommand FirstCommand { get; set; }
        public ICommand LastCommand { get; set; }

        #endregion

        #region Fields And Properties
        public int itemPerPage = 10;
        private int itemcount;
        private int _currentPageIndex;




        public int CurrentPageIndex
        {
            get { return _currentPageIndex; }
            set
            {
                _currentPageIndex = value;
                OnPropertyChanged();
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

        public CollectionViewSource ViewList
        {
            get { return _viewList; }
            set
            {
                _viewList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<EmpFormViewModel> _empList;
        private CollectionViewSource _viewList = new CollectionViewSource();


        public ObservableCollection<EmpFormViewModel> PeopleList
        {
            get { return new ObservableCollection<EmpFormViewModel>(_empList); }
            set
            {
                _empList = value;
                OnPropertyChanged();
                itemcount = _empList.Count;
                CalculateTotalPages();
            }
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
            CurrentPageIndex = 0;

            NextCommand = new NextPageCommand(this);
            PreviousCommand = new PreviousPageCommand(this);
            FirstCommand = new FirstPageCommand(this);
            LastCommand = new LastPageCommand(this);
        }
    }
}

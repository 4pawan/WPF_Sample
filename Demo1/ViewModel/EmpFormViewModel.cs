using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Demo1.Common;
using Demo1.Model;
using Demo1.Properties;
using GalaSoft.MvvmLight.Command;


namespace Demo1.ViewModel
{
    public class EmpFormViewModel : ViewModelBase, IDataErrorInfo
    {
        private string _name;
        private int _age;
        private string _salary;

        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }


     
        public string Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; set; }

        public EmpFormViewModel()
        {

            SaveCommand = new RelayCommand(() =>
            {

                var age = this.Age;
                var name = this.Name;
                var model = new EmpFormViewModel
                {
                    Name = this.Name,
                    Age = this.Age
                };
                Service.EmpService.AddEmp(model);

            }, () => true);


            //NavigateToForm = new RelayCommand<dynamic>(model =>
            //{
            //    if (model == null) return;
            //    EmpViewModel empModel = model[0] as EmpViewModel;
            //    if (empModel == null) return;
            //    empModel.IsImportDataVisible = false;
            //    empModel.IsSearchVisible = true;

            //}, model => true);
        }

        [StringLength(5, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "EmpFormViewModel_Name_Name_cant_be_more_than_5_char")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }


        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Age")
                {
                    int age = -1;
                    int.TryParse(Age.ToString(), out age);

                    if (Age <= 0)
                    {
                        return "Please enter valid age";
                    }
                }
                if (columnName == "Name")
                {
                    if (string.IsNullOrEmpty(Name))
                    {
                        return "Please enter valid Name";
                    }
                }

                if (columnName == "Salary")
                {
                    int salary = -1;
                    int.TryParse(Salary, out salary);

                    if (salary <= 0)
                    {
                        return "Please enter valid salary";
                    }
                }

                return null;
            }
        }

        public string Error { get; }
    }
}

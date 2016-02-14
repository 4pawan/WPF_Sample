using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Model;
using Demo1.ViewModel;

namespace Demo1.Service
{
    public static class EmpService
    {
        private static readonly ObservableCollection<EmpFormViewModel> empList;
        static EmpService()
        {
            empList = new ObservableCollection<EmpFormViewModel>();
            for (int i = 0; i < 1000; i++)
            {
                empList.Add(new EmpFormViewModel
                {
                    Id = i + 1,
                    Name = "AAA" + (i + 1),
                    Age = i + 1
                });
            }
        }


        public static ObservableCollection<EmpFormViewModel> GetEmpList()
        {
            return empList;
        }

        public static void AddEmp(EmpFormViewModel emp)
        {
            empList.Add(emp);
        }

        public static void EditEmp(EmpFormViewModel emp)
        {

        }
        public static void DeleteEmp(EmpFormViewModel emp)
        {

        }
    }
}

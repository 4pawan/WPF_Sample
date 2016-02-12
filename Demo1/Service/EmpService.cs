using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo1.Model;

namespace Demo1.Service
{
    public static class EmpService
    {
        private static readonly ObservableCollection<EmpModel> empList;
        static EmpService()
        {
            empList = new ObservableCollection<EmpModel>
            {
                new EmpModel { Name="AAA" ,Age=10 },
                new EmpModel { Name="BBB" ,Age=30 },
                new EmpModel { Name="CCC" ,Age=50 },
                new EmpModel { Name="DDD" ,Age=20 }
            };
        }


        public static ObservableCollection<EmpModel> GetEmpList()
        {
            return empList;
        }

        public static void AddEmp(EmpModel emp)
        {
            empList.Add(emp);
        }

        public static void EditEmp(EmpModel emp)
        {
           
        }
        public static void DeleteEmp(EmpModel emp)
        {

        }
    }
}

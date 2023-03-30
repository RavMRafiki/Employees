using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownicy.Model
{
    class MainModel
    {
        List<Employee> employed = new List<Employee>();
        public void SaveClick(string _name, string _surname, decimal _salary, DateTime _birthday, Employee.Position _positionValue, Employee.TypeOfContract _contract)
        {
            Employee employee = new Employee();
            employee.Name = _name;
            employee.Surname = _surname;
            employee.Salary = _salary;
            employee.Birthday = _birthday;
            employee.PositionValue = _positionValue;
            employee.Contract = _contract;
            employed.Add(employee);
            //UpdateView();

        }
    }
}

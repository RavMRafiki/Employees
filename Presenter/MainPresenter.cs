using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownicy.Presenter
{
    class MainPresenter
    {
        private View.Form1 _view;
        private Model.MainModel _model;
        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            _view = view;
            _model = model;

            _view.SaveClick += _view_SaveClick;
            UpdateView();
        }
        private void UpdateView() => _view.DisplayList = _model.employed;
        public void _view_SaveClick(string _name, string _surname, decimal _salary, DateTime _birthday, Employee.Position _positionValue, Employee.TypeOfContract _contract)
        {
            //List<Employee> theEmployees = new List<Employee>();
            //Employee employeeee = new Employee();
            //employeeee.Name = "hfjh";
            //theEmployees.Add(employeeee);
            //_view.DisplayList = theEmployees;

            Employee employee = new Employee();
            employee.Name = _name;
            employee.Surname = _surname;
            employee.Salary = _salary;
            employee.Birthday = _birthday;
            employee.PositionValue = _positionValue;
            employee.Contract = _contract;

            _model.employed.Add(employee);

            UpdateView();

        }
    }
}

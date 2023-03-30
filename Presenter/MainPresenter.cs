using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

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
            _view.SaveToXmlClick += _view_SaveToXmlClick;
            _view.ReadFromXmlClick += _view_ReadFromXmlClick;
            UpdateView();
        }

        private void _view_ReadFromXmlClick()
        {


            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Employee>));

            using (FileStream fs2 = File.OpenRead(@"C:\Serializacja\emloyees.xml"))
            {
                _model.employed = (List<Employee>)serializer3.Deserialize(fs2);
            }
            UpdateView();

        }
    

        private void _view_SaveToXmlClick()
        {

            using (Stream fs = new FileStream(@"C:\Serializacja\emloyees.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Employee>));
                serializer2.Serialize(fs, _model.employed);
            }
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

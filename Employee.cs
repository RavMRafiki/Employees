using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownicy
{
    class Employee
    {
        public enum Position { Tester, Designer, Engineer, Developer};
        public enum TypeOfContract { Praca, Zlecenie, Dzielo};
        private DateTime _birthday;
        private Position _position;
        private TypeOfContract _contract;
        private string _name, _surname;
        private decimal _salary;
        public string Name
        {
            get => _name;
        }
        public string Surname
        {
            get => _surname;
        }
        public decimal Salary
        {
            get => _salary;
        }
        public override string ToString()
        {
            return "";
        }
    }
}

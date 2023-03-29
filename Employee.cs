using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;


namespace pracownicy
{
    public class Employee : ISerializable
    {
        [Serializable()]
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
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public decimal Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }
        public Position PositionValue
        {
            get => _position;
            set => _position = value;
        }
        public TypeOfContract Contract
        {
            get => _contract;
            set => _contract = value;
        }
        public override string ToString()
        {
            return _name + " " + _surname + " Urodzony: " + _birthday.ToString() + " Zarobek: " + _salary + " Umowa: " + _contract + " Na pozycji: " + _position;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Surname", Surname);
            info.AddValue("Salary", Salary);
            info.AddValue("Birthday", Birthday);
            info.AddValue("Position", PositionValue);
            info.AddValue("Contract", Contract);
        }
        public Employee(SerializationInfo info,StreamingContext ctxt)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Surname = (string)info.GetValue("Surname", typeof(string));
            Salary = (decimal)info.GetValue("Salary", typeof(decimal));
            Birthday = (DateTime)info.GetValue("Birthday", typeof(DateTime));
            PositionValue = (Position)info.GetValue("Position", typeof(Position));
            Contract = (TypeOfContract)info.GetValue("Contract", typeof(TypeOfContract));


        }

        public Employee()
        {
        }
    }
}

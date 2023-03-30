using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization;
using System.Globalization;

namespace pracownicy.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Action SaveClick;
        public List<Employee> DisplayList
        {
            set
            {
                employeeList.ResetText();
                foreach (var element in value)
                {
                    employeeList.Items.Add(element);
                }
            }
            get
            {
                List<Employee> theEmployees = new List<Employee>();
                foreach (var listBoxItem in employeeList.Items)
                {
                    theEmployees.Add((Employee)listBoxItem);
                }
                return theEmployees;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string _name = textBox_name.Text;
            string _surname = textBox_surname.Text;
            decimal _salary = numericUpDown_salary.Value;
            DateTime _birthday = dateTimePicker_birthday.Value;
            Employee.Position _positionValue = (Employee.Position)comboBox_position.SelectedItem;
            Employee.TypeOfContract _contract = ContractStatus();
            //employeeList.Items.Add(employee);
            SaveClick?.DynamicInvoke(_name,_surname,_salary,_birthday,_positionValue,_contract);
        }

        private Employee.TypeOfContract ContractStatus()
        {
            if (radioButton_dzielo.Checked)
            {
                return Employee.TypeOfContract.Dzielo;
            }
            else if (radioButton_zlecenie.Checked)
            {
                return Employee.TypeOfContract.Zlecenie;
            }
            else
            {
                return Employee.TypeOfContract.Praca;
            }
        }

        //private void SaveToXml(object sender, EventArgs e)
        //{
        //    List<Employee> theEmployees = new List<Employee> { };

        //    foreach (var listBoxItem in employeeList.Items)
        //    {
        //        theEmployees.Add((Employee)listBoxItem);
        //    }

        //    using (Stream fs = new FileStream(@"C:\Serializacja\emloyees.xml", FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        XmlSerializer serializer2 = new XmlSerializer(typeof(List<Employee>));
        //        serializer2.Serialize(fs, theEmployees);
        //    }
        //}

        //private void ReadFormXml(object sender, EventArgs e)
        //{
        //    List<Employee> theEmployees = new List<Employee> { };

        //    XmlSerializer serializer3 = new XmlSerializer(typeof(List<Employee>));

        //    using (FileStream fs2 = File.OpenRead(@"C:\Serializacja\emloyees.xml"))
        //    {
        //        theEmployees = (List<Employee>)serializer3.Deserialize(fs2);
        //    }

        //    foreach (Employee __employee in theEmployees)
        //    {
        //        employeeList.Items.Add(__employee);
        //    }
        //}

    }
}

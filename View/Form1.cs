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

        public event Action<string, string, decimal, DateTime, Employee.Position, Employee.TypeOfContract> SaveClick;
        public event Action SaveToXmlClick;
        public event Action ReadFromXmlClick;
        public event Action<int> EditEmployeeClick;
        public List<Employee> DisplayList
        {
            set
            {
                employeeList.Items.Clear();
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
        public Employee EditedEmployee
        {
            set
            {
                textBox_name.Text = value.Name;
                textBox_surname.Text = value.Surname;
                numericUpDown_salary.Value = value.Salary;
                dateTimePicker_birthday.Value = value.Birthday;
                comboBox_position.SelectedItem = value.PositionValue;
                if(value.Contract == Employee.TypeOfContract.Dzielo)
                {
                    radioButton_dzielo.Checked = true;
                } else if(value.Contract == Employee.TypeOfContract.Zlecenie)
                {
                    radioButton_zlecenie.Checked = true;
                }
                else
                {
                    radioButton_praca.Checked = true;
                }
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

        private void save_to_xml(object sender, EventArgs e)
        {

            SaveToXmlClick?.Invoke();

        }

        private void read_from_xml(object sender, EventArgs e)
        {
            ReadFromXmlClick?.Invoke();
        }

        private void button_edit_click(object sender, EventArgs e)
        {
            
            EditEmployeeClick?.Invoke(employeeList.SelectedIndex);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracownicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = textBox_name.Text;
            employee.Surname = textBox_surname.Text;
            employee.Salary = numericUpDown_salary.Value;
            employee.Birthday = dateTimePicker_birthday.Value;
            employee.PositionValue = (Employee.Position)comboBox_position.SelectedItem;
            employee.Contract = ContractStatus();
            employeeList.Items.Add(employee);
        }

        private Employee.TypeOfContract ContractStatus()
        {
            if (radioButton_dzielo.Checked)
            {
                return Employee.TypeOfContract.Dzielo;
            } else if (radioButton_zlecenie.Checked)
            {
                return Employee.TypeOfContract.Zlecenie;
            }
            else
            {
                return Employee.TypeOfContract.Praca;
            }
        }
    }
}

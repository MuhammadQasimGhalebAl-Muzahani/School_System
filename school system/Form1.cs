using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School;

namespace SchoolSmallSystem
{
    
    public partial class Form1 : Form
    {
        public List<IEmployee> employee = new List<IEmployee>();
        EmployeeType employeetype;
        public Form1()
        {
            InitializeComponent();
        }
        // Add Data In Applaication
        private void btnADD_Click(object sender, EventArgs e)
        {
            // get data from TextBox
            int id = int.Parse(textBoxID.Text);
            string name = textBoxname.Text;
            double Salary = double.Parse(textBoxsalary.Text);
            employee.Add(EmployeeFactory.GetEmployeeInstane(employeetype, id, name, Salary));//add employee to list
            labelsumesal.Text = employee.Sum(q => q.Salary).ToString();//return sum salary of all employee
            labelcountemp.Text = employee.Count.ToString();//return count employee in system
            textBoxID.Text = textBoxname.Text = textBoxsalary.Text = "";
        }
        private void typeemployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeetype = (EmployeeType)typeemployee.SelectedIndex;
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            Enable();
            typeemployee.DataSource = Enum.GetValues(typeof(EmployeeType));
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }
        // Function Desplay Button Add
        private void Enable()
        {
            if (textBoxID.Text.Trim() == "" && textBoxname.Text.Trim() == "" && textBoxsalary.Text.Trim() == "") 
                btnADD.Enabled = false;
            else
                btnADD.Enabled = true;
        }

        private void LableTittle_Click(object sender, EventArgs e)
        {

        }
    }
}
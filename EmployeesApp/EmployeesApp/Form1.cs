using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program_Logic;

namespace EmployeesApp
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            employees.Clear();
            foreach(Employee emp in lstEmployees.Items)
            {
                lstEmployees.Items.Add(emp);
            }

            // Adds 10 employees to test the app
            for (int i = 1; i <= 10; i++)
            {
                Employee emp = new Employee("Sample", "Employee " + i, "");
                employees.Add(emp);
                lstEmployees.Items.Add(emp);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checking if there is a selected element
            if (lstEmployees.SelectedItem != null)
            {
                // Searching the employees list to display information in richtextbox
                foreach (Employee emp in employees)
                {
                    if (lstEmployees.SelectedItem.Equals(emp))
                        rtbDisplay.Text = emp.Info();
                }
            }
            else
            {
                return;
            }

        }

        // Method used in form2 to add an element in the list
        public void AddItem(Employee emp)
        {
            lstEmployees.Items.Add(emp);
            employees.Add(emp);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        // Removing the selected element
        private void btnRemove_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = string.Empty;
            if (lstEmployees.SelectedItem != null)
            {
                employees.RemoveAt(lstEmployees.SelectedIndex);
                lstEmployees.Items.Remove(lstEmployees.SelectedItem);
            }
        }

        // Searching an element
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            rtbDisplay.Text = string.Empty;
            string search = txtSearch.Text;
            if (string.IsNullOrEmpty(search) == false)
            {
                // Clearing the list not to show any unwanted results
                lstEmployees.Items.Clear();
                // Searching in the employees list for any element that contains 'search' string
                foreach (Employee emp in employees)
                {
                    if (emp.ToString().Contains(search))
                    {
                        lstEmployees.Items.Add(emp);
                    }
                }
            }
            // If there is nothing to search it will show the list as usual
            else if (search == string.Empty)
            {
                lstEmployees.Items.Clear();
                foreach (Employee emp in employees)
                {
                    lstEmployees.Items.Add(emp);
                }
            }
        }
    }
}

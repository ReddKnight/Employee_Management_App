using Program_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesApp
{
    public partial class Form2 : Form
    {
        Form1 form;

        // Reference from form1 to be able to add elemnts into the listbox
        public Form2(Form1 frm)
        {
            InitializeComponent();
            form = frm;
        }

        // Adding an element into the listbox
        private void btnAdd_2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text) == false && string.IsNullOrEmpty(txtLname.Text) == false)
            {
                Employee emp = new Employee(txtFname.Text, txtLname.Text, txtOther.Text);
                form.AddItem(emp);
                this.Hide();
            }
            else
            {
                lblError.Show();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructors_ListView.GUI
{
    public partial class FormEmployee2 : Form
    {
        public FormEmployee2()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;

            emp.SaveEmployee(emp);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee();

            emp = emp.SearchEmployee(Convert.ToInt32(textBoxEmpId.Text));

            if (emp != null)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);

                listViewEmp.Items.Add(item);
            }

            else
            {
                MessageBox.Show("employee Not Found!");
            }




        }
    }
}

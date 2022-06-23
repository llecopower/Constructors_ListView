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
    public partial class FormEmployee : Form
    {

        List<Employee> listEmp = new List<Employee>();


        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            //Creation of an Object of type Employee
            Employee emp = new Employee();

            //Store data in the object
            emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;

            //Add to List listEmp
            listEmp.Add(emp);



        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewEmp.Items.Clear();

            foreach (Employee emp in listEmp)
            {

                //// List the Individual object Employee
                // MessageBox.Show(emp.EmployeeId + ", " + emp.FirstName + ", " + emp.LastName);

                //List the object from the LIST listEmp
                ListViewItem item = new ListViewItem((emp.EmployeeId).ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);

                listViewEmp.Items.Add(item);

            }

            


        }
    }
}

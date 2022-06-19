using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remake_portal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void student_registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.student_registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registryDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registryDataSet.student_registration' table. You can move, or remove it, as needed.
            this.student_registrationTableAdapter.Fill(this.registryDataSet.student_registration);
           

        }

        private void reg_noTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string registration = reg_noTextBox.Text.ToString();
            string name = first_nameTextBox.Text.ToString();
            string last_name = last_nameTextBox.Text.ToString();
            string email = email_addressTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            string confirm_password = confirm_passwordTextBox.Text.ToString();

            MessageBox.Show("Registration complete");
        }
    }
}

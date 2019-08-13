using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace Library_PR
{
    public partial class RegistrationLoginForm : MaterialForm
    {
        Form1 form1=null;

        bool mode = false; // true - registration ; false -login 

        public CustomerModel currentCustomer=null;

        public List<CustomerModel> customers= new List<CustomerModel>();

        public RegistrationLoginForm()
        {
            InitializeComponent();
        }

        public RegistrationLoginForm( Form1 form1)
        {
            this.form1 = form1;
           
            InitializeComponent();
        }

        private void RegistrationLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void signUpRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (loginRBtn.Checked)
            {
                mode = false;

                nameLabel.Visible = false;
                nameTextBox.Visible = false;

                login2Label.Visible = false;
                login2TextBox.Visible = false;

                emailLabel.Visible = false;
                emailTextBox.Visible = false;

                pass2Label.Visible = false;
                pass2TextBox.Visible = false;

                loginLabel.Visible = true;
                loginTextBox.Visible = true;

                passLabel.Visible = true;
                passTextBox.Visible = true;
            }
            else
            {
                mode = true;

                nameLabel.Visible = true;
                nameTextBox.Visible = true;

                login2Label.Visible = true;
                login2TextBox.Visible = true;

                emailLabel.Visible = true;
                emailTextBox.Visible = true;

                pass2Label.Visible = true;
                pass2TextBox.Visible = true;

                loginLabel.Visible = false;
                loginTextBox.Visible = false;

                passLabel.Visible = false;
                passTextBox.Visible = false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            currentCustomer = null;
            try
            {
                customers = SqliteDataAccess.LoadCustomers();
            }catch(Exception ex)
            {
                MessageBox.Show("Немає зареєстрованих користувачів");
            }

            if (mode) // registration
            {
                bool flag = false;

                foreach (CustomerModel customer in customers)
                {
                    if (customer.Login.Equals(login2TextBox.Text))
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    SqliteDataAccess.SaveCustomers(new CustomerModel(nameTextBox.Text, login2TextBox.Text, emailTextBox.Text, pass2TextBox.Text));
                    MessageBox.Show("Новий користувач зареєстрований");

                    nameTextBox.Text = "";
                    login2TextBox.Text = "";
                    emailTextBox.Text = "";
                    pass2TextBox.Text = "";
                }
                else
                {
                    login2TextBox.Text = "";
                    attentionLabel.Visible = true;
                    attentionLabel.Text = "Користувач з таким логіном уже присутній";
                }

            }
            else
            {
                foreach(CustomerModel c in customers)
                {
                    if(c.Login.Equals(loginTextBox.Text) && c.Password.Equals(passTextBox.Text))
                    {
                        currentCustomer = c;
                        break;
                    }
                }
                if(currentCustomer == null)
                {
                    MessageBox.Show("Невірно введений логін або пароль");
                }
                else
                {
                    loginTextBox.Text = "";
                    passTextBox.Text = "";
                    form1.currCustomer = currentCustomer;
                    form1.Reload_Form();
                    this.Hide();

                }
            }
        }
    }
}

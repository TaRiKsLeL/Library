using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_PR
{
    public class CustomerModel
    {
        public int Customer_Id { get; set; }

        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public CustomerModel()
        {

        }
        public CustomerModel(string name, string login, string email, string password)
        {
            this.Name = name;
            this.Login = login;
            this.Email = email;
            this.Password = password;
        }
    }
}

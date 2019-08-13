using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_PR
{
    public class SqliteDataAccess
    {
        public static List<BookModel> LoadBooks()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                var output = cnn.Query<BookModel>("select * from Books", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveBooks(BookModel book)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                cnn.Execute("insert into Books (Title,Author,Type,Pages,On_Storage) values (@Title,@Author,@Type,@Pages,@On_Storage)", book);
            }
        }

        public static void UpdateStorageByBookID(int bookId, int newStorage)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                cnn.Execute("update Books set On_Storage="+newStorage+" where Book_Id="+bookId);
            }
        }


        public static List<CustomerModel> LoadCustomers()
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>("select * from Customers", new DynamicParameters());
                return output.ToList();
            }
        }

        

        public static void SaveCustomers(CustomerModel customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customers (Name,Login,Email,Password) values (@Name,@Login,@Email,@Password)", customer);
            }
        }

        public static void UpdateCustomerByID(int custId, CustomerModel newCustomer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                cnn.Execute("update Customers set Name='" + newCustomer.Name + "', Login='"+newCustomer.Login+"', Email='"+newCustomer.Email+"', Password='"+newCustomer.Password+"'  where Customer_Id=" + custId);
            }
        }

        public static List<OrderModel> LoadOrders()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OrderModel>("select * from Orders", new DynamicParameters());
                return output.ToList();
            }
        }


        public static List<OrderBookModel> LoadInfoAboutOrdered()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                var output = cnn.Query<OrderBookModel>("select * from Order_Book", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveOrders(OrderModel order)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Orders (Customer_Id,Date) values (@Customer_Id,@Date)", order);
            }
        }

        public static void SaveOrderedBook(int orderId,int bookId, int amount)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Order_Book values ("+orderId+","+bookId+","+amount+")");
            }
        }

        private static string LoadConnectionString(string id ="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}

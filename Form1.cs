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
    public partial class Form1 : MaterialForm
    {
        public CustomerModel currCustomer;
        BookModel currentBook;
        OrderModel currentOrder;

        public List<BookModel> books = new List<BookModel>();
        public List<BookModel> busketList = new List<BookModel>();
        public List<CustomerModel> customersForCheck = new List<CustomerModel>();
        public Dictionary<BookModel, int> busketDictionary = new Dictionary<BookModel, int>();

        List<OrderModel> ordersKek = new List<OrderModel>();
        List<OrderBookModel> orderBookModels = new List<OrderBookModel>();

       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            logoutBtn.Visible = false;
            loginBtn.Visible = true;
            hello2Label.Text = "Вітаю! \nБудь ласка авторизуйтесь";
            Reload_Form();
        }

        public void Reload_Form()
        {
            books = SqliteDataAccess.LoadBooks();
            bunifuCustomDataGrid1.DataSource = books;
            bunifuCustomDataGrid1.Columns[0].Visible = false;
            bunifuCustomDataGrid1.Columns[5].Visible = false;
            bunifuCustomDataGrid1.Size = new Size(910, 450);

            if (currCustomer == null)
            {
                logoutBtn.Visible = false;
                panel1.Visible = true;
                loginBtn.Visible = true;
                helloLabel.Visible = false;
                adminAddBookGroupBox.Visible = false;
                addToBusketGroupBox.Visible = false;

                hello2Label.Text = "Вітаю! Будь ласка авторизуйтесь";
            }
            else
            {
                logoutBtn.Visible = true;
                panel1.Visible = false;
                loginBtn.Visible = false;
                helloLabel.Visible = true;

                helloLabel.Text = "Привіт, "+currCustomer.Name;
                hello2Label.Text = "Привіт, " + currCustomer.Name;

                if (currCustomer.Login.Equals("admin"))
                {
                    adminAddBookGroupBox.Visible = true;
                    addToBusketGroupBox.Visible = false;
                    tabPage3.Text = "Замовлення";

                    ordersKek = SqliteDataAccess.LoadOrders();
                    ordersDataGrid.DataSource = ordersKek;

                    orderBookModels = SqliteDataAccess.LoadInfoAboutOrdered();
                    orderBookBataGrid.DataSource = orderBookModels;

                    busketGroupBox.Visible = false;
                    ordersGroupBox.Visible = true;

                    bunifuCustomDataGrid1.Columns[0].Visible = true;
                    bunifuCustomDataGrid1.Columns[5].Visible = true;

                    bunifuCustomDataGrid1.Size = new Size(910, 330);
                }
                else
                {
                    busketGroupBox.Visible = true;
                    ordersGroupBox.Visible = false;
                    tabPage3.Text = "Кошик";


                    adminAddBookGroupBox.Visible = false;
                    addToBusketGroupBox.Visible = true;
                    bunifuCustomDataGrid1.Size = new Size(910, 350);
                }
            }
        }

        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            (new RegistrationLoginForm(this)).ShowDialog();
        }
        

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            currCustomer = null;
            Reload_Form();
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            BindingList<BookModel> myObjList = new BindingList<BookModel>(books);


            if (comboBox1.Text.Equals("Title"))
            {

                BindingList<BookModel> filtered = new BindingList<BookModel>(myObjList.Where(obj => obj.Title.Contains(materialSingleLineTextField1.Text)).ToList());
                bunifuCustomDataGrid1.DataSource = filtered;
                bunifuCustomDataGrid1.Update();
            }
            else if (comboBox1.Text.Equals("Author"))
            {
                BindingList<BookModel> filtered = new BindingList<BookModel>(myObjList.Where(obj => obj.Author.Contains(materialSingleLineTextField1.Text)).ToList());
                bunifuCustomDataGrid1.DataSource = filtered;
                bunifuCustomDataGrid1.Update();
            }
            else if (comboBox1.Text.Equals("Type"))
            {
                BindingList<BookModel> filtered = new BindingList<BookModel>(myObjList.Where(obj => obj.Type.Contains(materialSingleLineTextField1.Text)).ToList());
                bunifuCustomDataGrid1.DataSource = filtered;
                bunifuCustomDataGrid1.Update();
            }
            else if (comboBox1.Text.Equals("Pages"))
            {
                BindingList<BookModel> filtered = new BindingList<BookModel>(myObjList.Where(obj => obj.Pages.ToString().Contains(materialSingleLineTextField1.Text)).ToList());
                bunifuCustomDataGrid1.DataSource = filtered;
                bunifuCustomDataGrid1.Update();
            }

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    currentBook = (BookModel)bunifuCustomDataGrid1.CurrentRow.DataBoundItem; //Отрмую нажату книгу
                    attentionLabel.Text = "Вибрана книга: " + currentBook;

                }
            }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            
        }

        private void addToBasketBtn_Click(object sender, EventArgs e)
        {
            if (currCustomer != null)
            {
                if (currentBook.On_Storage > 0)
                {



                    busketList.Add(currentBook);

                    if (busketDictionary.ContainsKey(currentBook))
                    {
                        DeleteItemsByKey(currentBook, busketDictionary);
                    }
                    busketDictionary.Add(currentBook, GetNumOfBooksInList(currentBook, busketList));
                    attentionLabel.Text = "Товар був добавлений у корзину";
                }
                else
                {
                    MessageBox.Show("На складі товар відсутній!");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка авторизуйтесь!");
            }
        }

        private void tabPage2_Validating(object sender, CancelEventArgs e)
        {
            //busketDataGrid2.DataSource = busketList;
            //busketDataGrid2.Update();

            var source = new BindingSource();
            //source.DataSource = busketList;
            source.DataSource =  (from d in busketDictionary orderby d.Value select new { d.Key, d.Value }).ToList();
            busketDataGrid2.DataSource = source;
            busketDataGrid2.Columns[0].HeaderText = "Book";
            busketDataGrid2.Columns[1].HeaderText = "Amount";
        }

        private int GetNumOfBooksInList(BookModel book, List<BookModel> bookModels)
        {
            int count=0;

            foreach (BookModel bookModel in bookModels)
            {
                if (book.Book_Id == bookModel.Book_Id)
                {
                    count++;
                }
            }

            return count;
        }

        private void DeleteItemsByKey(BookModel bookKey, Dictionary <BookModel, int> busketDictionary)
        {
            busketDictionary.Remove(bookKey);
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            currentOrder = new OrderModel(currCustomer.Customer_Id, dateTime.ToString("dd/MM/yyyy"));

            SqliteDataAccess.SaveOrders(currentOrder);

            List<OrderModel> orders = SqliteDataAccess.LoadOrders();

            foreach (KeyValuePair<BookModel, int> entry in busketDictionary)
            {
                SqliteDataAccess.SaveOrderedBook(orders[orders.Capacity-1].Order_Id, entry.Key.Book_Id, entry.Value);
                SqliteDataAccess.UpdateStorageByBookID(entry.Key.Book_Id, entry.Key.On_Storage - entry.Value);
            }

            MessageBox.Show("Замовлення прийнято!");
            busketDictionary.Clear();
            busketList.Clear();


            var source = new BindingSource();
            source.DataSource = (from d in busketDictionary orderby d.Value select new { d.Key, d.Value }).ToList();
            busketDataGrid2.DataSource = source;
            busketDataGrid2.Columns[0].HeaderText = "Book";
            busketDataGrid2.Columns[1].HeaderText = "Amount";
        }

        private void tabPage4_Validating(object sender, CancelEventArgs e)
        {
            idLabel.Text = "ID: "+currCustomer.Customer_Id;

            currNameTextBox.Text = currCustomer.Name;
            currLoginTextBox.Text = currCustomer.Login;
            currEmailTextBox.Text = currCustomer.Email;
            currPassTextBox.Text = currCustomer.Password;

        }

        private void submitChangesBtn_Click(object sender, EventArgs e)
        {
            customersForCheck = SqliteDataAccess.LoadCustomers();

            attenLabel.Visible = false;

            bool flag = false;

            foreach (CustomerModel customer in customersForCheck)
            {

                if (customer.Customer_Id != currCustomer.Customer_Id)
                {
                    if (customer.Login.Equals(currLoginTextBox.Text) || customer.Email.Equals(currEmailTextBox.Text))
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if (!flag)
            {
                if(!(currNameTextBox.Equals("") || currLoginTextBox.Equals("") || currEmailTextBox.Equals("") || currPassTextBox.Equals("")))
                {
                    SqliteDataAccess.UpdateCustomerByID(currCustomer.Customer_Id, new CustomerModel(currNameTextBox.Text, currLoginTextBox.Text, currEmailTextBox.Text, currPassTextBox.Text));

                    attenLabel.Visible = true;
                    attenLabel.Text = "Дані оновлено!";
                }
                else
                {
                    attenLabel.Visible = true;
                    attenLabel.Text = "Всі поля повинні бути заповнені!";
                }
            }
            else
            {
                attenLabel.Visible = true;
                attenLabel.Text = "Користувач з таким логіном або поштою уже присутній";
            }

            }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if(!(titleTB.Text.Equals("") || authorTB.Text.Equals("") || pagesTB.Text.Equals("") || typeTB.Text.Equals("") || storageTB.Text.Equals("")))
            {
                BookModel tempBook = new BookModel(titleTB.Text, authorTB.Text, typeTB.Text, Convert.ToInt32(pagesTB.Text), Convert.ToInt32(storageTB.Text));
                tempBook.Book_Id = books.Capacity+1;
                SqliteDataAccess.SaveBooks(tempBook);
                MessageBox.Show("Нова книга добавлена");
                Reload_Form();
            }
        }

        private void hello2Label_Click(object sender, EventArgs e)
        {

        }
    }
    }


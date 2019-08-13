using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_PR
{
    public class BookModel
    {
        public int Book_Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public int Pages { get; set; }

        public int On_Storage { get; set; }

        public BookModel()
        {

        }

        public BookModel(string Title, string Author, string Type, int Pages, int On_Storage)
        {
            this.Title = Title;
            this.Author = Author;
            this.Type = Type;
            this.Pages = Pages;
            this.On_Storage = On_Storage;
        }

        public override string ToString()
        {
            return " ''" + Title + "'' " + Author;
        }
    }
}

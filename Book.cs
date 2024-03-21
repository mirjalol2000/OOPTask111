using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask1
{
    internal class Book
    {
        private string author;
        private string value = "Abdulla Qodiriy";
        public string NameOfBook { get; set; }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = ChangeAuthor(author);
            }

        }
        public int CostOfBook { get; set; }

        public Book()
        {
            NameOfBook = "O'tkan kunlar";
        }

        public string ChangeAuthor(string author)
        {
            return author;
        }
    }
}

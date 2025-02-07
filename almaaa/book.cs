using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almaaa
{
    internal class Book
    {
        private string title;
        private string author;
        private int releaseDate;
        private int pageNumber;
        private int price;

        
        public Book(string title, string auther, int releaseDate, int pageNumber, int price)
        {
            this.title = title;
            this.author = auther;
            this.releaseDate = releaseDate;
            this.pageNumber = pageNumber;
            this.price = price;
        }

        public Book(string title, string auther)
        {
            this.title = title;
            this.author = auther;
            this.releaseDate = DateTime.Now.Year;
            this.pageNumber = 200;
            this.price = 3000;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public int Price { get => price; set => price = value; }


        public int PriceInc(int increase)
        {
            return this.price + increase;
        }

        public double Discount(double percent)
        {
            return this.price - (this.price * (percent / 100));
        }

        public int RemainingPages(int read)
        {
            return this.pageNumber - read;

        }

        public override string ToString()
        {
            return $"{title} - {author} / {pageNumber} / {releaseDate} - {price}";
        }

    }
}

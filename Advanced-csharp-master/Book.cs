using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__assigment
{
    internal class Book
    {
        private string _title;
        private string[] _authors;
        private decimal _price;

        public string ISBN { get; set; }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string[] Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }

        public DateTime PublicationDate { get; set; }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }


        public override string ToString()
        {
            return $"Title: {Title}, ISBN: {ISBN}, Authors: {string.Join(", ", Authors)}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    internal class NoneStage : IStage
    {
        private List<Book> _books = new List<Book> { };
        public void Add(Book book)
        {
            this._books.Add(book);
        }

        public double Calculate()
        {
            return this._books.Sum( x => x.Price);
        }
    }
}
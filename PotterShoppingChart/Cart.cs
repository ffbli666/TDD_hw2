using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class Cart
    {
        private Dictionary<string, IStage> _stage = new Dictionary<string, IStage> { };
        private IStage stageFactory(String stage)
        {
            switch (stage)
            {
                case "Potter":
                    return new PotterStage();
                case "BlueGreen":
                    return new BlueGreenStage();
                default:
                    return new NoneStage();
            }
        }

        public double CalculatePrice(List<Book> books)
        {
            foreach(Book book in books)
            {
                IStage stage;
                if( this._stage.ContainsKey(book.Stage) == false)
                {
                    this._stage.Add(book.Stage, stageFactory(book.Stage));
                }
                stage = this._stage[book.Stage];
                stage.Add(book);
            }
            var cal = from d in this._stage
                            select new
                            {
                                d.Key,
                                Amount = d.Value.Calculate()
                            };
            return cal.Sum(x => x.Amount);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_其他都沒買_價格應為_100()
        {
            //100*1=100
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_第二集也買了一本_價格應為_190()
        {
            //100*2*0.95=190
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一二三集各買了一本_價格應為_270()
        {
            //100*3*0.9=270
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一二三四集各買了一本_價格應為_320()
        {
            //100*4*0.8=320
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第四集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一次買了整套_一二三四五集各買了一本_價格應為_375()
        {
            //100*5*0.75=375
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第四集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第五集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一二集各買了一本_第三集買了兩本_價格應為_370()
        {
            //100*3*0.9+100 = 370
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_第二三集各買了兩本_價格應為_460()
        {
            //100*3*0.9 + 100*2*0.95 = 460
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 460;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_第三集買四本_第五集買了三本_價格應為_750()
        {
            //100*3*0.9 + 100*2*0.95*2 + 100 = 750
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第五集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第五集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第五集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 750;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集單價100買了一本_第二集單價110買二本_第三集單價120買了三本_價格應為_635_5()
        {
            //(100+110+120)*0.9 + (110+120)*0.95 + 120 = 297+218.5+120 = 635.5
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=110, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=120, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=110, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=120, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=120, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 635.5;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_第二三集各買了兩本_一律打8折_價格應為_400()
        {
            //500*0.8 = 400
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 400;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_第二三集各買了兩本_買一本藍標二本綠標書_買一本沒有折扣_價格應為_840()
        {
            //100*3*0.9 + 100*2*0.95 = 460
            //藍標+綠標一組可以85折 一藍+二綠 = 270
            // 沒折 100
            // 460 + 270 + 100 = 830
            //arrage
            Cart target = new Cart();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第二集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="哈利波特第三集", Price=100, Stage="Potter"},
                new Book { Name="c#", Price=100, Stage="BlueGreen", Color="Blue"},
                new Book { Name="TDD", Price=100, Stage="BlueGreen", Color="Green"},
                new Book { Name="TDD", Price=100, Stage="BlueGreen", Color="Green"},
                new Book { Name="Hello World", Price=100},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 830;
            Assert.AreEqual(expected, actual);
        }
    }
    internal class StubDiscount : IDiscount
    {
        public double get(int different)
        {
            return 0.8;
        }
    }
}
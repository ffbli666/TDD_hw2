using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingChart.Tests
{
    [TestClass()]
    public class SellTests
    {
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_其他都沒買_價格應為_100()
        {
            //100*1=100
            //arrage
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
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
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
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
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
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
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
                new Book { Name="哈利波特第四集", Price=100},
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
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
                new Book { Name="哈利波特第四集", Price=100},
                new Book { Name="哈利波特第五集", Price=100},
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
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
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
            Sell target = new Sell();
            List<Book> books = new List<Book>
            {
                new Book { Name="哈利波特第一集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
                new Book { Name="哈利波特第二集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
                new Book { Name="哈利波特第三集", Price=100},
            };
            //act
            var actual = target.CalculatePrice(books);
            //assert
            var expected = 460;
            Assert.AreEqual(expected, actual);
        }
    }
}
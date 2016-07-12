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
            //Scenario: 第一集買了一本，其他都沒買，價格應為100 * 1 = 100元
            //Given 第一集買了 1 本
            //And 第二集買了 0 本
            //And 第三集買了 0 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 100 元
            //arrange
            var target = new Cart();
            List<Product> products = new List<Product>
            {
                new Product { Name="哈利波特第一集", Price=100},
            };
            //act
            var actual = target.CalculatePrice(products);
            //assert
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_第一集買了一本_第二集也買了一本_價格應為_190()
        {
            //Scenario: 第一集買了一本，第二集也買了一本，價格應為100 * 2 * 0.95 = 190
            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 0 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 190 元
            //arrange
            var target = new Cart();
            List<Product> products = new List<Product>
            {
                new Product { Name="哈利波特第一集", Price=100},
                new Product { Name="哈利波特第二集", Price=100},
            };
            //act
            var actual = target.CalculatePrice(products);
            //assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一二三集各買了一本_價格應為_270()
        {
            //Scenario: 一二三集各買了一本，價格應為100 * 3 * 0.9 = 270
            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 1 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 270 元
            //arrange
            var target = new Cart();
            List<Product> products = new List<Product>
            {
                new Product { Name="哈利波特第一集", Price=100},
                new Product { Name="哈利波特第二集", Price=100},
                new Product { Name="哈利波特第三集", Price=100},
            };
            //act
            var actual = target.CalculatePrice(products);
            //assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一二三四集各買了一本_價格應為_320()
        {
            //Scenario: 一二三四集各買了一本，價格應為100 * 4 * 0.8 = 320
            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 1 本
            //And 第四集買了 1 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 320 元
            //arrange
            var target = new Cart();
            List<Product> products = new List<Product>
            {
                new Product { Name="哈利波特第一集", Price=100},
                new Product { Name="哈利波特第二集", Price=100},
                new Product { Name="哈利波特第三集", Price=100},
                new Product { Name="哈利波特第四集", Price=100},
            };
            //act
            var actual = target.CalculatePrice(products);
            //assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CalculatePriceTest_一次買了整套_一二三四五集各買了一本_價格應為_375()
        {
            //Scenario: 一次買了整套，一二三四五集各買了一本，價格應為100 * 5 * 0.75 = 375
            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 1 本
            //And 第四集買了 1 本
            //And 第五集買了 1 本
            //When 結帳
            //Then 價格應為 375 元
            //arrange
            var target = new Cart();
            List<Product> products = new List<Product>
            {
                new Product { Name="哈利波特第一集", Price=100},
                new Product { Name="哈利波特第二集", Price=100},
                new Product { Name="哈利波特第三集", Price=100},
                new Product { Name="哈利波特第四集", Price=100},
                new Product { Name="哈利波特第五集", Price=100},
            };
            //act
            var actual = target.CalculatePrice(products);
            //assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }
    }
}
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
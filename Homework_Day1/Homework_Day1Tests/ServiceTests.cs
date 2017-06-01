using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace Homework_Day1.Tests
{
    [TestClass()]
    public class SplitSumServiceTests
    {
        [TestMethod()]
        public void Sample1_3筆一組取Cost總和()
        {
            var productList = new ProductList().GetProductList();
            string name = "Cost";
            int groupCount = 3;

            var expected = new List<int>() { 6, 15, 24, 21 };

            var actual = new SplitSumService().GetSplitSum(productList, name, groupCount);
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void Sample2_4筆一組取Revenue總和()
        {
            var productList = new ProductList().GetProductList();
            string name = "Revenue";
            int groupCount = 4;

            var expected = new List<int>() { 50, 66, 60 };

            var actual = new SplitSumService().GetSplitSum(productList, name, groupCount);
            CollectionAssert.AreEqual(expected, actual);
        }
        
    }

    public class ProductList
    {
        private static List<Product> context;

        public ProductList()
        {
            context = new List<Product>() { new Product(1, 1, 11, 21),
                                            new Product(2, 2, 12, 22),
                                            new Product(3, 3, 13, 23),
                                            new Product(4, 4, 14, 24),
                                            new Product(5, 5, 15, 25),
                                            new Product(6, 6, 16, 26),
                                            new Product(7, 7, 17, 27),
                                            new Product(8, 8, 18, 28),
                                            new Product(9, 9, 19, 29),
                                            new Product(10, 10, 20, 30),
                                            new Product(11, 11, 21, 31)};
        }

        public List<Product> GetProductList()
        {
            return context;
        }
    }


}
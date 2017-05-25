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
    public class ServiceTests
    {
        [TestMethod()]
        public void Sample1_3筆一組取Cost總和()
        {
            var productManager = Substitute.For<IProductManager>();
            string name = "Cost";
            productManager.GetListByName(name).Returns(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            var expected = "6,15,24,21";

            var target = new Service(productManager);

            var actual = target.getSplitSum(name, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sample2_4筆一組取Revenue總和()
        {
            var productManager = Substitute.For<IProductManager>();
            string name = "Revenue";
            productManager.GetListByName(name).Returns(new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });
            var expected = "50,66,60";

            var target = new Service(productManager);

            var actual = target.getSplitSum(name, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
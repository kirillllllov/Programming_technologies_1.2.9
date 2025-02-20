using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CompareTest()
        {
            int[] numbers = { 1, 2, 4, 5, 78, 99 };
            var result = Logic.Search(numbers);
            string output1 = $"Два наибольших элемента: {result.max1} {result.max2}";
            string output2 = $"Два наименьших элемента: {result.min1} {result.min2}";
            Assert.AreEqual(output1, "Два наибольших элемента: 99 78");
            Assert.AreEqual(output2, "Два наименьших элемента: 1 2");
        }
        public void CompareTest2()
        {
            int[] numbers = { 13, 2, 4, 5, 99, 99 };
            var result = Logic.Search(numbers);
            string output1 = $"Два наибольших элемента: {result.max1} {result.max2}";
            string output2 = $"Два наименьших элемента: {result.min1} {result.min2}";
            Assert.AreEqual(output1, "Два наибольших элемента: 99 99");
            Assert.AreEqual(output2, "Два наименьших элемента: 2 4");
        }
    }
}
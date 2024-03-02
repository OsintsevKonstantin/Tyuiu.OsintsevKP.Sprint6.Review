using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint6.Review.V27.Lib;

namespace Tyuiu.OsintsevKP.Sprint6.Review
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            
            int[,] matrix ={ { 1, 2, 3 }, { 4,5,6 },{ 7,8,9 }};
            DataService ds = new DataService;

        }
    }
}

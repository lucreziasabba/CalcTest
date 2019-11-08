using CalcLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary_Tests
{
    [TestClass]
    public class Calc_Test
    {
        [TestMethod]
        public void PositiveSum()
        {
            int num_1 = 3;
            int num_2 = 4;
            int somma_aspettata = 7;
            int somma = CalcLibrary.Calc.Somma(num_1, num_2);
            Assert.AreEqual(somma_aspettata, somma);
        }
        [TestMethod]
        public void PositiveDivision()
        {
            int num_1 = 3;
            int num_2 = 4;
            int divisione_aspettata = 0;
            double divisione = CalcLibrary.Calc.Divisione(num_1, num_2);
            Assert.AreEqual(divisione_aspettata, divisione);
        }
        [TestMethod]
        public void NegativeSum()
        {
            int num_1 = -3;
            int num_2 = -5;
            int somma_aspettata = -8;
            int somma = CalcLibrary.Calc.Somma(num_1, num_2);
            Assert.AreEqual(somma_aspettata, somma);
        }
        [TestMethod]
        public void NegativeDivision()
        {
            int num_1 = -3;
            int num_2 = -5;
            int divisione_aspettata = 0;
            int divisione = CalcLibrary.Calc.Divisione(num_1, num_2);
            Assert.AreEqual(divisione_aspettata, divisione);
        }
    }
}

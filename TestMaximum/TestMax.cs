using GenericsPrograms.FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenGenericsIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum<int> max = new FindMaximum<int>(1, 2, 3);
            int actual = max.FindMax();
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenGenericsfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum<double> max = new FindMaximum<double>(3.4, 5.6, 7.8);
            double actual = max.FindMax();
            Assert.AreEqual(actual, 7.8);
        }
        [Test]
        public void GivenGenericsstringInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum<string> max = new FindMaximum<string>("Graps", "Peach", "Kiwi");
            string actual = max.FindMax();
            Assert.AreEqual(actual, "Peach");
        }
    }
}
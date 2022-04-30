using GenericsPrograms.FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInt(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenMaxNumInPositionOne_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInt(3, 1, 2);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenMaxNumInPositionTwo_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInt(1, 3, 2);
            Assert.AreEqual(actual, 3);
        }
    }
}
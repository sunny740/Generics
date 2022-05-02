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
            int actual = max.FindMaxInteger(1, 2, 3);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenMaxNumIntPositionOne_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(3, 1, 2);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenMaxNumIntPositionTwo_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            int actual = max.FindMaxInteger(1, 3, 2);
            Assert.AreEqual(actual, 3);
        }
        [Test]
        public void GivenFloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(1.2f, 3.6f, 6.7f);
            Assert.AreEqual(actual, 6.7f);
        }
        [Test]
        public void GivenMaxNumfloatPositionOne_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(6.7f, 1.2f, 3.6f);
            Assert.AreEqual(actual, 6.7f);
        }
        [Test]
        public void GivenMaxNumfloatPositionTwo_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(1.2f, 6.7f, 3.6f);
            Assert.AreEqual(actual, 6.7f);
        }
        [Test]
        public void GivenStringInput_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Apple", "Peach", "Banana");
            Assert.AreEqual(actual, "Banana");
        }
        [Test]
        public void GivenMaxStringPositionOne_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Banana", "Apple", "Peach");
            Assert.AreEqual(actual, "Banana");
        }
        [Test]
        public void GivenMaxStringPositionTwo_WhenTestMax_ShouldReturnMaximum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Apple", "Banana", "Peach");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
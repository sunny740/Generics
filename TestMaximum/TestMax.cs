using GenericsPrograms.FindMaximum;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenGenericsIntInput_WhenTestMax_ShouldReturnMaximum()
        {
            int[] arr = { 125, 330, 450, 560, 680 };
            FindMaximum<int> max = new FindMaximum<int>(arr);
            int actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 680);
        }
        [Test]
        public void GivenGenericsfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            float[] arr = { 3.5f, 7.8f, 5.5f, 4.5f, 7.5f };
            FindMaximum<float> max = new FindMaximum<float>(arr);
            float actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, 7.5f);
        }
        [Test]
        public void GivenGenericsstringInput_WhenTestMax_ShouldReturnMaximum()
        {
            string[] arr = { "Apple", "SweetPatato", "Kiwi", "Greaps", "Papaya" };
            FindMaximum<string> max = new FindMaximum<string>(arr);
            string actual = max.PrintMaxMethod();
            Assert.AreEqual(actual, "SweetPatato");
        }
    }
}
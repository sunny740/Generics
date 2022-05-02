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
            int actual = max.MaxMethod();
            Assert.AreEqual(actual, 680);
        }
        [Test]
        public void GivenGenericsfloatInput_WhenTestMax_ShouldReturnMaximum()
        {
            float[] arr = { 2.3f, 5.7f, 5.9f, 4.5f, 7.5f };
            FindMaximum<float> max = new FindMaximum<float>(arr);
            float actual = max.MaxMethod();
            Assert.AreEqual(actual, 7.5f);
        }
        [Test]
        public void GivenGenericsstringInput_WhenTestMax_ShouldReturnMaximum()
        {
            string[] arr = { "Apple", "SweetPatato", "Kiwi", "Greaps", "Papaya" };
            FindMaximum<string> max = new FindMaximum<string>(arr);
            string actual = max.MaxMethod();
            Assert.AreEqual(actual, "SweetPatato");
        }
    }
}
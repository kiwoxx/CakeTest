using Cake;
using NUnit.Framework;

namespace CakeTest
{
    public class Class1Test
    {
        [Test]
        public void testAdd()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual(3, class1.add(1, 2));
        }
    }
}

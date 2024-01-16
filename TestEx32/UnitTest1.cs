using System.ComponentModel.DataAnnotations;
using Super4;
namespace Ex32Test
{
    [TestClass]
    public class Ex32Test
    {
        [TestMethod]
        public void RangeCheckTest()
        {
            int num = 12, max = 15, min = 2;
            bool expected = true;
            Assert.AreEqual(expected, Ex32.RangeCheck(num, max, min));
        }
        [TestMethod]
        public void NameCheckTest()
        {
            string name = "Juanjo";
            char[] specialChars = { '!', '"', '·', '$', '%', '&', '/', '(', ')', '=', '*', '+', '¡', '?', '¿', '<', '>', '{', '}', '[', ']' };
            bool expected = false;
            Assert.AreEqual(expected, Ex32.NameCheck(name));
        }
        [TestMethod]
        public void NameVowelCheckTest()
        {
            string name = "Juanjo";
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'À', 'É', 'È', 'Í', 'Ó', 'Ò', 'Ú' };
        }
        [TestMethod]
        public void ResidualEvilnessTest()
        {
            int evilness = 10000, percentage = 1;
            int expected = 10000 * percentage % 4;
            Assert.AreEqual(expected, Ex32.ResidualEvilness(evilness, percentage));
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValueObject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestStruct()
        {
            var first = new Adresse(37, @"Rue Danton", @"", @"79120", @"VILLE");
            var second = new Adresse(37, @"Rue Danton", @"", @"79120", @"VILLE");

            Assert.AreNotSame(first, second);
            Assert.AreEqual(first, second);
            Assert.IsTrue(first.Equals(second));
        }

        [TestMethod]
        public void TestStructWithValidationSucceeds()
        {
            var first = new Adresse(37, @"Rue Danton", @"", @"79120", @"VILLE");
        }

        [TestMethod]
        public void TestStructWithValidationFails()
        {
            try
            {
                var first = new Adresse(-37, @"Rue Danton", @"", @"79120", @"VILLE");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof (ArgumentException));
                return;
            }

            Assert.Fail(@"La validation ne fonctionne pas !!");
        }
    }
}
using Validator;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        ValidatorHesel validator = new ValidatorHesel();

        [TestMethod]
        public void MaViceNezPet()
        {
            Assert.AreEqual(true, validator.SpravneHeslo("wdok55wdwd"));
        }

        [TestMethod]
        public void JePrazdne()
        {
            Assert.AreEqual(false, validator.SpravneHeslo(""));
        }

        [TestMethod]
        public void MaCislo()
        {
            Assert.AreEqual(false, validator.SpravneHeslo("hawdhhjawdh"));
        }
    }
}
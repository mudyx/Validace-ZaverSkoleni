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
            Assert.AreEqual(true, validator.SpravneHeslo("heslo123"));
        }

        [TestMethod]
        public void JePrazdne()
        {
            Assert.AreEqual(false, validator.SpravneHeslo(""));
        }

        [TestMethod]
        public void MaCislo()
        {
            Assert.AreEqual(false, validator.SpravneHeslo("heslo"));
        }

        [TestMethod]
        public void MaMeneNezPet()
        {
            Assert.AreEqual(false, validator.SpravneHeslo("hesl"));
        }

        [TestMethod]
        public void MaPrazdneZnaky()
        {
            Assert.AreEqual(false, validator.SpravneHeslo(" "));
        }
    }
}
using Hydac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HydacTest
{
    [TestClass]
    public class BesøgTest
    {
        [TestMethod]
        public void Constructor_GyldigeOplysninger_GemmerDemPåBesøget()
        {
            // Arrange
            DateTime ankomst = new DateTime(2026, 9, 30, 12, 0, 0);
            DateTime afgang = new DateTime(2026, 9, 30, 16, 0, 0);

            // Act
            Besøg besøg = new Besøg("Søren Mortensen", "Bilka", "Lars Hansen", ankomst, afgang,
                ankomst.Date, null, null, "X01", 81507192, "Ikke Tjekket Ind", false);

            // Assert
            Assert.AreEqual("Søren Mortensen", besøg.Navn);
            Assert.AreEqual(ankomst, besøg.ForventetAnkomst);
            Assert.AreEqual(afgang, besøg.ForventetAfgang);
            Assert.AreEqual("Ikke Tjekket Ind", besøg.Status);
        }
    }
}

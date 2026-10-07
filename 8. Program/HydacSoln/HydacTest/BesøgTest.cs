<<<<<<< HEAD
<<<<<<< HEAD
﻿using Hydac;
=======
using Hydac;
>>>>>>> d0c158597ab168f24ce868f354b8876fd62e41d2
=======
﻿using Hydac;
>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HydacTest
{
    [TestClass]
    public class BesøgTest
    {
<<<<<<< HEAD
<<<<<<< HEAD
        [TestMethod]
        public void Constructor_GyldigeOplysninger_GemmerDemPåBesøget()
        {
            // Arrange
            DateTime forventetAnkomsttid = new DateTime(2026, 9, 30, 12, 0, 0);
            DateTime forventetAfgangstid = new DateTime(2026, 9, 30, 16, 0, 0);

            // Act
            Besøg besøg = new Besøg("Søren Mortensen", "Bilka", "Lars Hansen", forventetAnkomsttid, forventetAfgangstid,
                forventetAnkomsttid.Date, null, null, "X01", 81507192, "Ikke Tjekket Ind", false);

            // Assert
            Assert.AreEqual("Søren Mortensen", besøg.GæstNavn);
            Assert.AreEqual(forventetAnkomsttid, besøg.ForventetAnkomsttid);
            Assert.AreEqual(forventetAfgangstid, besøg.ForventetAfgangstid);
            Assert.AreEqual("Ikke Tjekket Ind", besøg.Status);
=======
        // Testdata fra objektmodellen (b1, g1 og m1). Datoen er i morgen,
        // fordi et besøg ikke må oprettes med en dato før i dag.
        private static readonly DateTime dato = DateTime.Today.AddDays(1);
        private static readonly DateTime forventetAnkomsttid = dato.AddHours(12);
        private static readonly DateTime forventetAfgangstid = dato.AddHours(16);
        private static readonly Medarbejder ansvarlig = new Medarbejder("Lars Hansen", "LH1234");

        private static Besøg OpretBesøg()
        {
            return new Besøg("Søren Mortensen", "Bilka", ansvarlig, dato,
                forventetAnkomsttid, forventetAfgangstid, "X01", 81507192);
        }

=======
>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
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
<<<<<<< HEAD
            Assert.AreEqual(Besøg.TjekketInd, besøg.Status);
            Assert.IsNotNull(besøg.Indtjekningstid);
            Assert.IsTrue(besøg.SikkerhedsfolderModtaget);
        }

        [TestMethod]
        public void TjekInd_AlleredeTjekketInd_KasterInvalidOperationException()
        {
            Besøg besøg = OpretBesøg();
            besøg.TjekInd(true);

            Assert.ThrowsExactly<InvalidOperationException>(() => besøg.TjekInd(true));
        }

        [TestMethod]
        public void TjekUd_TjekketInd_SætterStatusOgTid()
        {
            // Arrange
            Besøg besøg = OpretBesøg();
            besøg.TjekInd(true);

            // Act
            besøg.TjekUd();

            // Assert
            Assert.AreEqual(Besøg.TjekketUd, besøg.Status);
            Assert.IsNotNull(besøg.Udtjekningstid);
        }

        [TestMethod]
        public void TjekUd_IkkeTjekketInd_KasterInvalidOperationException()
        {
            Besøg besøg = OpretBesøg();

            Assert.ThrowsExactly<InvalidOperationException>(() => besøg.TjekUd());
>>>>>>> d0c158597ab168f24ce868f354b8876fd62e41d2
=======
            Assert.AreEqual("Søren Mortensen", besøg.Navn);
            Assert.AreEqual(ankomst, besøg.ForventetAnkomst);
            Assert.AreEqual(afgang, besøg.ForventetAfgang);
            Assert.AreEqual("Ikke Tjekket Ind", besøg.Status);
>>>>>>> 559636fa843e8fe17f11e68a6d600d99eb881844
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gildia.Tests
{
    [TestClass]
    public class RycerzTests
    {
        [TestMethod]
        public void KonstruktorTest()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Assert.IsNotNull(r, "Test konstruktora");
        }

        [TestMethod]
        public void CzyJestNaWyprawie_Rycerz_Nie_Jest_Na_Wyprawie_PowinnoWyjsc_False()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");

            Assert.IsFalse(r.CzyjestNaWyprawie);
        }

        [TestMethod]
        public void CzyJestNaWyprawie_Rycerz_Jest_Na_WyprawiePowinnoWyjsc_True()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Gildia g = new Gildia();
            Zadanie z = new Zadanie("dfdf", 500);

            g.DodanieNowegoZadaniaDoListy(z);
            g.ZapisanieRycerzaDoGildii(r);
            g.PrzypiszZadanieRycerzowi(r, z);
            r.WyslijNaZadanie();

            Assert.IsTrue(r.CzyjestNaWyprawie);
        }


        [TestMethod]
        public void WyslijNaZadanie_BezPrzypisaniaZadania_Powinno_Wyjsc_False()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Assert.IsFalse(r.WyslijNaZadanie());
        }

        [TestMethod]
        public void WyslijNaZadanie_PrzypisanoZadanie_Powinno_Wyjsc_True()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Gildia g = new Gildia();
            Zadanie z = new Zadanie("dfdf", 500);
            g.DodanieNowegoZadaniaDoListy(z);
            g.ZapisanieRycerzaDoGildii(r);
            g.PrzypiszZadanieRycerzowi(r, z);
            Assert.IsTrue(r.WyslijNaZadanie());
        }

        [TestMethod]
        public void WyslijNaZadanie_Rycerz_Jest_Juz_Na_Innej_Wyprawie_Powinno_Wyjsc_False()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Gildia g = new Gildia();
            Zadanie z = new Zadanie("dfdf", 500);
            g.DodanieNowegoZadaniaDoListy(z);
            g.ZapisanieRycerzaDoGildii(r);
            g.PrzypiszZadanieRycerzowi(r, z);
            r.WyslijNaZadanie();
            Assert.IsFalse(r.WyslijNaZadanie());
        }

        [TestMethod]
        public void SkonczZadanie_Rycerz_Jest_Na_Wyprawie_Powinno_Wyjsc_True()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Gildia g = new Gildia();
            Zadanie z = new Zadanie("dfdf", 500);
            g.DodanieNowegoZadaniaDoListy(z);
            g.ZapisanieRycerzaDoGildii(r);
            g.PrzypiszZadanieRycerzowi(r, z);
            r.WyslijNaZadanie();
            Assert.IsTrue(r.SkonczZadanie());
        }

        [TestMethod]
        public void SkonczZadanie_Rycerz_Nie_Jest_Na_Wyprawie_Powinno_Wyjsc_False()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Assert.IsFalse(r.SkonczZadanie());
        }

        [TestMethod]
        public void PrzelejGoldInnemuRycerzowi_Rycerz_Ma_Wystarczajaco_Pieniedzy_Powinno_Wyjsc_MniejGolda()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Rycerz r2 = new Rycerz("dfds", "dsfds");
            r.Gold += 300;
            Assert.AreEqual(150, r.PrzelejGoldInnemuRycerzowi(r2, 150));

        }
        [TestMethod]
        public void PrzelejGoldInnemuRycerzowi_Rycerz_Nie_Ma_Wystarczajaco_Pieniedzy_Nie_Powinno_ubyc_Golda_Rycerzowi()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Rycerz r2 = new Rycerz("dfds", "dsfds");
            r.Gold += 300;
            Assert.AreEqual(300, r.PrzelejGoldInnemuRycerzowi(r2, 350));

        }
        [TestMethod]
        public void KupPrzedmiot_Rycerz_Ma_Wystarczajaco_Pieniedzy_Powinno_ubyc_Golda_Rycerzowi()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            r.Gold += 300;
            r.KupPrzedmiot();
            Assert.AreEqual(100, r.Gold);

        }
        [TestMethod]
        public void KupPrzedmiot_Rycerz_Nie_Ma_Wystarczajaco_Pieniedzy_Powinno_Wyrzucic_Wyjatek()
        {
            Rycerz r = new Rycerz("asdas", "dsfsdf");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => r.KupPrzedmiot());

        }
    }
}

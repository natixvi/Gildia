using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gildia.Tests
{
    [TestClass]
    public class GildiaTests
    {
        [TestMethod]
        public void KonstruktorTest()
        {
            Gildia g = new Gildia();
            Assert.IsNotNull(g, "Test konstruktora");
        }
        [TestMethod]
        public void DodanieNowegoZadaniaDoListy_Powinno_Zwrocic_Liste_Zadan_o_Wielkosci_Wiekszej_Niz_0()
        {
            Gildia g = new Gildia();
            Zadanie z = new Zadanie("dfsf", 890);
            Assert.AreEqual(1, g.DodanieNowegoZadaniaDoListy(z).Count);
        }
       
        [TestMethod]
        public void DodanieNowegoRycerzaDoListy_Powinno_Zwrocic_Liste_Rycerzy_o_Wielkosci_Wiekszej_Niz_0()
        {
            Gildia g = new Gildia();
            Rycerz r = new Rycerz("dfsf", "dfsadf");
            Assert.AreEqual(1, g.ZapisanieRycerzaDoGildii(r).Count);
        }

        [TestMethod]
        public void PrzypiszZadanieRycerzowi_Powinno_Zwrocic_True()
        {
            Gildia g = new Gildia();
            Rycerz r = new Rycerz("dfsf", "dfsadf");
            Zadanie z = new Zadanie("dsfsdf", 434);
            g.ZapisanieRycerzaDoGildii(r);
            g.DodanieNowegoZadaniaDoListy(z);
            Assert.IsTrue(g.PrzypiszZadanieRycerzowi(r, z));
        }

        [TestMethod]
        public void PrzypiszZadanieRycerzowi_Rycerz_Nie_Jest_Zapisany_Do_Gildii_Powinno_Zwrocic_False()
        {
            Gildia g = new Gildia();
            Rycerz r = new Rycerz("dfsf", "dfsadf");
            Zadanie z = new Zadanie("dsfsdf", 434);
            g.DodanieNowegoZadaniaDoListy(z);
            Assert.IsFalse(g.PrzypiszZadanieRycerzowi(r, z));
        }
        [TestMethod]
        public void PrzypiszZadanieRycerzowi_Zadanie_Nie_Jest_Zapisany_W_Gildii_Powinno_Zwrocic_False()
        {
            Gildia g = new Gildia();
            Rycerz r = new Rycerz("dfsf", "dfsadf");
            Zadanie z = new Zadanie("dsfsdf", 434);
            g.ZapisanieRycerzaDoGildii(r);
            Assert.IsFalse(g.PrzypiszZadanieRycerzowi(r, z));
        }

        [TestMethod]
        public void PrzypiszZadanieRycerzowi_Rycerz_Nie_Jest_Zapisany_Do_Gildii_I_Zadanie_Nie_Jest_Zapisane_W_Gildii_Powinno_Zwrocic_False()
        {
            Gildia g = new Gildia();
            Rycerz r = new Rycerz("dfsf", "dfsadf");
            Zadanie z = new Zadanie("dsfsdf", 434);
            Assert.IsFalse(g.PrzypiszZadanieRycerzowi(r, z));
        }

        [TestMethod]
        public void PrzypiszZadanieRycerzowi_Rycerz_Jest_Juz_Na_Wyprawie_Powinno_Zwrocic_False()
        {
            Gildia g = new Gildia();
            Rycerz r = new Rycerz("dfsf", "dfsadf");
            Zadanie z = new Zadanie("dsfsdf", 434);
            Zadanie z2 = new Zadanie("DSDS", 453);
            g.ZapisanieRycerzaDoGildii(r);
            g.DodanieNowegoZadaniaDoListy(z);
            g.DodanieNowegoZadaniaDoListy(z2);
            g.PrzypiszZadanieRycerzowi(r, z);
            r.WyslijNaZadanie();
            Assert.IsFalse(g.PrzypiszZadanieRycerzowi(r, z2));
        }

    }
}

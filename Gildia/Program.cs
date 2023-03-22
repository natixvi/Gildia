namespace Gildia
{
   class Program
    {
        static void Main(string[] args)
        {
            Gildia gildia = new Gildia();
            Zadanie z1 = new Zadanie("Zabicie smoka w lesie 1", 1200);
            Zadanie z2 = new Zadanie("Zabicie ogra w kamieniolomie", 500);
            gildia.DodanieNowegoZadaniaDoListy(z1);
            gildia.DodanieNowegoZadaniaDoListy(z2);
            gildia.WyswietlListeRycerzy();

            Rycerz r1 = new Rycerz("Vincent Van", "Gogh");
            Rycerz r2 = new Rycerz("Ains Oal", "Goal");

            gildia.ZapisanieRycerzaDoGildii(r1);
            gildia.ZapisanieRycerzaDoGildii(r2);

            gildia.WyswietlListeZadan();
            gildia.WyswietlListeRycerzy();

            r1.WyslijNaZadanie();

            gildia.PrzypiszZadanieRycerzowi(r1, z2);

            r1.WyslijNaZadanie();

            gildia.PrzypiszZadanieRycerzowi(r1, z1);

            r1.SkonczZadanie();
            gildia.PrzypiszZadanieRycerzowi(r1, z1);

            Rycerz r3 = new Rycerz("ersdf", "dfsaf");

            try
            {
                r3.KupPrzedmiot();
            }
            catch (ArgumentOutOfRangeException e) { 
                Console.WriteLine(e.Message);
            }
            
            gildia.ZapisanieRycerzaDoGildii(r3);

        }
    }
}
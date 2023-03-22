using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Gildia
{
    public class Gildia
    {
        private HashSet<Rycerz> listaRycerzy;
        private HashSet<Zadanie> listaDostepnychZadan;

        public Gildia()
        {
            listaRycerzy = new HashSet<Rycerz>();
            listaDostepnychZadan = new HashSet<Zadanie>();
        }

        public HashSet<Zadanie> DodanieNowegoZadaniaDoListy(Zadanie zadanie) {
            listaDostepnychZadan.Add(zadanie);
            return listaDostepnychZadan;
        }
        public HashSet<Rycerz> ZapisanieRycerzaDoGildii(Rycerz rycerz) {
            listaRycerzy.Add(rycerz);
            return listaRycerzy;
        }

        public void WyswietlListeRycerzy()
        {
            foreach(Rycerz x in listaRycerzy)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public void WyswietlListeZadan()
        {
            foreach (Zadanie x in listaDostepnychZadan)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public Boolean PrzypiszZadanieRycerzowi(Rycerz rycerz, Zadanie zadanie) {

            if (listaRycerzy.Contains(rycerz) && listaDostepnychZadan.Contains(zadanie) && !rycerz.CzyjestNaWyprawie)
            {
                    rycerz.Zadanie = zadanie;
                    listaDostepnychZadan.Remove(zadanie);
                    Console.WriteLine("Przpisano zadanie rycerzowi. Brawo!\n");
                    return true;
                
            }
            Console.WriteLine("Nie udalo sie przpisac zadania rycerzowi!\n");
            return false;

        }
    }
}

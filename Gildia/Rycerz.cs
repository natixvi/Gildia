using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gildia
{
    public class Rycerz
    {
        private string imie;
        private string nazwisko;
        private Zadanie zadanie;
        private Boolean czyjestNaWyprawie;
        private int gold;

        public Rycerz(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            czyjestNaWyprawie = false;
            gold = 0;
            zadanie = null;
        }

        public string Imie
        {
            get { return this.imie; }
            set { this.imie = value; }
        }

        public string Nazwisko
        {
            get { return this.nazwisko; }   
            set { this.nazwisko = value; }
        }

        public Zadanie Zadanie
        {
            get { return this.zadanie; }
            set { this.zadanie = value; }
        }

        public int Gold
        {
            get { return this.gold; }
            set { this.gold = value; }
        }

        public Boolean CzyjestNaWyprawie
        {
            get { return this.czyjestNaWyprawie; }  
            set { czyjestNaWyprawie = value; }
        }

 
        public Boolean WyslijNaZadanie() {
            if (zadanie != null && !czyjestNaWyprawie)
            {
                Console.WriteLine("Brawo " + this.imie + " " + this.nazwisko + " wyruszyles wykonac zadanie! Powodzenia!");
                czyjestNaWyprawie = true;
                return true;
            }
            else{

                Console.WriteLine("Aktulanie nie mozesz isc na wyprawe");
                return false;
            }
         
        }

        public Boolean SkonczZadanie()
        {
            if (czyjestNaWyprawie == true)
            {
                Console.WriteLine("Brawo " + this.imie + " " + this.nazwisko + " skonczyles zadanie! Oto twoja nagroda: " + zadanie.Nagroda +"\n");
                this.Gold += zadanie.Nagroda;
                this.zadanie = null;
                czyjestNaWyprawie = false;
                return true;
            }   
            else
            {
                Console.WriteLine(this.imie + " " + this.nazwisko + " nie jestes aktualnie na zadnej wyprawie!\n");
                return false;
            }
        }

        public int PrzelejGoldInnemuRycerzowi(Rycerz rycerz, int kwota)
        {
            if (kwota > this.gold)
            {
                Console.WriteLine("Masz za mało pieniedzy zeby przelac taka kwote!\n");
            }
            else
            {
                rycerz.gold += kwota;
                this.gold -= kwota;
                Console.WriteLine("Kwota zostala przelana rycerzowi: " + rycerz.Imie + "  " + rycerz.Nazwisko + ". Zostalo ci: " + this.gold + " Golda.\n");
            }
            return this.gold;
        }

        public void KupPrzedmiot()
        {
            if (this.gold < 200) {
                throw new ArgumentOutOfRangeException();
            }            
            this.gold -= 200;
            Console.WriteLine("Kupiles przedmiot! Zostalo ci: " + this.gold + " Golda.\n");
                           
        }
        public override string ToString()
        {
            return "Rycerz: " + this.imie + " " + this.nazwisko;
        }
    }
}

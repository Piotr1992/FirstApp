using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FirstApp
{
    [Serializable]
    public class KartotekaTowarowa
    {
        public int Id;

        public int Typ;

        public string Nazwa;

        public string Kod;

        public int Ilosc;

        public int Magazyn;

        public List<Cena> Ceny { get; set; }
        
        public KartotekaTowarowa()
        {
            Ceny = new List<Cena>();
        }

        //      Metoda dodająca ceny do XML
        public void dodajCeny(Cena cena) 
        {
            Ceny.Add(cena);
        }

        //      Średnia cen z odrzuceniem wartości skrajnych  ->  np. 5, 8, 10, 17, 11 czyli 5 i 17 nie są brane do wyliczenia średniej
        public decimal sredniaCen(List<Cena> Ceny)
        {
            decimal wyliczonaSredniaCen = 0;
            List<Decimal> listaCen = new List<Decimal>();
            List<Decimal> posortowanaListaCen = new List<Decimal>();            

            foreach (Cena cena in Ceny) 
            {                
                listaCen.Add(cena.Netto);
            }

            GFG gg = new GFG();

            listaCen.Sort(gg);

            listaCen.RemoveAt(0);
            listaCen.RemoveAt(listaCen.Count-1);

            foreach (Decimal cena in listaCen)
            {
                wyliczonaSredniaCen += cena;
            }

            wyliczonaSredniaCen = wyliczonaSredniaCen / listaCen.Count;

            return wyliczonaSredniaCen;
        }

        //      Pomocnicza klasa do posortowania liczb w zbiorze liczb
        class GFG : IComparer<Decimal>
        {
            public int Compare(decimal x, decimal y)
            {
                if (x == 0 || y == 0)
                {
                    return 0;
                }

                return x.CompareTo(y);

            }
        }        

    }
}

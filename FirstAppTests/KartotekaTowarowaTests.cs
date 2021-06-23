using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp.Tests
{
    //  Testy jednostkowe
    [TestClass()]
    public class KartotekaTowarowaTests
    {
        [TestMethod()]
        public void iloscCenTest()
        {
            KartotekaTowarowa towar1 = new KartotekaTowarowa();

            towar1.Id = 12345;
            towar1.Typ = 4;
            towar1.Nazwa = "Rower";
            towar1.Kod = "ABCDEFGHIJK";
            towar1.Ilosc = 95;
            towar1.Magazyn = 2;

            Cena cena1 = new Cena();
            cena1.Nazwa = "Hurtowa";
            cena1.Netto = new decimal(11.11);
            cena1.VAT = new decimal(29);
            cena1.Waluta = "EUR";

            Cena cena2 = new Cena();
            cena2.Nazwa = "Detaliczna";
            cena2.Netto = new decimal(33.33);
            cena2.VAT = new decimal(31);
            cena2.Waluta = "USD";

            Cena cena3 = new Cena();
            cena3.Nazwa = "Hurtowa";
            cena3.Netto = new decimal(55.55);
            cena3.VAT = new decimal(29);
            cena3.Waluta = "EUR";

            Cena cena4 = new Cena();
            cena4.Nazwa = "Detaliczna";
            cena4.Netto = new decimal(77.77);
            cena4.VAT = new decimal(31);
            cena4.Waluta = "USD";

            Cena cena5 = new Cena();
            cena5.Nazwa = "Hurtowa";
            cena5.Netto = new decimal(99.99);
            cena5.VAT = new decimal(29);
            cena5.Waluta = "EUR";

            towar1.dodajCeny(cena5);
            towar1.dodajCeny(cena4);
            towar1.dodajCeny(cena3);
            towar1.dodajCeny(cena2);
            towar1.dodajCeny(cena1);

            Assert.IsTrue(towar1.Ceny.Count == 5);
        }

        [TestMethod()]
        public void sredniaCenTest()
        {
            KartotekaTowarowa towar1 = new KartotekaTowarowa();

            towar1.Id = 12345;
            towar1.Typ = 4;
            towar1.Nazwa = "Rower";
            towar1.Kod = "ABCDEFGHIJK";
            towar1.Ilosc = 95;
            towar1.Magazyn = 2;

            Cena cena1 = new Cena();
            cena1.Nazwa = "Hurtowa";
            cena1.Netto = new decimal(11.11);
            cena1.VAT = new decimal(29);
            cena1.Waluta = "EUR";

            Cena cena2 = new Cena();
            cena2.Nazwa = "Detaliczna";
            cena2.Netto = new decimal(33.33);
            cena2.VAT = new decimal(31);
            cena2.Waluta = "USD";

            Cena cena3 = new Cena();
            cena3.Nazwa = "Hurtowa";
            cena3.Netto = new decimal(55.55);
            cena3.VAT = new decimal(29);
            cena3.Waluta = "EUR";

            Cena cena4 = new Cena();
            cena4.Nazwa = "Detaliczna";
            cena4.Netto = new decimal(77.77);
            cena4.VAT = new decimal(31);
            cena4.Waluta = "USD";

            Cena cena5 = new Cena();
            cena5.Nazwa = "Hurtowa";
            cena5.Netto = new decimal(99.99);
            cena5.VAT = new decimal(29);
            cena5.Waluta = "EUR";

            towar1.dodajCeny(cena5);
            towar1.dodajCeny(cena4);
            towar1.dodajCeny(cena3);
            towar1.dodajCeny(cena2);
            towar1.dodajCeny(cena1);

            Assert.AreEqual(decimal.ToDouble(towar1.sredniaCen(towar1.Ceny)), 55.55);
        }
    }

}

using System;
using System.Diagnostics;
using System.IO;

public class Automyynti_tiedosto //Julkisesti näkyvissä oleva luokka
{
    class UusiAudi //Luodaan luokka Uusille Audeille, jotka sisältävät ominaisuuksia
    {
        public string Hinta { get; set; } //get-metodi palauttaa ominaisuuden arvon, set-metodi asettaa ominaisuuden arvon
        public string Ajokilometrit { get; set; }
        public string Vuosimalli { get; set; }
        public string Henkilömäärä { get; set; }
        public string Käyttövoima { get; set; }

        public UusiAudi(string hinta, string ajokilometrit, string vuosimalli, string henkilömäärä, string käyttövoima)
            //Konstruktori, jolla on parametreja, kun olio luodaan
        {
            Hinta = hinta;
            Ajokilometrit = ajokilometrit;
            Vuosimalli = vuosimalli;
            Henkilömäärä = henkilömäärä;
            Käyttövoima = käyttövoima;
        }

        public override string ToString()
            //Metodi, jonka avulla ylikirjoitetaan olion merkkijonoesitys
            //ToString-metodi on ylikirjoitettu niin, että string-merkkijono  palautetaan
            //seuraavilla auton ominaisuuksilla
        {
            return $"Hinta: {Hinta}, Ajokilometrit: {Ajokilometrit}, " +
            $"Vuosimalli: {Vuosimalli}, Henkilömäärä: {Henkilömäärä}, Käyttövoima: {Käyttövoima}";
        }

    }

    class UusiDodge //Luodaan luokka Uusille Dodgeille, jotka sisältävät ominaisuuksia
    {
        public string Hinta { get; set; }
        public string Ajokilometrit { get; set; }
        public string Vuosimalli { get; set; }
        public string Henkilömäärä { get; set; }
        public string Käyttövoima { get; set; }

        public UusiDodge(string hinta, string ajokilometrit, string vuosimalli, string henkilömäärä, string käyttövoima)

        {
            Hinta = hinta;
            Ajokilometrit = ajokilometrit;
            Vuosimalli = vuosimalli;
            Henkilömäärä = henkilömäärä;
            Käyttövoima = käyttövoima;
        }
        public override string ToString()

        {
            return $"Hinta: {Hinta}, Ajokilometrit: {Ajokilometrit}, " +
            $"Vuosimalli: {Vuosimalli}, Henkilömäärä: {Henkilömäärä}, Käyttövoima: {Käyttövoima}";
        }

    }
    class KäytettyAudi //Luodaan luokka Käytetyille Audeille, jotka sisältävät ominaisuuksia
    {
        public string Hinta { get; set; }
        public string Ajokilometrit { get; set; }
        public string Vuosimalli { get; set; }
        public string Henkilömäärä { get; set; }
        public string Käyttövoima { get; set; }

        public KäytettyAudi(string hinta, string ajokilometrit, string vuosimalli, string henkilömäärä, string käyttövoima)

        {
            Hinta = hinta;
            Ajokilometrit = ajokilometrit;
            Vuosimalli = vuosimalli;
            Henkilömäärä = henkilömäärä;
            Käyttövoima = käyttövoima;
        }
        public override string ToString()

        {
            return $"Hinta: {Hinta}, Ajokilometrit: {Ajokilometrit}, " +
            $"Vuosimalli: {Vuosimalli}, Henkilömäärä: {Henkilömäärä}, Käyttövoima: {Käyttövoima}";
        }
    }

    class KäytettyDodge //Luodaan luokka Käytetyille Dodgeille, jotka sisältävät ominaisuuksia
    {
        public string Hinta { get; set; }
        public string Ajokilometrit { get; set; }
        public string Vuosimalli { get; set; }
        public string Henkilömäärä { get; set; }
        public string Käyttövoima { get; set; }

        public KäytettyDodge(string hinta, string ajokilometrit, string vuosimalli, string henkilömäärä, string käyttövoima)

        {
            Hinta = hinta;
            Ajokilometrit = ajokilometrit;
            Vuosimalli = vuosimalli;
            Henkilömäärä = henkilömäärä;
            Käyttövoima = käyttövoima;
        }
        public override string ToString()

        {
            return $"Hinta: {Hinta}, Ajokilometrit: {Ajokilometrit}, " +
            $"Vuosimalli: {Vuosimalli}, Henkilömäärä: {Henkilömäärä}, Käyttövoima: {Käyttövoima}";
        }
    }

    class Ohjelma //Luokka, jossa suoritetaan ohjelmaosuus
    {

        static void Valinnan_Tarkistus(string valinta) //Metodi, jossa tarkistetaan käyttäjän valintoja
        {

            if (valinta == "a")
            {
                Console.WriteLine();
                Console.WriteLine("Valitsit a:n.");
            }
            else if (valinta == "b")
            {
                Console.WriteLine();
                Console.WriteLine("Valitsit b:n.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Virheellinen valinta! Valitse joko 'a'- tai 'b'-kirjain!");
            }
        }

        static void Lomaketiedot() //Metodi, joka sisältää käyttäjän kirjoittamat tiedot auton
                                   //tilauksesta. Tiedot kirjoitetaan lopuksi tiedostoon, joka
                                   //toimii käyttäjän tilausvahvistuksena
        {
                StreamWriter tilausvahvistus = new StreamWriter("Autotilaus.txt", false);
                //Avataan tiedostoon kirjoitus ja määritetään tiedoston nimi

                Console.WriteLine("Tilausvahvistus");

                Console.WriteLine();
                Console.WriteLine("Koko nimi:");
                Console.WriteLine();
                string sKoko_Nimi = Console.ReadLine();
                tilausvahvistus.WriteLine($"Nimi: {sKoko_Nimi}");

                Console.WriteLine();
                Console.WriteLine("Osoite:");
                Console.WriteLine();
                string sOsoite = Console.ReadLine();
                tilausvahvistus.WriteLine($"Osoite: {sOsoite}");

                Console.WriteLine();
                Console.WriteLine("Puhelinnumero:");
                Console.WriteLine();
                string sPuhelinnumero = Console.ReadLine();
                tilausvahvistus.WriteLine($"Puhelinnumero: {sPuhelinnumero}");

                Console.WriteLine();
                Console.WriteLine("Sähköpostiosoite:");
                Console.WriteLine();
                string sSähköposti = Console.ReadLine();
                tilausvahvistus.WriteLine($"Sähköpostiosoite: {sSähköposti}");

                Console.WriteLine();
                Console.WriteLine("Lisätietoja / toiveita tilaukseen liittyen:");
                Console.WriteLine();
                string sLisätiedot = Console.ReadLine();
                tilausvahvistus.WriteLine($"Lisätiedot / toiveet: {sLisätiedot}");

                tilausvahvistus.Close();
                //Suljetaan tiedosto
        }

        static void Main() //Metodi, toimii ohjelman aloituskohtana (suoritetaan, kun ohjelma käynnistyy)
                           //void tarkoittaa, että main-metodi ei palauta mitään arvoa
            {
                List<UusiAudi> uusiaudiQ7_lista = new List<UusiAudi>();
                //Luodaan uusi lista uudelle Audi Q7:lle

                uusiaudiQ7_lista.Add(new UusiAudi("97.000e", "2000km", "2023", "7 hlö", "Hybridi (sähkö / bensiini)"));
                //Lisätään tiedot uuden, Audi Q7:n tietoihin, sama muille autoille

                List<UusiAudi> uusiaudiA8_lista = new List<UusiAudi>();

                uusiaudiA8_lista.Add(new UusiAudi("82.000e", "0km", "2024", "5 hlö", "Bensiini"));

                List<UusiDodge> uusidodgeviper_lista = new List<UusiDodge>();

                uusidodgeviper_lista.Add(new UusiDodge("120.000e", "3700km", "2024", "4 hlö", "Bensiini"));

                List<UusiDodge> uusidodgechallenger_lista = new List<UusiDodge>();

                uusidodgechallenger_lista.Add(new UusiDodge("78.500e", "1000km", "2022", "5 hlö", "Bensiini"));

                List<KäytettyAudi> käytettyaudia3_lista = new List<KäytettyAudi>();

                käytettyaudia3_lista.Add(new KäytettyAudi("16.800e", "280.000km", "2018", "5 hlö", "Diesel"));

                List<KäytettyAudi> käytettyaudia4_lista = new List<KäytettyAudi>();

                käytettyaudia4_lista.Add(new KäytettyAudi("14.900e", "180.000km", "2016", "5 hlö", "Diesel"));

                List<KäytettyDodge> käytettydodgepickup_lista = new List<KäytettyDodge>();

                käytettydodgepickup_lista.Add(new KäytettyDodge("9000e", "310.000km", "2010", "3 hlö", "Bensiini"));

                List<KäytettyDodge> käytettydodgecharger_lista = new List<KäytettyDodge>();

                käytettydodgecharger_lista.Add(new KäytettyDodge("19.900e", "156.000km", "2013", "5 hlö", "Bensiini"));

                try //Käytetään try-catch lohkoa tarkistamaan virheellistä syöttöä
                {
                    while (true) //While-loop, joka on voimassa niin kauan kun käyttäjä
                                 //on tehnyt valinnan autosta
                    {
                        Console.WriteLine("Tervetuloa autokauppaamme! Alla näet valikon, jossa voit selata uusia ja käytettyjä Audeja & Dodgeja!");
                        Console.WriteLine();
                        Console.WriteLine("Valitse painamalla a- tai b-kirjain:");
                        Console.WriteLine();

                        string syote1 = "";
                        while (syote1 != "a" && syote1 != "b")
                        {
                            Console.WriteLine("a. Uudet autot");
                            Console.WriteLine("b. Käytetyt autot");
                            Console.WriteLine();

                            syote1 = Console.ReadLine().ToLower(); // Varmistetaan, että käyttäjän syöte on pienellä kirjaimella

                            Valinnan_Tarkistus(syote1); //Metodi tarkistaa käyttäjän antaman syötteen

                            Console.WriteLine(); //Luodaan tyhjä rivi

                        }

                        if (syote1 == "a")
                        {
                            Console.WriteLine("--Uudet autot--");
                            Console.WriteLine();

                            string syote2 = "";
                            while (syote2 != "a" && syote2 != "b") //While loop, joka on voimassa
                            //niin kauan, kunnes käyttäjä antaa kirjaimen "a" tai "b". Ohjelma
                            //huomauttaa virheestä, jos kirjain on muu kuin "a" tai "b".
                            {

                                Console.WriteLine("Valitse automerkki kirjoittamalla a- tai b-kirjain:");
                                Console.WriteLine();
                                Console.WriteLine("a. Audi");
                                Console.WriteLine("b. Dodge");
                                Console.WriteLine();

                                syote2 = Console.ReadLine().ToLower();

                                Valinnan_Tarkistus(syote2);
                                Console.WriteLine();

                            }

                            if (syote2 == "a")
                            {
                                Console.WriteLine("--Uudet Audit--");
                                Console.WriteLine();

                                string syote3 = "";
                                while (syote3 != "a" && syote3 != "b")
                                {

                                    Console.WriteLine("Valitse uuden Audin malli kirjoittamalla a- tai b-kirjain:");
                                    Console.WriteLine();
                                    Console.WriteLine("a. Q7");
                                    Console.WriteLine("b. A8");
                                    Console.WriteLine();

                                    syote3 = Console.ReadLine().ToLower();

                                    Valinnan_Tarkistus(syote3);

                                    Console.WriteLine();

                                }

                                if (syote3 == "a")
                                {
                                    Console.WriteLine("--Q7--");
                                    Console.WriteLine();
                                    Console.WriteLine("Tässä uuden, Audi Q7:n tiedot:");
                                    foreach (UusiAudi uusiaudi in uusiaudiQ7_lista)
                                    //Foreach-loopilla käydään Uuden, Audi Q7:n lista läpi, joka
                                    //sisältää aiemmin määritellyt alkiot eli arvot
                                    {
                                        Console.WriteLine(uusiaudi);
                                    }
                                    break;
                                }
                                else if (syote3 == "b")
                                {
                                    Console.WriteLine("--A8--");
                                    Console.WriteLine();
                                    Console.WriteLine("Tässä uuden, Audi A8:n tiedot:");
                                    foreach (UusiAudi uusiAudi in uusiaudiA8_lista)
                                    {
                                        Console.WriteLine(uusiAudi);
                                    }
                                    break;
                                }
                            }
                            else if (syote2 == "b")
                            {
                                Console.WriteLine("--Dodge--");
                                Console.WriteLine();

                                string syote4 = "";
                                while (syote4 != "a" && syote4 != "b")
                                {

                                    Console.WriteLine("Valitse Dodgen malli kirjoittamalla a- tai b-kirjain:");
                                    Console.WriteLine();
                                    Console.WriteLine("a. Viper");
                                    Console.WriteLine("b. Challenger");
                                    Console.WriteLine();

                                    syote4 = Console.ReadLine().ToLower();

                                    Valinnan_Tarkistus(syote4);

                                    Console.WriteLine();
                                }

                                if (syote4 == "a")
                                {
                                    Console.WriteLine("--Viper--");
                                    Console.WriteLine();
                                    Console.WriteLine("Tässä uuden, Dodge Viperin tiedot:");
                                    foreach (UusiDodge uusidodge in uusidodgeviper_lista)
                                    {
                                        Console.WriteLine(uusidodge);
                                    }
                                    break;
                                }

                                else if (syote4 == "b")
                                {
                                    Console.WriteLine("--Challenger--");
                                    Console.WriteLine();
                                    Console.WriteLine("Tässä uuden, Dodge Challengerin tiedot:");
                                    foreach (UusiDodge uusidodge in uusidodgechallenger_lista)
                                    {
                                        Console.WriteLine(uusidodge);
                                    }
                                    break;
                                }
                            }
                        }

                        else if (syote1 == "b")
                        {
                            Console.WriteLine("--Käytetyt autot--");
                            Console.WriteLine();

                            string syote22 = "";
                            while (syote22 != "a" && syote22 != "b")
                            {

                                Console.WriteLine("Valitse käytetyn auton merkki kirjoittamalla a- tai b-kirjain:");
                                Console.WriteLine();
                                Console.WriteLine("a. Audi");
                                Console.WriteLine("b. Dodge");
                                Console.WriteLine();

                                syote22 = Console.ReadLine();

                                Valinnan_Tarkistus(syote22);

                                Console.WriteLine();
                            }

                            if (syote22 == "a")
                            {
                                Console.WriteLine("--Käytetyt Audit--");
                                Console.WriteLine();

                                string syote33 = "";
                                while (syote33 != "a" && syote33 != "b")
                                {

                                    Console.WriteLine();
                                    Console.WriteLine("Valitse malli kirjoittamalla a- tai b-kirjain:");
                                    Console.WriteLine();
                                    Console.WriteLine("a. A3");
                                    Console.WriteLine("b. A4");
                                    Console.WriteLine();

                                    syote33 = Console.ReadLine().ToLower();

                                    Valinnan_Tarkistus(syote33);

                                    Console.WriteLine();
                                }

                                {
                                    if (syote33 == "a")
                                    {
                                        Console.WriteLine("--A3--");
                                        Console.WriteLine();
                                        Console.WriteLine("Tässä käytetyn, Audi A3:n tiedot:");

                                        foreach (KäytettyAudi käytettyaudi in käytettyaudia3_lista)
                                        {
                                            Console.WriteLine(käytettyaudi);
                                        }
                                        break;
                                    }

                                    if (syote33 == "b")
                                    {
                                        Console.WriteLine("--A4--");
                                        Console.WriteLine();
                                        Console.WriteLine("Tässä käytetyn, Audi A4:n tiedot:");

                                        foreach (KäytettyAudi käytettyaudi in käytettyaudia4_lista)
                                        {
                                            Console.WriteLine(käytettyaudi);
                                        }
                                        break;
                                    }
                                }
                            }
                            else if (syote22 == "b")
                            {
                                Console.WriteLine("--Käytetyt Dodget--");
                                
                            Console.WriteLine();

                                string syote44 = "";
                                while (syote44 != "a" && syote44 != "b")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Valitse malli kirjoittamalla a- tai b-kirjain:");
                                    Console.WriteLine();
                                    Console.WriteLine("a. Pickup");
                                    Console.WriteLine("b. Charger");
                                    Console.WriteLine();

                                    syote44 = Console.ReadLine().ToLower();

                                    Valinnan_Tarkistus(syote44);

                                    Console.WriteLine();
                                }

                                if (syote44 == "a")
                                {
                                    Console.WriteLine("--Pickup--");
                                    Console.WriteLine();
                                    Console.WriteLine("Tässä käytetyn, Dodge Pickupin tiedot:");

                                    foreach (KäytettyDodge käytettydodge in käytettydodgepickup_lista)
                                    {
                                        Console.WriteLine(käytettydodge);
                                    }
                                    break;
                                }

                                if (syote44 == "b")
                                {
                                    Console.WriteLine("--Charger--");
                                    Console.WriteLine();
                                    Console.WriteLine("Tässä käytetyn, Dodge Chargerin tiedot:");

                                    foreach (KäytettyDodge käytettydodge in käytettydodgecharger_lista)
                                    {
                                        Console.WriteLine(käytettydodge);
                                    }
                                    break;
                                }
                            }
                        }
                    }

                while (true)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Jatketaanko tilausta (k = kyllä, e = ei)");
                        Console.WriteLine();

                        string vastaus = Console.ReadLine().ToLower();

                        if (vastaus == "k")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Seuraavaksi tehdään tilaus!");
                            Console.WriteLine();
                            break;
                        }

                        else if (vastaus == "e")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Peruutetaan tilaus.");
                            Console.WriteLine();
                            Console.WriteLine("Ohjelma lopetetaan...");
                            Environment.Exit(0); //Tällä komennolla ohjelma saadaan loppumaan kokonaan
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Virheellinen syöte, anna 'k'- tai 'e'-kirjain!"); //Ohjelma ilmoittaa virheellisestä syötteestä
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message); //Ohjelma huomauttaa käyttäjää virheellisestä syötteestä
                    }
                }
                Lomaketiedot(); //Käytetään aiemmin luotua metodia ottamaan käyttäjän
                                //tilaukseen tarvittavat tiedot vastaan

                Console.WriteLine();
                Console.WriteLine("Kiitos tilauksestasi! Myyjämme on sinuun yhteydessä mahdollisimman pian!");
                Console.WriteLine();
                Console.WriteLine("Tilausvahvistus lähetetään sähköpostiisi.");
                Console.WriteLine();
                Console.WriteLine("Jos tulee jotain kysymyksiä mieleen, niin soita 040-1234567 Matti Meikäläiselle");
                Console.WriteLine("tai lähetä sähköpostia osoitteeseen matti.meikalainen@autokauppa.com");

                }

                finally //Riippumatta poikkeuksista käyttäjälle ilmoitetaan ohjelman loppumisesta
                {
                    Console.WriteLine();
                    Console.WriteLine("Ohjelman voi sulkea.");
                }
        }
    }
}
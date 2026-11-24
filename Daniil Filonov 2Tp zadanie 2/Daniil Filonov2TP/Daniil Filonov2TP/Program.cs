using System;

class Program
{
    static void Main()
    {
        string[] postacie =
        {
            "Arthas;160;22;25",
            "Lyra;90;42;8",
            "Borin;120;28;15",
            "Kael;145;29;22",
            "Mira;95;38;9",
            "Nora;115;25;17",
            "Ragnar;170;33;27",
            "Nyx;85;45;7"
        };

        int tankowie = 0;
        int zabojcy = 0;
        int zrownowazeni = 0;

        int sumaHP = 0;

        int najwiekszyATK = 0;
        string najsilniejszaPostac = "";


        foreach (string postac in postacie)
        {
            string[] dane = postac.Split(';');

            string nazwa = dane[0];
            int hp = int.Parse(dane[1]);
            int atk = int.Parse(dane[2]);
            int def = int.Parse(dane[3]);

            string rola;

            if (hp >= 140 && def >= 20)
            {
                rola = "Tank";
                tankowie++;
            }
            else if (atk >= 35)
            {
                rola = "Zabojca";
                zabojcy++;
            }
            else
            {
                rola = "Zrownowazony";
                zrownowazeni++;
            }

  
            sumaHP += hp;


            if (atk > najwiekszyATK)
            {
                najwiekszyATK = atk;
                najsilniejszaPostac = nazwa;
            }

            Console.WriteLine("Postac: " + nazwa);
            Console.WriteLine("HP: " + hp + " | ATK: " + atk + " | DEF: " + def);
            Console.WriteLine("Rola: " + rola);
            Console.WriteLine();
        }

        Console.WriteLine("========== LISTA POSTACI ==========");

        for (int i = 0; i < postacie.Length; i++)
        {
            string[] dane = postacie[i].Split(';');
            Console.WriteLine((i + 1) + ". " + dane[0]);
        }


        double srednieHP = (double)sumaHP / postacie.Length;

        Console.WriteLine();
        Console.WriteLine("========== PODSUMOWANIE ==========");
        Console.WriteLine();
        Console.WriteLine("Liczba postaci: " + postacie.Length);
        Console.WriteLine();
        Console.WriteLine("Tankowie: " + tankowie);
        Console.WriteLine("Zabojcy: " + zabojcy);
        Console.WriteLine("Zrownowazeni: " + zrownowazeni);
        Console.WriteLine();
        Console.WriteLine("Najwiekszy atak: " + najsilniejszaPostac + " (" + najwiekszyATK + " ATK)");
        Console.WriteLine();
        Console.WriteLine("Srednia liczba HP: " + srednieHP);
    }
}

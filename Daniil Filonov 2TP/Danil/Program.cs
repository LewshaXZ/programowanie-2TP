using System;

class Program
{
    static void Main()
    {
        int hp = 10;
        int attack = 5;
        int enemyHp = 20;
        int choice;

        do
        {
            Console.WriteLine("=== POSTAĆ ===");
            Console.WriteLine();
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Atak: " + attack);
            Console.WriteLine("HP przeciwnika: " + enemyHp);
            Console.WriteLine();
            Console.WriteLine("1 - Leczenie");
            Console.WriteLine("2 - Trening");
            Console.WriteLine("3 - Atak na przeciwnika");
            Console.WriteLine("0 - Zakończ program");
            Console.WriteLine();
            Console.Write("> ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                hp++;
            }

            if (choice == 2)
            {
                attack++;
            }

            if (choice == 3)
            {
                if (enemyHp > 0)
                {
                    enemyHp = enemyHp - attack;

                    if (enemyHp <= 0)
                    {
                        Console.WriteLine(
                            "Przeciwnik został pokonany!");
                    }
                    else
                    {
                        Console.WriteLine(
                            "HP przeciwnika: " + enemyHp);
                    }
                }
                else
                {
                    Console.WriteLine(
                        "Przeciwnik został już pokonany!");
                }
            }

            Console.WriteLine();

        } while (choice != 0);

        Console.WriteLine("Koniec programu.");
    }
}
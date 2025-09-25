List<int> Dices = new List<int>();
Random rnd = new Random();

for (int Rondes = 1; Rondes < 14; Rondes++)
{
    Console.WriteLine($"Ronde {Rondes}");

    for (int Beurt = 1; Beurt < 4; Beurt++)
    {
        while (Dices.Count < 5)
        {
            Dices.Add(rnd.Next(0, 7));
        }

        bool breaker = true;
        while (breaker)
        {
            Console.WriteLine("Kies 1t/m5 om die dobbelsteen te vervangen \n Kies 6 om opnieuw te dobbelen");
            Console.WriteLine($"De lijst {string.Join(", ", Dices)}");

            string? playerInput = Console.ReadLine();

            if (int.TryParse(playerInput, out int playerInt))

            {
                switch (playerInt)
                {
                    case 1:
                        Dices.RemoveAt(0);
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 2:
                        Dices.RemoveAt(1);
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 3:
                        Dices.RemoveAt(2);
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 4:
                        Dices.RemoveAt(3);
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 5:
                        Dices.RemoveAt(4);
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6");
                        breaker = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Verkeerde input, alleen cijfers 1t/m6!");
            }
        }
        Console.WriteLine($"Beurt {Beurt}: {string.Join(", ", Dices)}");
    }
    
}
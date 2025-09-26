using System.Runtime.InteropServices;

List<int> Dices = new List<int>();
Random rnd = new Random();
Console.Clear();

for (int Rondes = 1; Rondes < 14; Rondes++)
{
    Dices.Clear();

    for (int Beurt = 1; Beurt < 4; Beurt++)
    {

        while (Dices.Count < 5)
        {
            Dices.Add(rnd.Next(1, 7));
        }
        for (int i = 0; i < Dices.Count; i++)
        {
            if (Dices[i] == 0)
                Dices[i] = rnd.Next(1, 7);
        }
        bool breaker = true;
        while (breaker)
        {
            Console.Clear();
            Console.Write($"Ronde {Rondes} | ");
            Console.WriteLine($"Beurt {Beurt} |  {string.Join(", ", Dices)}");
            Console.WriteLine("Kies 1t/m5 om die dobbelsteen te vervangen \n Kies 6 om opnieuw te dobbelen");

            string? playerInput = Console.ReadLine();

            if (int.TryParse(playerInput, out int playerInt))

            {
                switch (playerInt)
                {
                    case 1:
                        Dices[0] = 0;
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 2:
                        Dices[1] = 0;
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 3:
                        Dices[2] = 0;
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 4:
                        Dices[3] = 0;
                        Console.WriteLine($"De nieuwe lijst {string.Join(", ", Dices)}");
                        break;
                    case 5:
                        Dices[4] = 0;
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
    }
    Console.Clear();
    Console.WriteLine($"Ronde {Rondes} | {string.Join(", ", Dices)}");
    Console.WriteLine("Kies nu onder welke categorie je de stenen wilt plaatsen!\n1 | Eens\n2 | Twees\n3 | Drieen\n4 | Vieren\n5 | Vijven\n6 | Zessen\n7 | 3 dezelde\n8 | 4 dezelde\n9 | Full house\n10| Kleine straat\n11| Groote straat\n12| Yatzee\n_______________________________________________________________");
    Console.Write("Voer hier je antwoord in: ");
    string? Catergorieen_input = Console.ReadLine();
    if (int.TryParse(Catergorieen_input, out int Catergorieen_output))
    {
        switch (Catergorieen_output)
        {
            case 1:
                int aces = Dices.Count(Cijfer => Cijfer == 1);
                Console.WriteLine(aces);
                Console.ReadLine();
                break;
            case 2:
                int Twees = Dices.Where(cijfer => cijfer == 2).Sum();
                Console.WriteLine(Twees);
                Console.ReadLine();
                break;
            case 3:
                int Drieen = Dices.Where(cijfer => cijfer == 2).Sum();
                Console.WriteLine(Drieen);
                Console.ReadLine();
                break;
            case 4:
            int Vieren = Dices.Where(cijfer => cijfer == 2).Sum();
                Console.WriteLine(Vieren);
                Console.ReadLine();
                break;
            case 5:
            int Vijven = Dices.Where(cijfer => cijfer == 2).Sum();
                Console.WriteLine(Vijven);
                Console.ReadLine();
                break;
            case 6:
            int Zessen = Dices.Where(cijfer => cijfer == 2).Sum();
                Console.WriteLine(Zessen);
                Console.ReadLine();
                break;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            default:
                break;
        }
    }

    else
    {
        Console.WriteLine("Verkeerde input, alleen cijfers 1t/m12!");
    }
    Console.Clear();
}
// 3x
// 4x
// full house 3x2 25pnt
// kleine straat 4 opbouwend 30 pnt
// grote straat 5 opbouwend 40 pnt
// yatzee 5x 50 pnt
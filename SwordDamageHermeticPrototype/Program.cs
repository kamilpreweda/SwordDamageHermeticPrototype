using SwordDamageHermeticPrototype;

namespace SwordDamageCalculator
{

    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {

            SwordDamageHermetic swordDamageHermetic = new SwordDamageHermetic(RollDice());
            while (true)
            {
                Console.WriteLine("Witaj! Wybierz rodzaj miecza: (aby zakończyć, wpisz inną wartość niż podane)");
                Console.WriteLine("0 - ani magiczny, ani płonący, 1 - magiczny, 2 - płonący, 3 - magiczny i płonący");

                char userInput = Console.ReadKey(true).KeyChar;

                if (userInput == '0' || userInput == '1' || userInput == '2' || userInput == '3')
                {
                    Console.WriteLine($"Wybrałeś: {userInput}");
                }
                else return;

                swordDamageHermetic.Roll = RollDice();

                
                swordDamageHermetic.Magic = (userInput == '1' || userInput == '3');

                swordDamageHermetic.Flaming = (userInput == '2' || userInput == '3');

                Console.WriteLine($"Rzut: {swordDamageHermetic.Roll}, \npunkty obrażeń: {swordDamageHermetic.Damage}");




            }
        }

       
        private static int RollDice()
            {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            
            }
        }

        
    } 
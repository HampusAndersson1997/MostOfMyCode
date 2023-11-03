namespace DiceRoller
{
    internal class Program
    {
        public class DiceRoller
        {
            private static Random rand = new Random();

            public static int Die6()
            {
                return rand.Next(1, 7);
            }

            public static int Dice6(int times)
            {
                int sum = 0;
                for (int i = 0; i < times; i++)
                {
                    sum += Die6();
                }
                return sum;
            }

            public static int Die(int sides)
            {
                return rand.Next(1, sides + 1);
            }

            public static int Dice(int sides, int times)
            {
                int sum = 0;
                for (int i = 0; i < times; i++)
                {
                    sum += Die(sides);
                }
                return sum;
            }

            public static void Battle()
            {
                int playerHitPoints = 20;
                int playerWeaponDamage = Dice(11, 2);
                int playerParry = Die(6);
                int playerArmor = 2;

                int monsterHitPoints = 30;
                int monsterWeaponDamage = Dice(6, 3);
                int monsterParry = 0;
                int monsterArmor = 2;

                while (playerHitPoints > 0 && monsterHitPoints > 0)
                {
                    int playerAttack = playerWeaponDamage - monsterParry;
                    int monsterAttack = monsterWeaponDamage - playerParry;

                    if (playerAttack > 0)
                    {
                        monsterHitPoints -= Math.Max(playerAttack - monsterArmor, 0);
                    }

                    if (monsterAttack > 0)
                    {
                        playerHitPoints -= Math.Max(monsterAttack - playerArmor, 0);
                    }
                }

                if (playerHitPoints <= 0)
                {
                    Console.WriteLine("Monstret vann!");
                }
                else
                {
                    Console.WriteLine("Spelaren vann!");
                }
            }

            public static int Fibonacci(int n)
            {
                int f0 = 0;
                int f1 = 1;

                if (n == 0) return f0;
                if (n == 1) return f1;

                int fn = 0;
                for (int i = 2; i <= n; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                }

                return fn;
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("1. Kasta en 6-sidig tärning:");
                int die6Result = Die6();
                Console.WriteLine($"Resultat: {die6Result}");

                Console.WriteLine("\n2. Kasta en 6-sidig tärning flera gånger:");
                int dice6Result = Dice6(3); // Exempel: Kasta tärningen 3 gånger
                Console.WriteLine($"Summa av tärningskast: {dice6Result}");

                Console.WriteLine("\n3. Kasta en valfri tärning:");
                int dieResult = Die(10); // Exempel: Kasta en 10-sidig tärning
                Console.WriteLine($"Resultat: {dieResult}");

                Console.WriteLine("\n4. Kasta en valfri tärning flera gånger:");
                int diceResult = Dice(12, 4); // Exempel: Kasta en 12-sidig tärning 4 gånger
                Console.WriteLine($"Summa av tärningskast: {diceResult}");

                Console.WriteLine("\n5. Strid mellan spelaren och monstret:");
                Battle();

                Console.WriteLine("\n6. Beräkna Fibonacci-tal:");
                int fibonacciResult = Fibonacci(11); // Exempel: Beräkna det 11:e Fibonacci-talet
                Console.WriteLine($"Fibonacci(11) = {fibonacciResult}");
            }
        }
    }
}
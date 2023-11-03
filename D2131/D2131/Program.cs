using System;
namespace D2131
{
    internal class Program
    {
        public static void Main()
        {
            // Uppgift 31
            int roll = Die6();
            Console.WriteLine($"Tärningskast med 6-sidig tärning: {roll}");

            // Uppgift 32
            int totalRolls = 5; // Ändra detta till önskat antal kast
            int sum = Dice6(totalRolls);
            Console.WriteLine($"Summa av {totalRolls} tärningskast med 6-sidig tärning: {sum}");

            // Uppgift 33
            int n = 10; // Antal sidor på tärningen, ändra efter behov
            int m = 3;  // Antal tärningar, ändra efter behov
            int sumCustomDice = Dice(n, m);
            Console.WriteLine($"Summa av {m} tärningskast med {n}-sidig tärning: {sumCustomDice}");

            // Uppgift 34
            Player player = new Player(20, new Weapon(11, 2), new Shield(6), 2);
            Monster monster = new Monster(30, new Weapon(6, 3), new Shield(0), 2);
            int battles = 100; // Antal strider att simulera
            int playerWins = SimulateBattles(player, monster, battles);
            Console.WriteLine($"Spelaren vann {playerWins} av {battles} strider.");

            // Uppgift 35
            int nFib = 11; // Ange önskat n-värde för Fibonacci-sekvensen
            int fibonacci = Fibonacci(nFib);
            Console.WriteLine($"Fibonacci({nFib}) = {fibonacci}");
        }

        // Uppgift 31
        public static int Die6()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        // Uppgift 32
        public static int Dice6(int numRolls)
        {
            int sum = 0;
            for (int i = 0; i < numRolls; i++)
            {
                sum += Die6();
            }
            return sum;
        }

        // Uppgift 33
        public static int Die(int sides)
        {
            Random rand = new Random();
            return rand.Next(1, sides + 1);
        }

        public static int Dice(int sides, int numDice)
        {
            int sum = 0;
            for (int i = 0; i < numDice; i++)
            {
                sum += Die(sides);
            }
            return sum;
        }

        // Uppgift 34
        public static int SimulateBattles(Player player, Monster monster, int numBattles)
        {
            int playerWins = 0;
            for (int i = 0; i < numBattles; i++)
            {
                while (player.HitPoints > 0 && monster.HitPoints > 0)
                {
                    int playerDamage = player.Attack();
                    int monsterDamage = monster.Attack();
                    player.TakeDamage(monsterDamage);
                    monster.TakeDamage(playerDamage);
                }
                if (player.HitPoints > 0)
                {
                    playerWins++;
                }
                player.Reset();
                monster.Reset();
            }
            return playerWins;
        }

        // Uppgift 35
        public static int Fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int f2 = 0;
            if (n == 0) return f0;
            if (n == 1) return f1;
            for (int i = 2; i <= n; i++)
            {
                f2 = f0 + f1;
                f0 = f1;
                f1 = f2;
            }
            return f2;
        }
    }

    public class Weapon
    {
        private int sides;
        private int numDice;

        public Weapon(int sides, int numDice)
        {
            this.sides = sides;
            this.numDice = numDice;
        }

        public int Attack()
        {
            return Program.Dice(sides, numDice);
        }
    }

    public class Shield
    {
        private int sides;

        public Shield(int sides)
        {
            this.sides = sides;
        }

        public int Parry()
        {
            return Program.Die(sides);
        }
    }

    public class Player
    {
        public int HitPoints { get; private set; }
        private Weapon weapon;
        private Shield shield;
        private int armor;

        public Player(int hitPoints, Weapon weapon, Shield shield, int armor)
        {
            HitPoints = hitPoints;
            this.weapon = weapon;
            this.shield = shield;
            this.armor = armor;
        }

        public int Attack()
        {
            return weapon.Attack();
        }

        public void TakeDamage(int damage)
        {
            int parry = shield.Parry();
            int totalDamage = Math.Max(damage - parry, 0) - armor;
            if (totalDamage > 0)
            {
                HitPoints -= totalDamage;
            }
        }

        public void Reset()
        {
            HitPoints = 20; // Återställ hit points efter varje strid
        }
    }

    public class Monster
    {
        public int HitPoints { get; private set; }
        private Weapon weapon;
        private Shield shield;
        private int armor;

        public Monster(int hitPoints, Weapon weapon, Shield shield, int armor)
        {
            HitPoints = hitPoints;
            this.weapon = weapon;
            this.shield = shield;
            this.armor = armor;
        }

        public int Attack()
        {
            return weapon.Attack();
        }

        public void TakeDamage(int damage)
        {
            int parry = shield.Parry();
            int totalDamage = Math.Max(damage - parry, 0) - armor;
            if (totalDamage > 0)
            {
                HitPoints -= totalDamage;
            }
        }

        public void Reset()
        {
            HitPoints = 30; // Återställ hit points efter varje strid
        }
    }
}
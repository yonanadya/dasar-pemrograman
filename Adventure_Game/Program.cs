// YONA NADYA FADILA -2207112585
// T.INFORMATIKA - B

using System;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Adventure Game!!");
            Console.WriteLine("What is your name?");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("\nHello "+player.Name+"!!, Are you ready to begin this Adventure Game?\nyay or nay?");
            string bReady = Console.ReadLine();
            if(bReady == "yay")
            {
                Console.WriteLine("\n"+player.Name+", now you're gonna entering this game!\nThe game will start in 3 seconds...");
                Console.WriteLine("The game start in 3"); Console.ReadKey();
                Console.WriteLine("The game start in 2"); Console.ReadKey();
                Console.WriteLine("The game start in 1"); Console.ReadKey();
                Enemy enemy1 = new Enemy("Thanos");
                Console.WriteLine("\n"+player.Name+" is encountering "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" is attacking you... ");
                Console.WriteLine("Your action choice : ");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !enemy1.IsDead && !player.IsRunningAway)
                {
                    Console.Write("Choose an action : ");
                    string playerAction = Console.ReadLine();
                    switch(playerAction)
                    {
                        case "1":
                        Console.WriteLine("\n"+player.Name+" is doing single attack");
                        enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.WriteLine("Player Health : "+player.Health+" \nEnemy Health : "+enemy1.Health);
                        break;
                        case "2":
                        player.Swing();
                        player.Experience += 0.8f;
                        enemy1.GetHit(player.AttackPower);
                        Console.WriteLine("Player Health : "+player.Health+" \nEnemy Health : "+enemy1.Health);
                        break;
                        case "3":
                        player.Rest();
                        Console.WriteLine("\nEnergy is being restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.WriteLine("Player Health : "+player.Health+" \nEnemy Health : "+enemy1.Health);
                        break;
                        case "4":
                        Console.WriteLine("\n"+player.Name+" is running away...");
                        player.RunningAway();
                        break;
                    }
                }

                Console.WriteLine(player.Name+" get "+player.Experience+" experience point...");
            }
            else
            {
                Console.WriteLine("\nOke "+player.Name+", See you when you ready to start this game!\nGoodbye!!!");
                Console.Read();
            } 
        }
    }

    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        public bool IsRunningAway { get; set; }
        Random rnd = new Random();

        public Novice()
        {
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Swing()
        {
            if(SkillSlot > 0)
            {
                Console.WriteLine("\nSWINGGG!!!");
                AttackPower = AttackPower + rnd.Next(3,10);
                SkillSlot--; 
            }
            else
            {
                Console.WriteLine("\nYou don't have enough energy!");
            }           
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.WriteLine("You cannot survive!\nYou're dead!!\n The game is over!!!\nYOU LOSEE!!\nGoodbyee! ");
            IsDead = true;
        }

        public void RunningAway()
        {
            IsRunningAway = true;
        }
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 80;
            Name = name;
        }

        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine(Name+" is dead!\nYOU WINN THIS GAME!!");
            IsDead = true;
        }
    }
}

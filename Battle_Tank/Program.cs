/*
 Yona Nadya Fadila - 2207112585
 Teknik Informatika - B
*/
using System;

namespace Battle_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
          Intro();

          //Variable
          int dessertLength = 5;
          char tank = 'T';
          char sand = '~';
          char hit = 'X';
          char miss = 'O';
          int tankTotal = 3;

          //Make Array 2D for tank place
          char[,] dessert = createDessert(dessertLength, sand, tank, tankTotal);

          //Print Array 2D to console
          printDessert(dessert, sand, tank);

          //Number of hidden tanks
          int unknownTankDetected = tankTotal;

          //gamePlay
          while(unknownTankDetected > 0)
          {
            int[] guessCoordinates = getUserCoordinates(dessertLength);
            char locationViewUpdate = verifyGuessAndTarget(guessCoordinates, dessert, tank, sand, hit, miss);
            if(locationViewUpdate == hit)
            {
                unknownTankDetected--;
            }
            dessert = updateDessert(dessert, guessCoordinates, locationViewUpdate);
            printDessert(dessert, sand, tank);
          }
          Console.WriteLine("\nCONGRATULATION!!");
          Console.WriteLine("The Game Is Over..\nYou already find all of the tank\nThank You For Playing This Game <3\nSee Youu!");
          Console.Read();
        }

         //Intro
        private static void Intro()
        {
            Console.WriteLine("\nHello friends!!");
            Console.WriteLine("Welcome to the Battle Tank game");
            Console.WriteLine("In this game, you must find 3 hidden tanks");
            Console.WriteLine("You can find the tanks by choose the correct coordinates");
            Console.WriteLine("Press enter to play the game!!");
            Console.WriteLine("GOOD LUCK!!!!");
            Console.ReadLine();
        }

        //Print Array 2D to console screen
        private static void printDessert(char[,] dessert, char sand, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                Console.Write(row + 1 + " ");
                for (int coloumn = 0; coloumn < 5; coloumn++)
                {
                    char position = dessert[row,coloumn];
                    if(position == tank)
                    {
                        Console.Write(sand + " ");
                    }
                    else
                    {
                        Console.Write(position + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        //Player guess validation 
        private static char verifyGuessAndTarget(int[] guessCoordinates, char[,] dessert, char tank, char sand, char hit, char miss)
        {
            string message;
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            char target = dessert[row, coloumn];
            if(target == tank)
            {
                message = "\nYeyy!\nYou choose the correct target\nYOU HIT THE TARGET!!\n";
                target = hit;
            }
            else if(target == sand)
            {
                message = "\nYOU MISSED!!!\nLets try again\n";
                target = miss;
            }
            else
            {
                message = "\nThis target has been chosen\nPlease choose another target\n";
            }
            Console.WriteLine(message);
            return target;
        }

        //Update Array 2D base on the Player Guess
        private static char[,] updateDessert(char[,] dessert, int[] guessCoordinates, char locationViewUpdate)
        {
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            dessert[row,coloumn] = locationViewUpdate;
            return dessert;
        }

        //Player Input
        private static int[] getUserCoordinates(int dessertLength)
        {
            int row;
            int coloumn;

            do
            {
                Console.Write("Pilihlah Salah Satu Baris : ");
                row = Convert.ToInt32(Console.ReadLine());
            }
            while(row < 0 || row > dessertLength + 1);

            do
            {
                Console.Write("Pilihlah Salah Satu Kolom : ");
                coloumn = Convert.ToInt32(Console.ReadLine());
            }
            while(coloumn < 0 || coloumn > dessertLength + 1);

            return new[]{row -1, coloumn -1};
        }

        private static char[,] createDessert(int dessertLength, char sand, char tank, int tankTotal)
        {
            char[,] dessert = new char[dessertLength, dessertLength];
            for (int row = 0; row < dessertLength; row++)
            {
                for (int coloumn = 0; coloumn < dessertLength; coloumn++)
                {
                    dessert[row,coloumn] = sand;
                }
            }
            return placeTanks(dessert, tankTotal, sand, tank);
        }

        //Place the tank to Array 2D
        private static char[,] placeTanks(char[,] dessert, int tankTotal, char sand, char tank)
        {
            int placedTanks = 0;
            int dessertLength = 5;

            while(placedTanks < tankTotal)
            {
                int[] tankLocation = generateTankCoordinate(dessertLength);
                char positionOk = dessert[tankLocation[0], tankLocation[1]];

                if(positionOk == sand)
                {
                    dessert[tankLocation[0], tankLocation[1]] = tank;
                    placedTanks++;
                }
            }
            return dessert;
        }

        private static int[] generateTankCoordinate(int dessertLength)
        {
            Random rnd = new Random();
            int[] coordinates = new int[3];
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = rnd.Next(dessertLength);
            }
            return coordinates;
        }
    }
}

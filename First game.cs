using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int randInt = new Random().Next(1, 3);
            char[,] map = new char[Maps.map1.GetLength(0), Maps.map1.GetLength(1)];
            switch (randInt)
            {
                case 1:
                    map = Maps.map1;
                    break;
                case 2:
                    map = Maps.map2;
                    break;

            }
            int userX = 1, userY = 1;
            char[] bag = new char[1];
      
            //placing fruits
            int counter = 0;
            while (counter < 3)
            {
                int randFruitX = new Random().Next(1, 11);
                int randFruitY = new Random().Next(1, 11);
                if ((randFruitX != 1 && randFruitY != 1) && map[randFruitX, randFruitY] != '#' && map[randFruitX, randFruitY] != 'X')
                {
                    map[randFruitX, randFruitY] = 'X';
                    counter++;
                }
            }



            while (true)
            {
                Console.SetCursorPosition(0, 15);
                Console.Write("Bag: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                //map
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                
                //movement
                Console.SetCursorPosition(userY, userX);
                Console.WriteLine('@');
                ConsoleKeyInfo move = Console.ReadKey();
                switch (move.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }

                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'o';
                    bag = BagExterner(bag);
                }

                Console.Clear();
            }
        }

        public static char[] BagExterner(char[] bag)
        {
            char[] tempBag = new char[bag.Length + 1];
            for (int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
            }
            tempBag[bag.Length - 1] = 'X';
            bag = tempBag;
            return bag;
        }
    }
        
        
    public class Maps
    {
        public static char[,] map1 =
        {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
        };

        public static char[,] map2 =
        {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', '#', '#', '#', '#', '#', '#', '#', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
        };
    }
}

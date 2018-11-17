using System;

namespace Foundation.Hub256.Seawar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Row: ");
            int rowLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Col: ");
            int colLength = int.Parse(Console.ReadLine());

            Cell[,] field = new Cell[rowLength, colLength];
            //field[5, 5] = Cell.Ship;
            //field[6, 7] = Cell.DeadShip;
            //field[1, 3] = Cell.NotShip;
            //field[9, 9] = Cell.HittedShip;
            //field[5, 2] = Cell.HittedSea;

            GameEngine printSeaField = new GameEngine();
            printSeaField.PrintField(field);

           
            Console.ReadKey();
        }
    }
}

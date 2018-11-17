using System;

namespace Foundation.Hub256.Seawar
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell[,] cells = new Cell[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cells[i, j] = Cell.Empty;
                }
            }
            Ship ship = new Ship();
            ship.Start.X = 2;
            ship.Start.Y = 2;
            ship.End.X = 2;
            ship.End.Y = 4;

            GameEngine g = new GameEngine();
           g.MarkDead(cells, ship);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                    Console.Write(cells[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}

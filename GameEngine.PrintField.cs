using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Prints the ship field. Possible values of fields are     
        /// </summary>
        public void PrintField(Cell[,] field)
        {

            string symbol = "empty";
            int rowLength = field.GetLength(0);
            int colLength = field.GetLength(1);

            Console.WriteLine("  A     B     C     D     E     F     G     H     I     J");

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (field[i, j] == Cell.Empty)
                    {
                        symbol = "~";
                    }
                    else if (field[i, j] == Cell.Ship)
                    {
                        symbol = ">>";
                    }
                    else if (field[i, j] == Cell.HittedShip)
                    {
                        symbol = "*";
                    }
                    else if (field[i, j] == Cell.DeadShip)
                    {
                        symbol = "X";
                    }
                    else if (field[i, j] == Cell.HittedSea)
                    {
                        symbol = "#";
                    }
                    else if (field[i, j] == Cell.NotShip)
                    {
                        symbol = "O";
                    }

                    Console.Write(string.Format("  {0}  |", symbol));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
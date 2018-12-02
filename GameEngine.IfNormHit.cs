using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        ///GenerateRandomHit
        /// </summary>
        public void IfNomrHit(Cell[,] field)
        {   Random rand = new Random();
            Coordinates coord = GenerateRandomHit(rand);
            
            while(!(field[coord.X , coord.Y] == Cell.Empty || field[coord.X , coord.Y] == Cell.Ship))
            {
                coord = GenerateRandomHit(rand);
            }
        }
    }
}
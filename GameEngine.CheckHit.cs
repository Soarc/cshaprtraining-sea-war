using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Finds and returns start and end coordinates of ship at position x, y.
        /// </summary>
        public bool CheckHit(Cell[,] field, Coordinates coord)
        {            
            return field[coord.X,coord.Y]==Cell.Ship; 
        }
    }
}
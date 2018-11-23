using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Check, if ship in position x,y is killed by this hit
        /// </summary>
        public bool IsDead(Cell[,] field, Coordinates coord)
        {
            Ship boat = FindShip(field, coord);

            if (boat.Orientation == ShipOrientation.Horizontal)
            {
                for (int i = boat.Start.X; i <= boat.End.X; i++)
                {
                    if (field[i, boat.Start.Y] != Cell.HittedShip && i != coord.X)
                    {
                        return false;
                    }
                }
            }

            for (int i = boat.Start.Y; i <= boat.End.Y; i++)
            {
                if (field[boat.Start.X, i] != Cell.HittedShip && i != coord.Y)
                {
                    return false;
                }
            }


            return true;
        }
    }
}

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
			Ship boat;
			boat = FindShip(field, coord);
			bool isRip = true;

			if (boat.Orientation == ShipOrientation.Horizontal)
				for (int i = boat.Start.X; i <= boat.End.X; i++)
					if (field[i, boat.Start.Y] != Cell.HittedShip)
					{
						isRip = false;
						break;	
					}
					else
						isRip = true;
			else if (boat.Orientation == ShipOrientation.Vertical)
				for (int i = boat.Start.Y; i <= boat.End.Y; i++)
					if (field[boat.Start.X, i] != Cell.HittedShip)
					{
						isRip = false;
						break;	
					}
					else
						isRip = true;

                     return isRip;
        }
    }
}

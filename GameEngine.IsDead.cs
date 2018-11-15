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
			int q;

			if (boat.Orientation == Horizontal)
				for (int i = boat.Start.X; i <= boat.End.X; i++)
					if (i != HittedShip)
						break;
					else
						i = DeadShip;
			else if(boat.Orientation == Vertical)
				for (int i = boat.Start.Y; i <= boat.End.Y; i++)
                    if (i != HittedShip)
                        break;
                    else
                        i = DeadShip;



            throw new NotImplementedException();            
        }
    }
}
using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Checks, if ship can be placed at field.
        /// </summary>
        public bool CanBePlaced(Cell[,] field, Ship ship)
        {

            for (int i = -1; i < (int)ship.Size+1; i++)
            {
                if (ship.Orientation == ShipOrientation.Vertical)
                {
                    if (field[ship.Start.X, ship.Start.Y + i] == Cell.Ship
                    || (ship.Start.X+1<10 && field[ship.Start.X+1, ship.Start.Y + i] == Cell.Ship) 
                    ||(ship.Start.X-1>0 && field[ship.Start.X-1, ship.Start.Y + i] == Cell.Ship) )
                    {
                        return false;
                    }
                    
                }

                else
                {
                    if (ship.Orientation == ShipOrientation.Horizontal)
                    {
                        if (field[ship.Start.X + i, ship.Start.Y] == Cell.Ship)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;     
        }

    }
}
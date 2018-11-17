using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Marks ship at position (x1,y1) - (x2,y2) dead and marks surraround cells as hitted sea
        /// </summary>
        public void MarkDead(Cell[,] field, Ship ship)
        {

            if (ship.Orientation == ShipOrientation.Vertical)
            {
                int i = ship.Start.X; ;

                for (int j = ship.Start.Y; j <= ship.End.Y; j++)
                {
                    field[i, j] = Cell.DeadShip;
                   if (i > 0)
                    {
                        field[i - 1, j] = Cell.NotShip;
                    }
                    if (i < 9)
                    {
                        field[i + 1, j] = Cell.NotShip;
                    }

                }
                 if (ship.Start.Y - 1 >= 0)
                {
                    field[ship.Start.X, ship.Start.Y-1] = Cell.NotShip;
 
                    if(ship.Start.X - 1 >= 0)
                    {
                        field[ship.Start.X -1, ship.Start.Y-1] = Cell.NotShip;
                    }
                    if(ship.Start.X + 1 <= 9)
                    {
                        field[ship.Start.X +1, ship.Start.Y-1] = Cell.NotShip;
                    }
                }
                 if (ship.End.Y + 1 <= 9)
                {
                    field[ship.End.X , ship.End.Y +1] = Cell.NotShip;
 
                    if(ship.End.X - 1 >= 0)
                    {
                        field[ship.End.X - 1, ship.End.Y + 1] = Cell.NotShip;
                    }
                    if(ship.Start.X + 1 <= 9)
                    {
                        field[ship.End.X + 1, ship.End.Y + 1] = Cell.NotShip;
                    }
                }
            }
            

            // Horizontal

              if (ship.Orientation == ShipOrientation.Horizontal)
            {
                int i = ship.Start.X; ;

                for (int j = ship.Start.Y; j <= ship.End.Y; j++)
                {
                    field[i, j] = Cell.DeadShip;
                   if (i > 0)
                    {
                        field[i - 1, j] = Cell.NotShip;
                    }
                    if (i < 9)
                    {
                        field[i + 1, j] = Cell.NotShip;
                    }

                }
                 if (ship.Start.Y - 1 >= 0)
                {
                    field[ship.Start.X, ship.Start.Y-1] = Cell.NotShip;
 
                    if(ship.Start.X - 1 >= 0)
                    {
                        field[ship.Start.X -1, ship.Start.Y-1] = Cell.NotShip;
                    }
                    if(ship.Start.X + 1 <= 9)
                    {
                        field[ship.Start.X +1, ship.Start.Y-1] = Cell.NotShip;
                    }
                }
                 if (ship.End.Y + 1 <= 9)
                {
                    field[ship.End.X , ship.End.Y +1] = Cell.NotShip;
 
                    if(ship.End.X - 1 >= 0)
                    {
                        field[ship.End.X - 1, ship.End.Y + 1] = Cell.NotShip;
                    }
                    if(ship.Start.X + 1 <= 9)
                    {
                        field[ship.End.X + 1, ship.End.Y + 1] = Cell.NotShip;
                    }
                }
            }
            



        }
    }
}
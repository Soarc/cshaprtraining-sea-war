using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Reads pair of coordinates from console and checks if input is a ship and has correct size.
        /// </summary>
        public Ship ReadShip(ShipSize size)
        {
            Ship ship=new Ship();
            string a=Console.ReadLine();
            ship.Start.X=a[0];
            ship.Start.Y=a[1];
            ship.End.X=a[3];
            ship.End.Y=a[4];

 if (ship.End.X-ship.Start.X==0)
 {
     
     if (ship.End.Y-ship.Start.Y+1==1)
     {
        return ship;   
     }
    else  if (ship.End.Y-ship.Start.Y+1==2)
     {
         return ship;
     }
    else  if (ship.End.Y-ship.Start.Y+1==3)
     {
         return ship;
     }
    else  if (ship.End.Y-ship.Start.Y+1==4)
     {
         return ship;
     }
     else
     {
        return 0;
     }
 }
 else if (ship.End.Y-ship.Start.Y==0)
 {
      if (ship.End.X-ship.Start.X+1==1)
     {
         return ship;
     }
    else  if (ship.End.X-ship.Start.X+1==2)
     {
         return ship;
     }
    else  if (ship.End.X-ship.Start.X+1==3)
     {
         return ship;
     }
    else  if (ship.End.X-ship.Start.X+1==4)
     {
         return ship;
     }
     else 
     {
return 0;
     }
 }
else
{
return 0;
}
 
        }
    }
}
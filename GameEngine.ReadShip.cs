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
            Ship ship = new Ship();
            bool IsCompiled = false;
            int m, n;
            while (IsCompiled == false)
            {
                string a = Console.ReadLine();
                if (a.Length == 5)
                {
                    if (a[2] == ' ')
                    {
                        m = (int)a[1];
                        n = (int)a[4];
                        if (a[0] < 91 && a[0] > 64 && a[3] < 91 && a[3] > 64)
                        {
                            ship.Start.X = a[0] - 'A';
                            ship.End.X = a[3] - 'A';

                        }
                        else if (a[0] > 96 && a[0] < 123 && a[3] > 96 && a[3] < 123)
                        {
                            ship.Start.X = a[0] - 'a';
                            ship.End.X = a[3] - 'a';

                        }
                        else
                        {
                            Console.WriteLine("Nermucir noric u ushadir! ");
                            continue;
                        }

                        ship.Start.Y = m;
                        ship.End.Y = n;


                        if (ship.End.X - ship.Start.X == 0)
                        {

                            if (Math.Abs(ship.End.Y - ship.Start.Y) + 1 == (int)size)
                            {
                                return ship;
                            }
                            else
                            {
                                Console.WriteLine("Nermucir noric u ushadir! ");
                                continue;
                            }

                        }
                        else if (ship.End.Y - ship.Start.Y == 0)
                        {
                            if (Math.Abs(ship.End.X - ship.Start.X) + 1 == (int)size)
                            {
                                return ship;
                            }
                            else
                            {
                                Console.WriteLine("Nermucir noric u ushadir! ");
                                continue;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Nermucir noric u ushadir! ");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Nermucir noric u ushadir! ");
                    continue;
                }
            }
            return default(Ship);

        }
    }
}
using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Reads the string from input and parses it. Input is in format of A1, the output should be in format of 0,0
        /// </summary>
        public Coordinates ReadInput()
        {
            Coordinates coordinates = new Coordinates();
            bool Corect = false;
            while (!Corect)
            {
                string a = Console.ReadLine();
                if (a.Length > 2 && a.Length < 2)
                {
                    Console.WriteLine("oops:entered symbols count I'ts wrong");
                }
                else
                {

                    char b = a[0];
                    char c = a[1];

                    //Int32.TryParse(b.ToString(), out int d);
                    Int32.TryParse(c.ToString(), out int e);

                      if (e >= '0' && e <= '9')

                      {
                        if ('a' <= b && b <= 'z')
                        {
                            coordinates.Y = b - 'a';
                            Corect = true;
                        }

                        else if ('A' <= b && b <= 'Z')
                        {
                            coordinates.Y = b - 'A';
                        }


                        coordinates.X = e - 1;
                        if (Corect)
                            return coordinates;
                      }
                    else
                    {
                        Console.WriteLine("oops: The second  symbol must be a number");
                    }
                

                }
            }
            return default(Coordinates);
        }
            
    }
    

}
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
            while (true)
            {
                string a = Console.ReadLine();
                if (a.Length > 2 || a.Length < 2)
                {
                    Console.WriteLine("oops:entered symbols count I'ts wrong");
                    continue;
                }

                char b = a[0];
                char c = a[1];

                //Int32.TryParse(b.ToString(), out int d);


                if (!Int32.TryParse(c.ToString(), out int e) || !(e <= 10 && e >= 1))
                {
                    Console.WriteLine("oops: The second  symbol must be a number");
                    continue;
                }
                coordinates.X = e - 1;
                if ('a' <= b && b <= 'z')
                {
                    coordinates.Y = b - 'a';
                    return coordinates;
                }

                if ('A' <= b && b <= 'Z')
                {
                    coordinates.Y = b - 'A';
                    return coordinates;
                }

                Console.WriteLine("oops: First symbol should be letter from A-Z.");
            }
        }
    }
}

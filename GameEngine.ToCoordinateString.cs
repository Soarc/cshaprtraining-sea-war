using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        /// Finds and returns start and end coordinates of ship at position x, y.
        /// </summary>
        public Ship ToCoordinateString(Coordinates coord)
        {
            char L = (char)(coord.X + 'A');
            char N = (char)(coord.Y + '1');

            return "" + L + N;
        }
    }
}

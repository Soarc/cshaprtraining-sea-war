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
            char L = (char)(X + 'A');
            char N = (char)(Y + '1');
            string Pos = "" + L + N;

            return Pos;
        }
    }
}
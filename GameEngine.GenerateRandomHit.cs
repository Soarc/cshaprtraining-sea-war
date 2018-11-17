using System;

namespace Foundation.Hub256.Seawar
{
    partial class GameEngine
    {
        /// <summary>
        ///GenerateRandomHit
        /// </summary>
        public Coordinates GenerateRandomHit(Random random)
        {
            int a = random.Next(10);
            Coordinates coord=new Coordinates();
            coord.X=a;
            coord.Y=a;
            return  coord;

        }
    }
}
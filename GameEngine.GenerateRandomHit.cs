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
            
            Coordinates coord=new Coordinates();
            coord.X=random.Next(10);
            coord.Y=random.Next(10);
            return  coord;

        }
    }
}
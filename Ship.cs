namespace Foundation.Hub256.Seawar
{
    struct Ship
    {
        public Coordinates Start;
        public Coordinates End;

        public ShipOrientation Orientation
        {
            get
            {
                ShipOrientation o = ShipOrientation.Unknown;
                if (Start.Y == End.Y)
                    o |= ShipOrientation.Horizontal;
                if (Start.X == End.X)
                    o |= ShipOrientation.Vertical;
                return o;
            }
        }

        public ShipSize Size
        {
            get
            {
                if (this.Orientation == ShipOrientation.Vertical)
                    return (ShipSize)(this.End.Y - this.Start.Y + 1);

                return (ShipSize)(this.End.X - this.Start.X + 1);
            }
        }

    }
}
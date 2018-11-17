namespace Foundation.Hub256.Seawar
{

    /// <summary>
    /// Sea field single cell.
    /// </summary>
    enum Cell : int
    {
        /// <summary>
        /// Position is not hitted yet
        /// </summary>
        Empty = 0,
        /// <summary>
        /// if in position is ship
        /// </summary>
        Ship,
        /// <summary>
        /// if in position is hitted ship
        /// </summary>
        HittedShip,
        /// <summary>
        /// if in position is dead ship
        /// </summary>
        DeadShip,
        /// <summary>
        /// if in position is hitted sea
        /// </summary>
        HittedSea,
        /// <summary>
        /// if in position can't be a ship (i.e when ship)
        /// </summary>
        NotShip
    }
}
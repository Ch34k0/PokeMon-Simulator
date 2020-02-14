namespace PokéMon_Simulator.Enumerations
{
    public enum PS_FieldPosition : byte
    {
        /// <summary>
        /// Das PokéMon ist nicht auf dem Feld.
        /// </summary>
        None,

        /// <summary>
        /// Das PokéMon ist auf der linken Seite in einem Double, Triple, Rotation oder MaxRaid Kampf.
        /// </summary>
        Left,

        /// <summary>Das PokéMon ist in der Mitte in einem Single, Triple, oder Rotation Kampf.</summary>
        Center,

        /// <summary>
        /// Das PokéMon ist auf der rechten Seite in einem Double, Triple, Rotation oder MaxRaid Kampf.
        /// </summary>
        Right,

        /// <summary>
        /// Das PokéMon ist auf der ganz linken Seite in einem MaxRaid Kampf.
        /// </summary>
        FarLeft,

        /// <summary>
        /// Das PokéMon ist auf der ganz rechten Seite in einem MaxRaid Kampf.
        /// </summary>
        FarRight,
    }
}

namespace PokéMon_Simulator.Enumerations
{
    public enum PS_GenderRatio : byte
    {
        /// <summary>
        /// Die Spezies ist zu 87.5% männlich und 12.5% weiblich.
        /// </summary>
        M7_F1 = 0x1F,

        /// <summary>
        /// Die Spezies ist zu 75% männlich und 25% weiblich.
        /// </summary>
        M3_F1 = 0x3F,

        /// <summary>
        /// Die Spezies ist zu 50% männlich und 50% weiblich.
        /// </summary>
        M1_F1 = 0x7F,

        /// <summary>
        /// Die Spezies ist zu 25% männlich und 75% weiblich.
        /// </summary>
        M1_F3 = 0xBF,

        /// <summary>
        /// Die Spezies ist zu 0% männlich und 100% weiblich.
        /// </summary>
        M0_F1 = 0xFE,

        /// <summary>
        /// Die Spezies ist geschlechtslos.
        /// </summary>
        M0_F0 = 0xFF,

        /// <summary>
        /// Die Spezies ist zu 100% männlich und 0% weiblich.
        /// </summary>
        M1_F0 = 0x00
    }
}

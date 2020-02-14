namespace PokéMon_Simulator.Enumerations
{
    public enum PS_TurnDecision : byte
    {
        /// <summary>
        /// Das PokéMon hat noch keine Entscheidung getroffen.
        /// </summary>
        None,

        /// <summary>
        /// Das PokéMon hat sich entschieden eine Attacke einzusetzen.
        /// </summary>
        Fight,

        /// <summary>
        /// Das PokéMon hat sich entschieden sich auszutauschen.
        /// </summary>
        SwitchOut
    }
}

namespace DnDLoot
{
    using CommandLine;

    public class Options
    {
        [Option('c', "cr", Required = true, HelpText = "Challenge Rating of the encounter. In a group, select the highest CR.")]
        public int Challenge { get; set; }

        [Option('b', "hoard", Required = false, HelpText = "Denotes if this treasure is a hoarde")]
        public bool Hoard { get; set; }
    }
}

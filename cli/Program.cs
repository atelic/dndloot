namespace DnDLoot
{
    using CommandLine;
    using System;

    using DnDLoot.Domain;

    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
            {
                var treasureCalculator = new TreasureCalculator(o.Hoard);
                Console.WriteLine(treasureCalculator.Get(o.Challenge));
            });
        }
    }
}

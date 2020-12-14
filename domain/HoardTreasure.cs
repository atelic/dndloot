namespace DnDLoot.Domain
{
    class HoardTreasure : ITreasureMap
    {
        public string GetSmall(int roll)
        {
            return "2100cp, 1050sp, & 70gp";
        }

        public string GetMedium(int roll)
        {
            return "700cp, 7000sp, 2100gp, & 105pp";
        }

        public string GetLarge(int roll)
        {
            return "1400gp & 1750pp";
        }

        public string GetExtraLarge(int roll)
        {
            return "42000gp & 28000pp";
        }
    }
}

namespace DnDLoot.Domain
{
    class HoardTreasure : ITreasure
    {
        private Die d6 = new Die(6);

        public string GetSmall(int roll)
        {
            return $"{d6.RollMultiple(6) * 100}cp, {d6.RollMultiple(3) * 100}sp, & {d6.RollMultiple(2) * 10}gp";
        }

        public string GetMedium(int roll)
        {
            return $"{d6.RollMultiple(2) * 100}cp, {d6.RollMultiple(2) * 1000}sp, {d6.RollMultiple(6) * 100}gp, & {d6.RollMultiple(3) * 10}pp";
        }

        public string GetLarge(int roll)
        {
            return $"{d6.RollMultiple(4) * 1000}gp & {d6.RollMultiple(5) * 100}pp";
        }

        public string GetExtraLarge(int roll)
        {
            return $"{d6.RollMultiple(12) * 1000}gp & {d6.RollMultiple(8) * 1000}pp";
        }
    }
}

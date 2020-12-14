namespace DnDLoot.Domain
{
    class IndividualTreasure : ITreasureMap
    {
        private Die d6 = new Die(6);

        public string GetSmall(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 30):
                    return $"{Util.ToNearestFive(d6.RollMultiple(5))}cp";
                case int n when (n > 30 && n <= 60):
                    return $"{Util.ToNearestFive(d6.RollMultiple(4))}sp";
                case int n when (n > 60 && n <= 70):
                    return $"{Util.ToNearestFive(d6.RollMultiple(3))}ep";
                case int n when (n > 70 && n <= 95):
                    return $"{Util.ToNearestFive(d6.RollMultiple(3))}gp";
                case int n when (n > 95):
                    return $"{d6.Roll()}pp";
                default:
                    return "Invalid roll";
            }
        }
        public string GetMedium(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 30):
                    return $"{d6.RollMultiple(4) * 100}cp & {d6.Roll() * 10}ep";
                case int n when (n > 30 && n <= 60):
                    return $"{d6.RollMultiple(6) * 10}sp & {d6.RollMultiple(2) * 10}gp";
                case int n when (n > 60 && n <= 70):
                    return $"{d6.Roll() * 100}ep & {d6.RollMultiple(2) * 10}gp";
                case int n when (n > 70 && n <= 95):
                    return $"{d6.RollMultiple(4) * 10}gp";
                case int n when (n > 95):
                    return $"{d6.RollMultiple(2)}gp & {Util.ToNearestFive(d6.RollMultiple(3))}pp";
                default:
                    return "Invalid roll";
            }
        }

        public string GetLarge(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 20):
                    return $"{d6.RollMultiple(4) * 100}sp & {d6.Roll() * 100}gp";
                case int n when (n > 20 && n <= 35):
                    return $"{d6.Roll() * 100}ep & {d6.Roll() * 100}gp";
                case int n when (n > 35 && n <= 75):
                    return $"{d6.RollMultiple(2) * 100}gp & {d6.Roll() * 10}pp";
                case int n when (n > 75 && n <= 100):
                    return $"{d6.RollMultiple(2) * 100}gp & {d6.RollMultiple(2) * 10}pp";
                default:
                    return "Invalid roll";
            }
        }

        public string GetExtraLarge(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 15):
                    return $"{d6.RollMultiple(2) * 1000}ep & {d6.RollMultiple(8) * 100}gp";
                case int n when (n > 15 && n <= 55):
                    return $"{d6.Roll() * 1000}gp & {d6.Roll() * 100}pp";
                case int n when (n > 55 && n <= 100):
                    return $"{d6.Roll() * 1000}gp & {d6.RollMultiple(2) * 100}pp";
                default:
                    return "Invalid roll";
            }
        }
    }
}

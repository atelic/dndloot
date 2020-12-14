namespace DnDLoot.Domain
{
    class IndividualTreasure : ITreasureMap
    {
        public string GetSmall(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 30):
                    return "15cp";
                case int n when (n > 30 && n <= 60):
                    return "15sp";
                case int n when (n > 60 && n <= 70):
                    return "10ep";
                case int n when (n > 70 && n <= 95):
                    return "10gp";
                case int n when (n > 95):
                    return "10pp";
                default:
                    return "Invalid roll";
            }
        }
        public string GetMedium(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 30):
                    return "1400cp & 35ep";
                case int n when (n > 30 && n <= 60):
                    return "210sp & 70gp";
                case int n when (n > 60 && n <= 70):
                    return "350ep & 70gp";
                case int n when (n > 70 && n <= 95):
                    return "140gp";
                case int n when (n > 95):
                    return "70gp & 10pp";
                default:
                    return "Invalid roll";
            }
        }

        public string GetLarge(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 20):
                    return "1400sp & 35gp";
                case int n when (n > 20 && n <= 35):
                    return "350ep & 350gp";
                case int n when (n > 35 && n <= 75):
                    return "700gp & 34pp";
                case int n when (n > 75 && n <= 100):
                    return "700gp & 50pp";
                default:
                    return "Invalid roll";
            }
        }

        public string GetExtraLarge(int roll)
        {
            switch (roll)
            {
                case int n when (n <= 15):
                    return "7000ep & 2800gp";
                case int n when (n > 15 && n <= 55):
                    return "3500gp & 350pp";
                case int n when (n > 55 && n <= 100):
                    return "3500gp & 700pp";
                default:
                    return "Invalid roll";
            }
        }
    }
}

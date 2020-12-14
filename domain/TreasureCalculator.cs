namespace DnDLoot.Domain
{
    public class TreasureCalculator
    {
        private Die d100 = new Die(100);
        private ITreasure treasure { get; set; }

        public TreasureCalculator(bool isHoard)
        {
            this.treasure = isHoard ? new HoardTreasure() : new IndividualTreasure();
        }

        public string Get(int cr)
        {
            var roll = this.d100.Roll();
            switch (cr)
            {
                case int n when (n <= 4):
                    return this.treasure.GetSmall(roll);
                case int n when (n > 4 && n <= 10):
                    return this.treasure.GetMedium(roll);
                case int n when (n > 10 && n <= 16):
                    return this.treasure.GetLarge(roll);
                case int n when (n > 17):
                    return this.treasure.GetExtraLarge(roll);
                default:
                    return "Invalid Challenge Rating";
            }
        }
    }
}

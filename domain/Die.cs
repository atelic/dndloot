namespace DnDLoot.Domain
{
    using System;
    using System.Linq;

    class Die
    {
        private int sides;
        private Random random = new Random();

        public Die(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            return this.random.Next(1, this.sides);
        }

        public int RollMultiple(int times = 1)
        {
            return Enumerable
                .Range(1, times)
                .Aggregate(
                    0,
                    (acc, x) => acc + this.random.Next(1, this.sides)
                );
        }
    }
}

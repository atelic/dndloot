namespace DnDLoot.Domain
{
    using System;

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
    }
}

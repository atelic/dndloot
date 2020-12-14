namespace DnDLoot.Domain
{
    using System;

    public class Util
    {
        public static int ToNearestFive(int num)
        {
            return 5 * (int)Math.Round(num / 5.0);
        }
    }
}

namespace DnDLoot.Tests.Domain
{
    using System.Collections.Generic;
    using Xunit;

    using DnDLoot.Domain;

    public class ToNearestFiveTest
    {
        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] { 0, 0 },
            new object[] { null, 0 },
            new object[] { 1, 0 },
            new object[] { -1, 0 },
            new object[] { 2, 0 },
            new object[] { -2, 0 },
            new object[] { 5, 5 },
            new object[] { -5, -5 },
            new object[] { 6, 5 },
            new object[] { -6, -5 },
            new object[] { 9, 10 },
            new object[] { -9, -10 },
            new object[] { 14, 15 },
            new object[] { 22, 20 },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void ToNearestFive(int input, int expected)
        {
            var result = Util.ToNearestFive(input);
            Assert.Equal(expected, result);
        }

    }

}

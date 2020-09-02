using Xunit;
using static Xunit.Assert;

namespace Something.Core.Model.Tests
{
    public class SomethingShould
    {
        public SomethingShould()
        {
        }

        [Theory]
        [InlineData("Bilbo Baggins")]
        [InlineData("Fred Bloggs")]
        public void HaveName(string expected)
        {
            var something = new Something() { Name = expected };

            string actual = something.Name;

            Equal(expected, actual);
        }
    }
}
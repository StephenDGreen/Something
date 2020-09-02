using Xunit;
using static Xunit.Assert;

namespace Something.Core.Model.Tests
{
    public class SomethingShould
    {
        public SomethingShould()
        {
        }

        [Fact]
        public void HaveANameProperty()
        {
            //arrange
            string expected = "Bilbo Baggins";
            var something = new Something() { Name = expected };

            //act
            string actual = something.Name;
            //assert
            Equal(expected, actual);
        }
    }
}
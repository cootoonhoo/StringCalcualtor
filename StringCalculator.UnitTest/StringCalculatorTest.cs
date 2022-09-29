using FluentAssertions;
using StringCalculator.Domain;

namespace StringCalculator.UnitTest
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Add_WhenEmptyString_ShouldReturnZero()
        {
            var sut = new StringCalculatorService();
            var result = sut.Add("");

            result.Should().Be(0);
        }
        [Fact]
        public void Add_WhenStringIsNull_ShouldReturnZero()
        {
            var sut = new StringCalculatorService();
            var result = sut.Add(null);

            result.Should().Be(0);
        }

        [Fact]
        public void Add_WhenInputedOnlyOneNumber_ShouldThrowAnArgumentException()
        {
            var sut = new StringCalculatorService();

            Action act = () => sut.Add("2");

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Add_WhenInputedMoreThanOneNumber_ShouldThrowAnArgumentException()
        {
            var sut = new StringCalculatorService();

            Action act = () => sut.Add("2,1,3");

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Add_WhenInputedSequencialCommas_ShouldThrowAnArgumentException()
        {
            var sut = new StringCalculatorService();

            Action act = () => sut.Add("2,,3");

            act.Should().Throw<ArgumentException>();
        }

        [Fact]
        public void Add_WhenInputedANonNumber_ShouldThrowAnArgumentException()
        {
            var sut = new StringCalculatorService();

            Action act = () => sut.Add("A,A");

            act.Should().Throw<ArgumentException>();
        }
        [Fact]
        public void Add_WhenInputedTwoNumber_ShouldReturnSomOfBoth()
        {
            var sut = new StringCalculatorService();
            var result = sut.Add("1,2");

            result.Should().Be(3);
        }
    }
}
using System;
using Xunit;


namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {

            // TODO: Complete Something, if anything
            TacoParser should = new TacoParser();

            var loc = "34.039588,-84.283254,Taco Bell Alpharetta...";

            var actual = should.Parse(loc);



            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta...", "Taco Bell Alpharetta...")]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", "Taco Bell Athens...")]
        [InlineData("34.170417,-84.782808,Taco Bell Cartersvill...", "Taco Bell Cartersvill...")]
        public void ShouldParse(string inputData, string expected)
        {
            var willParse = new TacoParser();

            var actual = willParse.Parse(inputData);

            Assert.Equal(expected, actual.Name);
            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData("4.039588,-84.283254")]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // TODO: Complete Should Fail Parse

            var willParse = new TacoParser();

            var actual = willParse.Parse(str);

            Assert.Null(actual);
            
        }
    }
}

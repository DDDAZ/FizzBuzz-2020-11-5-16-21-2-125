using FizzBuzz;
using Moq;
using Xunit;
using Xunit.Sdk;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        [Fact]
        public void Hello_world_test()
        {
            //given
            Dependency dependency = new Dependency();
            HelloWorld helloWorld = new HelloWorld(dependency);

            //when
            string actual = helloWorld.BeenCalled();

            //then
            Assert.Equal("Leave me alone.", actual);
        }

        [Fact]
        public void Should_be_mocked()
        {
            //given
            var mockDependencu = new Mock<Dependency>();
            mockDependencu.Setup(m => m.Say()).Returns("Hello World");
            HelloWorld helloWorld = new HelloWorld(mockDependencu.Object);

            //when
            string actual = helloWorld.BeenCalled();

            //then
            Assert.Equal("Hello World", actual);
        }
    }

    public class FizzBuzzTest
    {
        [Fact]
        public void Should_given_1_return_1()
        {
            // given
            var expectResult = "1";

            // when
            var say = new Say();
            var actual = say.SayFizzBuzz(1);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void Should_given_3_return_Fizz()
        {
            // given
            var expectResult = "Fizz";

            // when
            var say = new Say();
            var actual = say.SayFizzBuzz(3);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void Should_given_5_return_Buzz()
        {
            // given
            var expectResult = "Buzz";

            // when
            var say = new Say();
            var actual = say.SayFizzBuzz(5);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void Should_given_7_return_Whizz()
        {
            // given
            var expectResult = "Whizz";

            // when
            var say = new Say();
            var actual = say.SayFizzBuzz(7);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void Should_given_15_return_FizzBuzz()
        {
            // given
            var expectResult = "FizzBuzz";

            // when
            var say = new Say();
            var actual = say.SayFizzBuzz(15);

            // then
            Assert.Equal(expectResult, actual);
        }
    }
}
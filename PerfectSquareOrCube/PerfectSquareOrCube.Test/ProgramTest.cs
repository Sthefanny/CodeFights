using Shouldly;
using Xunit;

namespace PerfectSquareOrCube.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturn2ForNumber414()
        {
            var result = Program.PerfectSquareOrCube(414);
            result.ShouldBe(2);
        }

        [Fact]
        public void ShouldReturn1ForNumber64()
        {
            var result = Program.PerfectSquareOrCube(64);
            result.ShouldBe(1);
        }

        [Fact]
        public void ShouldReturn0ForNumber71()
        {
            var result = Program.PerfectSquareOrCube(71);
            result.ShouldBe(0);
        }

        [Fact]
        public void ShouldReturn1ForNumber250()
        {
            var result = Program.PerfectSquareOrCube(250);
            result.ShouldBe(1);
        }

        [Fact]
        public void ShouldReturn1ForNumber10()
        {
            var result = Program.PerfectSquareOrCube(10);
            result.ShouldBe(1);
        }

        [Fact]
        public void ShouldReturn2ForNumber521()
        {
            var result = Program.PerfectSquareOrCube(521);
            result.ShouldBe(2);
        }

        [Fact]
        public void ShouldReturn1ForNumber729()
        {
            var result = Program.PerfectSquareOrCube(729);
            result.ShouldBe(1);
        }
    }
}

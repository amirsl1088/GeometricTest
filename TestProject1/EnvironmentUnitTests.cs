using FluentAssertions;
using GeometricShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class EnvironmentUnitTests
    {
        [Fact]
        public void Computing_computing_environment_square_properly()
        {
            var side = 4;
            var environment = new Environments();
            var expected = 16;

            var actual = environment.Square(side);

            actual.Should().Be(expected);
        }
        [Fact]
        public void Computing_computing_environment_rectangle_properly()
        {
            var length = 7;
            var width = 4;
            var environment = new Environments();
            var expected = 22;

            var actual = environment.Rectangle(length, width);

            actual.Should().Be(expected);
        }
        [Fact]
        public void Computing_computing_environment_triangle_properly()
        {
            var sideA = 4;
            var sideB = 8;
            var sideC = 6;
            var environment = new Environments();
            var expected = 18;

            var actual = environment.Triangle(sideA, sideB, sideC);

            actual.Should().Be(expected);
        }
        [Fact]
        public void Computing_computing_environment_circle_properly()
        {
            var radius = 6;
            var environment = new Environments();
            var expected = 36;

            var actual = environment.Circle(radius);

            actual.Should().Be(expected);
        }
    }
}

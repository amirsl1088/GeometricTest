using FluentAssertions;
using GeometricShapes;
using Xunit;

namespace TestProject1
{
    public class AreaUnitTests
    {
        [Fact]
        public void Computing_computing_area_square_properly()
        {
            var side = 4;
            var area = new Area();
            var expexted = 16;

            var actual = area.Square(side);

            actual.Should().Be(expexted);
        }
        [Fact]
        public void Computing_computing_area_rectangle_properly()
        {
            var length = 5;
            var width = 3;
            var area = new Area();
            var expected = 15;

            var actual = area.Rectangle(length, width);

            actual.Should().Be(expected);

        }
        [Fact]
        public void Computing_computing_area_triangle_properly()
        {
            var bottomSide = 6;
            var height = 8;
            var area = new Area();
            var expexted = 24;

            var actual = area.Triangle(bottomSide,height);

            actual.Should().Be(expexted);
        }
        [Fact]
        public void Computing_computing_area_circle_properly()
        {
            var radius = 5;
            var area = new Area();
            var expected = 75;

            var actual = area.Circle(radius);

            actual.Should().Be(expected);
        }


    }
}
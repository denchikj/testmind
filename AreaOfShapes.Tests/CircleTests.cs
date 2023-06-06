namespace AreaOfShapes.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_WithValidRadius_ReturnValue()
        {
            var circle = new Circle(3);
            var expected = 28.27;
            var actual = circle.GetArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void GetArea_WhenRadiusIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-2));
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShapes.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_WithValidSides_ReturnsValue()
        {
            var triangle = new Triangle(3, 4, 5);
            var expected = 6;
            var actual = triangle.GetArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void IsRightAngled_WhenRightAngledTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            var expected = true;
            var actual = triangle.IsRightAngled();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetArea_WhenOneSideIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, -5));
        }

        [Fact]
        public void GetArea_WhenOneSideIsGreaterThanOthers_ShouldThrowArgumentOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, 8));
        }
    }
}

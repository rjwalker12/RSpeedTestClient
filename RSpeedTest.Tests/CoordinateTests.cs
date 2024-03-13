using RSpeedTest.Models;
using NUnit.Framework;

namespace RSpeedTest.Tests
{
    [TestFixture]
    public class CoordinateTests
    {
        [Test]
        public void GetDistanceTo_should_return_expected_distance()
        {
            var start = new Coordinate(1, 1);
            var end = new Coordinate(5, 5);
            var distance = start.GetDistanceTo(end);
            var expected = 629060.759879635;
            var delta = distance - expected;

            Assert.IsTrue(delta < 1e-8);
        }
    }
}

using NUnit.Framework;

namespace Frends.Community.Echo.Tests
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void ThreeEchos()
        {
            var input = new Parameters
            {
                Message = "foobar",
            };

            var options = new Options
            {
                Amount = 3,
                Delimiter = ", "
            };

            var ret = Echo.ExecuteEcho(input, options, new System.Threading.CancellationToken());

            Assert.That(ret.Replication, Is.EqualTo("foobar, foobar, foobar"));
        }
    }
}

using NUnit.Framework;
using System;

namespace Frends.Community.Echo.Tests
{
    [TestFixture]
    class TestClass
    {
        /// <summary>
        /// You need to Frends.Community.Echo.SetPaswordsEnv.ps1 before running unit test, or some other way set environment variables e.g. with GitHub Secrets.
        /// </summary>
        [Test]
        public void ThreeEchos()
        {
            var input = new Parameters
            {
                Message = Environment.GetEnvironmentVariable("ExampleEnviromentVariable", EnvironmentVariableTarget.User)
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

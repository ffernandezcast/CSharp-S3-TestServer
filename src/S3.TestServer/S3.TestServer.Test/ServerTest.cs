using System;
using FluentAssert;
using Xunit;

namespace S3.TestServer.Test
{
    public class ServerTest
    {
        [Fact]
        public void return_httptestserver_instance()
        {
            var httpServer = new HttpTestServer();

            httpServer.ShouldNotBeNull();
        }
    }
}

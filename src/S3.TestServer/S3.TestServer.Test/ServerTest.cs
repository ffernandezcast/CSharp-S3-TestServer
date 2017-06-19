using System;
using FluentAssert;
using Xunit;

namespace S3.TestServer.Test
{
    public class ServerTest
    {
        [Fact]
        public void Create_Httptestserver_WithNull_Parameter_Return_ArgumentNullException()
        {
            Action HttpServerAction = () => new HttpTestServer(null);

            AssertExtensions.ShouldThrow<ArgumentNullException>(HttpServerAction);
        }

        [Fact]
        public void Create_Httptestserver_Return_Instance()
        {
            var httpServer = new HttpTestServer();

            httpServer.ShouldNotBeNull();
            httpServer.ShouldBeOfType<HttpTestServer>();
        }
    }
}

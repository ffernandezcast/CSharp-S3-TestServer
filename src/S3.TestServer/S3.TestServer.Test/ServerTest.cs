using System;
using FluentAssert;
using Xunit;

namespace S3.TestServer.Test
{
    public class ServerTest
    {
        [Fact]
        public void HttpTestServer_Create_WithNull_Parameter_Return_ArgumentNullException()
        {
            Action HttpServerAction = () => new HttpTestServer(null);

            AssertExtensions.ShouldThrow<ArgumentNullException>(HttpServerAction);
        }

        [Fact]
        public void HttpTestServer_Create_With_Default_Values_Return_Instance()
        {
            var httpServer = new HttpTestServer();

            httpServer.ShouldNotBeNull();
            httpServer.ShouldBeOfType<HttpTestServer>();
        }

        [Fact]
        public void HttpTestServer_Create_Instance_Return_LocalHost()
        {
            var httpServer = new HttpTestServer();

            httpServer.HostUrl.Host.ShouldBeEqualTo("localhost");
        }
    }
}

using System;

namespace S3.TestServer
{
    public interface IHttpTestServer
    {
        Uri HostUrl { get; }
        int Port { get; }
        void Start();
        void Stop();
    }
}
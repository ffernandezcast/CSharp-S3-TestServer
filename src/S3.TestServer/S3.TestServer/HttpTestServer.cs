using System;
using System.Net;
using System.Net.Sockets;
using CuttingEdge.Conditions;

namespace S3.TestServer
{
    public class HttpTestServer: IHttpTestServer
    {
        public Uri HostUrl { get; private set; }
        public int Port { get; private set; }

        private readonly HttpListener httpListener;

        public HttpTestServer(HttpListener httpListener)
        {
            Condition.Requires(httpListener, nameof(httpListener)).IsNotNull();
            this.httpListener = httpListener;
            SetLocalhostAddressAndPort();
            httpListener.Prefixes.Add(this.HostUrl.ToString());
        }

        public HttpTestServer() : this(new HttpListener())
        {
        }

        public void Start() => this.httpListener.Start();

        public void Stop() => this.httpListener.Stop();

        private void SetLocalhostAddressAndPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            this.Port = ((IPEndPoint) listener.LocalEndpoint).Port;
            listener.Stop();

            this.HostUrl = new Uri($"http://localhost:{this.Port}/");
        }
    }
}

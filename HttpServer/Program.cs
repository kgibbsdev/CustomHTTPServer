
using System.Net;
using System.Net.Sockets;

namespace HttpServer;

class Program
{
	static void Main(string[] args)
	{
		Server server = new Server(new TcpListener(IPAddress.Any, 4221));
		server.Start();

		while (true)
		{
			var connection = server.AcceptSocket(); // wait for client
			Thread thread = new Thread(() => server.HandleConnection(connection));
			thread.Start();
		}
	}
}
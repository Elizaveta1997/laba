using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HelloWorldWebServer
{
	/// <summary>
	/// Http сервер, который может обслуживать одновременно максимум одного клиента и на все запросы отвечает Hello, World!
	/// </summary>
	class Program
	{
		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		/// <param name="args">Аргументы командной строки.</param>
	
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your ip:");
			var ip = Console.ReadLine();
			Console.WriteLine("Enter your port:");
			var port = Convert.ToInt32(Console.ReadLine());

			new Server.Server().Start(ip,port);
			Console.ReadKey();

		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OneMessenger.Server
{
	class Program
	{

		// ReSharper disable once InconsistentNaming
		public static OneMessengerService _sever;
		static void Main(string[] args)
		{
			_sever = new OneMessengerService();
			using (ServiceHost host=new ServiceHost(_sever))
			{
				host.Open();
				Console.WriteLine("Server started");
				Console.ReadLine();
			}
		}
	}
}

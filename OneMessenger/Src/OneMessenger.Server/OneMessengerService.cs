using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using OneMessenger.Core;

namespace OneMessenger.Server
{
	[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,InstanceContextMode = InstanceContextMode.Single)]
	public class OneMessengerService : IOneMessengerService
	{
		public ConcurrentDictionary<string, ConnectedClient> ConnectedClients=new ConcurrentDictionary<string, ConnectedClient>();
		public int Login(string username)
		{

			foreach (var client in ConnectedClients)
			{
				if (client.Key.ToLower()==username.ToLower())
				{
					return 1;
				}
			}
			var establishedUserConnection = OperationContext.Current.GetCallbackChannel<IClient>();
			ConnectedClient newClient=new ConnectedClient();
			newClient.Connection = establishedUserConnection;
			newClient.Username = username;
			ConnectedClients.TryAdd(username, newClient);
			return 0;
		}

		public void SendMessageToAll(string username,string message)
		{
			foreach (var client in ConnectedClients)
			{
				if (client.Key.ToLower() != username.ToLower())
				{
					client.Value.Connection.GetMessage(username,message);
				}
			}
		}
	}
}

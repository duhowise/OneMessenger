using System;
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
		
	}
}

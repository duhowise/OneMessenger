using System.ServiceModel;
using OneMessenger.Core;

namespace OneMessenger.Client
{
	[CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class ClientCallback:IClient
	{
		public void PlaceHolder()
		{
			throw new System.NotImplementedException();
		}
	}
}
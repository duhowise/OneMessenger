using System.ServiceModel;

namespace OneMessenger.Core
{
	[ServiceContract]
	public interface IClient
	{
		[OperationContract]
		void GetMessage(string username,string message);
	}
}
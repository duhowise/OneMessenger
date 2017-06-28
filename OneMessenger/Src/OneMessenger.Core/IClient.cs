using System.ServiceModel;

namespace OneMessenger.Core
{
	public interface IClient
	{
		[OperationContract]
		void PlaceHolder();
	}
}
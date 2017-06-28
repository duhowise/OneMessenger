 using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OneMessenger.Core;

namespace OneMessenger.Client
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// ReSharper disable once InconsistentNaming
		public static IOneMessengerService _server;

		public MainWindow()
		{
			InitializeComponent();
			var channelFactory = new DuplexChannelFactory<IOneMessengerService>(new ClientCallback(), "OneMessengerServiceEndpoint");
			try
			{
				_server = channelFactory.CreateChannel();

			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message,"Sever not Runing");
			}
		}

		private void Test_Click(object sender, RoutedEventArgs e)
		{
			_server.Test("Hello World");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace QryptIdApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScanPage : ContentPage
	{
		public ScanPage()
		{
			InitializeComponent();
			Button2.IsVisible = false;
			Button1.IsVisible = true;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			var scan = new ZXingScannerPage();
			await Navigation.PushAsync(scan);
			scan.OnScanResult += (result) =>
			  {
				  Device.BeginInvokeOnMainThread(async () =>
				  {
					  await Navigation.PopAsync();
					  Button2.IsVisible = true;
					  Button1.IsVisible = false;
					  mycode.Text = result.Text;
				  });
			  };
		}

		private async void Button2_Clicked(object sender, EventArgs e)
		{
			var scan = new ZXingScannerPage();
			await Navigation.PushAsync(scan);
			scan.OnScanResult += (result) =>
			{
				Device.BeginInvokeOnMainThread(async () =>
				{
					await Navigation.PopAsync();
					mycode.Text = result.Text;
				});
			};
		}
	}
}
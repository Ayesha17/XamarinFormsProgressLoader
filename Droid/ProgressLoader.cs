using System;
using AndroidHUD;
using ProgressSample.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProgressLoader))]
namespace ProgressSample.Droid
{
	public class ProgressLoader : IProgressInterface
	{
		public ProgressLoader()
		{
		}

		public void Hide()
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				AndHUD.Shared.Dismiss();
			});
		}

		public void Show(string title = "Loading")
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				AndHUD.Shared.Show(Forms.Context, status: title, maskType: MaskType.Black);
			});
		}
	}
}

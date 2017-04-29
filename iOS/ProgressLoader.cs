using System;
using BigTed;
using ProgressSample.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProgressLoader))]
namespace ProgressSample.iOS
{
	public class ProgressLoader : IProgressInterface
	{
		public ProgressLoader()
		{
		}

		public void Hide()
		{
			BTProgressHUD.Dismiss();
		}

		public void Show(string title = "Loading")
		{
			BTProgressHUD.Show(title, maskType: ProgressHUD.MaskType.Black);
		}
	}
}

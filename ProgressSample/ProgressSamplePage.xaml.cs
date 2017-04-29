using Xamarin.Forms;

namespace ProgressSample
{
	public partial class ProgressSamplePage : BasePage
	{
		public ProgressSamplePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			Show();
			Hide();
		}
	}
}

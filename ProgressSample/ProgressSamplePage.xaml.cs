namespace ProgressSample
{
    public partial class ProgressSamplePage : BasePage
    {
        public ProgressSamplePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ons the appearing.
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Show();
            Hide();
        }
    }
}

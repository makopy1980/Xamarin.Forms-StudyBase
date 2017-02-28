using Xamarin.Forms;
using Sample.Pages;
using Util;

namespace XamarinFormsStudyBase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabRootPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Trace.WriteMethod();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

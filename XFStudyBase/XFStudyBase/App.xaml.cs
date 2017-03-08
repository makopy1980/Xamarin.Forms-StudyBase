using Xamarin.Forms;
using XFStudyBase.Pages.Tab;
using XFStudyBase.Util;

namespace XFStudyBase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SBTabRootPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Trace.WriteMethod();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Trace.WriteMethod();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Trace.WriteMethod();
        }
    }
}

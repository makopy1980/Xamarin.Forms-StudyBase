using Xamarin.Forms;
using Sample.Pages;
using Util;

namespace XamarinFormsStudyBase
{
    public partial class App : Application
    {
        public App()
        {

            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            InitializeComponent();

            MainPage = new TabRootPage();
        }

        protected override void OnStart()
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // ライフサイクルメソッド調査
            Trace.WriteMethod();

            // Handle when your app resumes
        }
    }
}

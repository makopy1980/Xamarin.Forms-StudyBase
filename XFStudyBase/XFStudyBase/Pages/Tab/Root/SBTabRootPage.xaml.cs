using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFStudyBase.Util;

namespace XFStudyBase.Pages.Tab
{
    public partial class SBTabRootPage : TabbedPage
    {
        public SBTabRootPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Trace.WriteMethod();

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            Trace.WriteMethod();

            base.OnDisappearing();
        }

        protected override bool OnBackButtonPressed()
        {
            // Backキー無効
            return true;
        }
    }
}

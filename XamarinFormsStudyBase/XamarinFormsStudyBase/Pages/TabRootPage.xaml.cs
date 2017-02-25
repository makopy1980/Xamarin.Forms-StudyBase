using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Sample.ViewModels;

namespace Sample.Pages
{
    public partial class TabRootPage : TabbedPage
    {
        public TabRootPage()
        {
            InitializeComponent();

            this.BindingContext = new TabRootViewModel();

            // Tabページを設定する
            setTabPages();
        }

        // Tabページを設定する
        private void setTabPages()
        {
            var viewModel = this.BindingContext as TabRootViewModel;

            foreach (var page in viewModel.TabPageList)
            {
                this.Children.Add(page);
            }
        }
    }
}

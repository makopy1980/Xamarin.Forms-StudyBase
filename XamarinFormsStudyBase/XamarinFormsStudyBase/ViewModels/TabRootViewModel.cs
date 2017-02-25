using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sample.ViewModels
{
    /// <summary>
    /// TabRootPageのViewModel
    /// </summary>
    public class TabRootViewModel : BindableBase
    {
        private List<Page> tabPageList;
        /// <summary>
        /// TabbedPageのPageリスト
        /// </summary>
        public List<Page> TabPageList
        {
            get { return this.tabPageList; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TabRootViewModel()
        {
            // TabbedPageのPageリストを設定
            setTabPageListIfNeeded();
        }

        // ----- Private Methods ----- //

        // TabbedPageのPageリストを設定
        private void setTabPageListIfNeeded()
        {
            if (tabPageList == null)
            {
                tabPageList = GetTabPageList();
            }
        }

        // TabbedPageのPageリストを取得
        private List<Page> GetTabPageList()
        {
            var pages = new List<Page>();

            pages.Add(getFirstPage());
            pages.Add(getSecondPage());
            pages.Add(getThirdPage());

            return pages;
        }

        // FirstPageを取得
        private Page getFirstPage()
        {
            // TODO: FirstPageの実装をここから切り離す

            var page = new ContentPage()
            {
                Title = "First",
                // TODO: iOS用のTabBarアイコン画像
                //Icon = "xxx.png",
                Content = new Label
                {
                    Text = "FirstPage",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                },
            };

            return page;
        }

        // SecondPageを取得
        private Page getSecondPage()
        {
            // TODO: SecondPageの実装をここから切り離す

            var page = new ContentPage()
            {
                Title = "Second",
                // TODO: iOS用のTabBarアイコン画像
                //Icon = "xxx.png",
                Content = new Label
                {
                    Text = "SecondPage",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                },
            };

            return page;
        }

        // ThirdPageを取得
        private Page getThirdPage()
        {
            // TODO: ThirdPageの実装をここから切り離す
            var page = new ContentPage()
            {
                Title = "Third",
                // TODO: iOS用のTabBarアイコン画像
                //Icon = "xxx.png",
                Content = new Label
                {
                    Text = "ThirdPage",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                },
            };

            return page;
        }
    }
}

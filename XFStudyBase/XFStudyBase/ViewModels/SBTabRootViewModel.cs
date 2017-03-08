using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XFStudyBase.Base;
using XFStudyBase.Pages.Tab;

namespace XFStudyBase.ViewModels
{
    /// <summary>
    /// TabRootPageのViewModel
    /// </summary>
    public class SBTabRootViewModel : BindableBase
    {

        // TabbedPageのTitleリスト
        private List<string> titles;
        /// <summary>
        /// TabbedPageのTitleリスト
        /// </summary>
        public List<string> Titles
        {
            get
            {
                // TabbedPageのタイトルを設定
                setTabTitlesIfNeeded();
                return this.titles;
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SBTabRootViewModel()
        {
        }

        // ----- Private Methods ----- //

        // TabbedPageのタイトルを取得
        private List<string> GetTabTitles()
        {
            var titleList = new List<string>();

            titleList.Add("First");
            titleList.Add("Second");
            titleList.Add("Third");

            return titleList;
        }

        // TabbedPageのタイトルを設定
        private void setTabTitlesIfNeeded()
        {
            if (titles == null || !titles.Any())
            {
                titles = GetTabTitles();
            }
        }
    }
}


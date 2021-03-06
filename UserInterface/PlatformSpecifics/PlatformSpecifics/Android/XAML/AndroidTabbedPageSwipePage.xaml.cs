using System;
using System.Windows.Input;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public partial class AndroidTabbedPageSwipePage : Xamarin.Forms.TabbedPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public AndroidTabbedPageSwipePage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;
        }

        void OnSwipePagingButtonClicked(object sender, EventArgs e)
        {
            On<Android>().SetIsSwipePagingEnabled(!On<Android>().IsSwipePagingEnabled());
        }

        void OnSmoothScrollButtonClicked(object sender, EventArgs e)
        {
            On<Android>().SetIsSmoothScrollEnabled(!On<Android>().IsSmoothScrollEnabled());
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}

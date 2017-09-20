using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XGH
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();

            BtnA.Clicked += async (sender, e) =>
            {
                await App.MasterDetail.Detail.Navigation.PushAsync(new P1());
                App.MasterDetail.IsPresented = false;
            };

            BtnB.Clicked += async (sender, e) =>
            {
                await App.MasterDetail.Detail.Navigation.PushAsync(new P2());
                App.MasterDetail.IsPresented = false;

            };

            BtnC.Clicked += async (sender, e) =>
            {
                await App.MasterDetail.Detail.Navigation.PushAsync(new P3());
                App.MasterDetail.IsPresented = false;
            };
        }
	}
}
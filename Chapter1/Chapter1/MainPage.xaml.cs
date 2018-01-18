using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnNew.Clicked += BtnNew_Clicked;

            navDaftarMenu.Clicked += NavDaftarMenu_Clicked;
            navSimpleBinding.Clicked += NavSimpleBinding_Clicked;
		}

        private async void NavSimpleBinding_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingListString());
        }

        private async void NavDaftarMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BindingToDataModel());
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih tombol Save", "OK");
        }

        private void BtnNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingToDataModel());
        }
    }
}

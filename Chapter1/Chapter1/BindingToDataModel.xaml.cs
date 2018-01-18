using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Chapter1.Models;
using Chapter1.ViewModels;

namespace Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingToDataModel : ContentPage
    {
        public BindingToDataModel()
        {
            InitializeComponent();
            BindingContext = new DaftarMenuViewModel();

            btnClose.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PopModalAsync();
            };
        }

       

        private void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DaftarMenu daftarMenu = (DaftarMenu)e.Item;
            DisplayAlert("Keterangan", "Anda memilih menu " + daftarMenu.Kode + " - " + daftarMenu.Nama + " - " +
                "Status "+daftarMenu.Status, "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}
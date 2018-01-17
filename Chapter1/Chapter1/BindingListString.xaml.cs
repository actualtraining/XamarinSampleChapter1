using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();

            var menu = new List<string> { "Ayam Goreng","Lasagna","Sate Kambing","Nasi Goreng",
            "Nasi Uduk"};
            myList.ItemsSource = menu;

            myList.ItemTapped += MyList_ItemTapped;
        }

        private void MyList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih data: " + e.Item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}
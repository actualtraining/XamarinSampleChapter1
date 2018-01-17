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
	public partial class SampleControl : ContentPage
	{
		public SampleControl ()
		{
			InitializeComponent ();

            var options = new List<string> { "Indonesian Food","Chinese Food",
            "Western Food","Japanese Food","Thai Food"};
            foreach(var op in options)
            {
                myPicker.Items.Add(op);
            }

            myPicker.SelectedIndexChanged += MyPicker_SelectedIndexChanged;
            myDatePicker.DateSelected += MyDatePicker_DateSelected;
            myTimePicker.PropertyChanged += MyTimePicker_PropertyChanged;
            //myStepper.ValueChanged += MyStepper_ValueChanged;
		}

        /*private void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblKeterangan.Text = myStepper.Value.ToString();
        }*/

        private void MyTimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                DisplayAlert("Keterangan", "Waktu :" + myTimePicker.Time.ToString(), "OK");
            }
        }

        private void MyDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //DisplayAlert("Keterangan", e.NewDate.ToShortDateString(), "OK");
            DisplayAlert("Keterangan", myDatePicker.Date.ToLongDateString(), "OK");
        }

        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAlert("Pilihan", "Anda memilih :" + myPicker.Items[myPicker.SelectedIndex], "OK");
        }
    }
}
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
            mySlider.ValueChanged += MySlider_ValueChanged;
            mySwitch.Toggled += MySwitch_Toggled;
            mySwitch2.Toggled += MySwitch_Toggled;
        }

        private void MySwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if(sender == mySwitch)
            {
                DisplayAlert("MySwitch", e.Value.ToString(), "OK");
            }
            else
            {
                DisplayAlert("MySwitch 2", e.Value.ToString(), "OK");
            }
        }

        private void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
            var newStep = Math.Round(e.NewValue / 1.0);
            mySlider.Value = newStep * 1.0;
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
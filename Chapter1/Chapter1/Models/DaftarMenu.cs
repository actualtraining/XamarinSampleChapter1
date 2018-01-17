using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter1.Models
{
    public class DaftarMenu : BindableObject
    {
        public string Kode { get; set; }
        public string Nama { get; set; }
        public string Keterangan { get; set; }
        public string Photo { get; set; }
        public int Harga { get; set; }

        public DaftarMenu()
        {
            BeliCommand = new Command(BeliMethod);
        }

        private void BeliMethod()
        {
            MessagingCenter.Send<DaftarMenu>(this, "BeliMethod");
        }

        private Command beliCommand;
        public Command BeliCommand
        {
            get { return beliCommand; }
            set { beliCommand = value; OnPropertyChanged("BeliCommand"); }
        }

    }
}

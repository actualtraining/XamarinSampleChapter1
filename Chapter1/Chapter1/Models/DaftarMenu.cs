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

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged("Status"); }
        }

        private Color statusWarna;
        public Color StatusWarna
        {
            get { return statusWarna; }
            set { statusWarna = value; OnPropertyChanged("StatusWarna"); }
        }

        public DaftarMenu()
        {
            BeliCommand = new Command(BeliMethod);
            DeleteCommand = new Command(DeleteMethod);
        }

       

        #region Buat Command
        private void BeliMethod()
        {
            MessagingCenter.Send<DaftarMenu>(this, "BeliMethod");
        }

        private void DeleteMethod(object obj)
        {
            MessagingCenter.Send<DaftarMenu>(this, "DeleteMethod");
        }

        private Command beliCommand;
        public Command BeliCommand
        {
            get { return beliCommand; }
            set { beliCommand = value; OnPropertyChanged("BeliCommand"); }
        }

        private Command deleteCommand;
        public Command DeleteCommand
        {
            get { return deleteCommand; }
            set { deleteCommand = value; OnPropertyChanged("DeleteCommand"); }
        }
        #endregion




    }
}

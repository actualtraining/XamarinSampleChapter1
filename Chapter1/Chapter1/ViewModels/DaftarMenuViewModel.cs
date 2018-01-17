using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Chapter1.Models;


namespace Chapter1.ViewModels
{
    public class DaftarMenuViewModel : BindableObject
    {
        private List<DaftarMenu> listDaftarMenu;
        public List<DaftarMenu> ListDaftarMenu
        {
            get { return listDaftarMenu; }
            set { listDaftarMenu = value; OnPropertyChanged("ListDaftarMenu"); }
        }

        public DaftarMenuViewModel()
        {
            ListDaftarMenu = new List<DaftarMenu>
            {
                new DaftarMenu {Kode="SS11", Nama="Sate Klathak",Keterangan="Sate khas jogja ditusuk besi",
                Photo="sate.jpg",Harga=30000},
                new DaftarMenu {Kode="GG12", Nama="Gudeg Yu Djum",Keterangan="Gudeg paling terkenal di jogja",
                Photo="gudeg.png",Harga=35000},
                new DaftarMenu {Kode="NN22", Nama="Nasi Goreng Kambing",Keterangan="Nasi goreng dengan daging kambing masak rempah",
                Photo="nasgor.jpg",Harga=30000}
            };
        }

       
    }
}

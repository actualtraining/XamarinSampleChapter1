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
                new DaftarMenu {Nama="Sate Klathak",Keterangan="Sate khas jogja ditusuk besi"},
                new DaftarMenu {Nama="Gudeg Yu Djum",Keterangan="Gudeg paling terkenal di jogja"},
                new DaftarMenu {Nama="Nasi Goreng Kambing",Keterangan="Nasi goreng dengan daging kambing masak rempah"}
            };
        }

       
    }
}

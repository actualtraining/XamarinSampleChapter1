using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Chapter1.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace Chapter1.ViewModels
{
    public class DaftarMenuViewModel : BindableObject
    {
        private ObservableCollection<DaftarMenu> listDaftarMenu;
        public ObservableCollection<DaftarMenu> ListDaftarMenu
        {
            get { return listDaftarMenu; }
            set { listDaftarMenu = value; OnPropertyChanged("ListDaftarMenu"); }
        }

        public DaftarMenuViewModel()
        {
            ListDaftarMenu = new ObservableCollection<DaftarMenu>
            {
                new DaftarMenu {Kode="SS11", Nama="Sate Klathak",Keterangan="Sate khas jogja ditusuk besi",
                Photo="sate.jpg",Harga=30000,Status="tersedia",StatusWarna=Color.Green},
                new DaftarMenu {Kode="GG12", Nama="Gudeg Yu Djum",Keterangan="Gudeg paling terkenal di jogja",
                Photo="gudeg.png",Status="tersedia", Harga=35000,StatusWarna=Color.Green},
                new DaftarMenu {Kode="NN22", Status="tersedia", Nama="Nasi Goreng Kambing",Keterangan="Nasi goreng dengan daging kambing masak rempah",
                Photo="nasgor.jpg",Harga=30000,StatusWarna=Color.Green}
            };

            MessagingCenter.Subscribe<DaftarMenu>(this, "BeliMethod", BeliMethod);
            MessagingCenter.Subscribe<DaftarMenu>(this, "DeleteMethod", DeleteMethod);
        }

        private void DeleteMethod(DaftarMenu obj)
        {
            var result = (from m in ListDaftarMenu.ToList()
                          where m.Kode == obj.Kode
                          select m).SingleOrDefault();

            ListDaftarMenu.Remove(result);         
        }

        private void BeliMethod(DaftarMenu obj)
        {
            obj.Status = "dibeli";
            obj.StatusWarna = Color.Red;
        }
    }
}

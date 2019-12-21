using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselandTabbed.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabSayfasi : TabbedPage // Tab Sayfası MultiPage<Page> den türetilmiştir. Ayrıca,
                                                 // MultiPage<Page> de IList<T> Children metodu vardır kullanmamız gereken
                                                 // Children metodu olacaktır. yani tabbed page'e sayfalar eklerken
                                                 // Children.Add(new Sayfa()) diyerek ekleyebiliriz bu Carousel için aynıdır.
                                                 // Carousel Sadece Kaydırma işleminde tabbed page den farklıdır.
    {
        public TabSayfasi()
        {
            InitializeComponent();
            Children.Add(new Anasayfa());
            Children.Add(new Iletisim());
            Children.Add(new Hakkimizda());
            // Sayfaların Title ' ını boş bırakma yoksa Tab sayfalarının adları boş gelir.

        }
    }
}
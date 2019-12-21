
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarouselandTabbed.Views
{
    public class MastersPage : MasterDetailPage // MasterDetail Pageden Türetdik.
    {
        public MastersPage()
        {
            Master = new MasterMenu(); // Master denilen Menüdür.
            Detail = new TabSayfasi(); // Detail ise İç taraftaki sayfalar..
            IconImageSource = "menu.png";
        }
    }
}

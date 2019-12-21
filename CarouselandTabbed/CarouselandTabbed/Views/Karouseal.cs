using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarouselandTabbed.Views
{
    public class Karouseal : CarouselPage
    {
        public Karouseal() // Kaydırma dışında Tabbed ile aynıdır.
        {
            Children.Add(new Anasayfa());
            Children.Add(new Hakkimizda());
            Children.Add(new Iletisim());
        }
    }
}

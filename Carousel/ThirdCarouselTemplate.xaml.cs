using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Carousel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ThirdCarouselTemplate : Page
    {

        public ThirdCarouselTemplate()
        {
            this.InitializeComponent();
            WhichNowPlay();
        }
        private int i = 0;
        string[] songs = { "first", "second", "third", "forth", "fifth" };
        private void DynamicCarousel_Click(object sender, RoutedEventArgs e)
        {
            WhichNowPlay();
            MyCanvas.RenderTransform = new CompositeTransform { TranslateX = -800 * i };
            i++;
            if (i == 5) i = 0;
        }
        
        
        private void WhichNowPlay()
        {
            foreach (string x in songs)
            {
                var song = (MediaElement)FindName(x);
                song.Volume = 0;
                song.Pause();
                song.Opacity = 0;
            }
            switch (i)
            {
                case 0:
                    first.Volume = 1;
                    first.Play();
                    first.Opacity = 1;
                    break;
                case 1:
                    second.Volume = 1;
                    second.Play();
                    second.Opacity = 1;
                    break;
                case 2:
                    third.Volume = 1;
                    third.Play();
                    third.Opacity = 1;
                    break;
                case 3:
                    forth.Volume = 1;
                    forth.Play();
                    forth.Opacity = 1;
                    break;
                case 4:
                    fifth.Volume = 1;
                    fifth.Play();
                    fifth.Opacity = 1;
                    break;
            }
        }
    }
}

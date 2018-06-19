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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Carousel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            CarouselAppFrame.Navigate(typeof(FirstCarousel));
            FirstCarouselTemplate.IsEnabled = false;
        }
        private void FirstCarouselTemplate_Click(object sender, RoutedEventArgs e)
        {
            CarouselAppFrame.Navigate(typeof(FirstCarousel));
            FirstCarouselTemplate.IsEnabled = false;
            SecondCarouselTemplate.IsEnabled = true;
            ThirdCarouselTemplate.IsEnabled = true;
        }

        private void SecondCarouselTemplate_Click(object sender, RoutedEventArgs e)
        {
            CarouselAppFrame.Navigate(typeof(SecondCarousel));
            FirstCarouselTemplate.IsEnabled = true;
            SecondCarouselTemplate.IsEnabled = false;
            ThirdCarouselTemplate.IsEnabled = true;
        }
        private void ThirdCarouselTemplate_Click(object sender, RoutedEventArgs e)
        {
            CarouselAppFrame.Navigate(typeof(ThirdCarouselTemplate));
            FirstCarouselTemplate.IsEnabled = true;
            SecondCarouselTemplate.IsEnabled = true;
            ThirdCarouselTemplate.IsEnabled = false;
        }
    }
}

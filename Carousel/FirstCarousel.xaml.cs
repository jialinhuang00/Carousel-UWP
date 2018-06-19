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
using Carousel.FitstCarouselComponents;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Carousel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FirstCarousel : Page
    {
        public FirstCarousel()
        {
            InitializeComponent();
            VideoFrame.Navigate(typeof(One));
            NextButton.IsEnabled = true;
            BackButton.IsEnabled = false;

        }
        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            VideoFrame.Navigate(typeof(Two));
            BackButton.IsEnabled = true;
            NextButton.IsEnabled = false;
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            VideoFrame.Navigate(typeof(One));
            NextButton.IsEnabled = true;
            BackButton.IsEnabled = false;

        }
        private void VideoFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}

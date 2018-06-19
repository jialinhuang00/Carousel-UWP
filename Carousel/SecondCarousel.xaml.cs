using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Carousel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondCarousel : Page
    {
        public SecondCarousel()
        {
            this.InitializeComponent();
        }
        private void PauseOrPlayControl()
        {
            if (VideoPlace.CurrentState == MediaElementState.Paused)
            {
                VideoPlace.Play();
                BigControlPlayOrPause.Content = "\uE103";
                PauseOrPlay.Content = "\uE103";
                VideoPlace.Width = 800;
                ControlPanel.Width = 800;
                VideoCut.Visibility = Visibility.Collapsed;
            }
            else
            {
                VideoPlace.Pause();
                BigControlPlayOrPause.Content = "\uE102";
                PauseOrPlay.Content = "\uE102";
                VideoPlace.Width = 400;
                ControlPanel.Width = 400;
                VideoCut.Visibility = Visibility.Visible;
            }
        }
        private int index = 1;
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            VideoPlace.Stop();
        }
        private void PlayFirst(object sender, RoutedEventArgs e)
        {
            VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/first.mp4");
            VideoCut.Source = new BitmapImage(new Uri("ms-appx:///Assets/first.jpg"));
            index = 1;
        }
        private void PlaySec(object sender, RoutedEventArgs e)
        {
            VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/second.mp4");
            VideoCut.Source = new BitmapImage(new Uri("ms-appx:///Assets/second.jpg"));
            index = 2;
        }
        private void PlayThird(object sender, RoutedEventArgs e)
        {
            VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/third.mp4");
            VideoCut.Source = new BitmapImage(new Uri("ms-appx:///Assets/third.jpg"));
            index = 3;
        }
        private void PlayForth(object sender, RoutedEventArgs e)
        {
            VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/forth.mp4");
            VideoCut.Source = new BitmapImage(new Uri("ms-appx:///Assets/forth.jpg"));
            index = 4;
        }
        private void PlayFifth(object sender, RoutedEventArgs e)
        {
            VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/fifth.mp4");
            VideoCut.Source = new BitmapImage(new Uri("ms-appx:///Assets/fifth.jpg"));
            index = 5;
        }

        private void BigControlPlayOrPause_Click(object sender, RoutedEventArgs e)
        {
            PauseOrPlayControl();
        }

        private void PauseOrPlay_Click(object sender, RoutedEventArgs e)
        {
            PauseOrPlayControl();
        }

        private void MediaPanel_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            PauseOrPlayControl();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

            switch (index)
            {
                case 1:
                    index = 2;
                    VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/second.mp4");
                    break;
                case 2:
                    index = 3;
                    VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/third.mp4");
                    break;
                case 3:
                    index = 4;
                    VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/forth.mp4");
                    break;
                case 4:
                    index = 5;
                    VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/fifth.mp4");
                    break;
                case 5:
                    index = 1;
                    VideoPlace.Source = new Uri(this.BaseUri, "/Assets/Video/first.mp4");
                    break;
            }
        }
        private void MediaPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            BigControlPlayOrPause.Opacity = 1;
            ControlPanel.Opacity = 1;
        }

        private void MediaPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            BigControlPlayOrPause.Opacity = 0;
            ControlPanel.Opacity = 0;

        }
    }
}


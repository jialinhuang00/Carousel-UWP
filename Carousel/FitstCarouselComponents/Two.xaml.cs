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

namespace Carousel.FitstCarouselComponents
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Two : Page
    {
        public Two()
        {
            this.InitializeComponent();
        }
        private void PauseOrPlay_Click(object sender, RoutedEventArgs e)
        {
            PauseOrPlayControl();
        }
        private void PauseOrPlayControl()
        {
            if (MyVideo.CurrentState == MediaElementState.Paused)
            {
                MyVideo.Play();
                PauseOrPlay.Content = "\uE103";
                BigControlPlayOrPause.Content = "\uE103";
            }
            else
            {
                MyVideo.Pause();
                PauseOrPlay.Content = "\uE102";
                BigControlPlayOrPause.Content = "\uE102";
            }
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MyVideo.Stop();
        }

        private void MediaPanel_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ControlPanel.Opacity = 1;
            BigControlPlayOrPause.Opacity = 1;
        }

        private void MediaPanel_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ControlPanel.Opacity = 0;
            BigControlPlayOrPause.Opacity = 0;
        }

        private void MyVideo_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            PauseOrPlayControl();
        }

        private void BigControlPlayOrPause_Click(object sender, RoutedEventArgs e)
        {
            PauseOrPlayControl();
        }
    }
}

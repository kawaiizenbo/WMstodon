﻿using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UniversalFedi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImageViewerPage : Page
    {
        public ImageViewerPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Attachment attachment = (Attachment)e.Parameter;

            BitmapImage image = new BitmapImage();
            image.UriSource = new Uri(attachment.url);
            ImageElement.Source = image;

            ImageDescriptionTextBlock.Text = attachment.description == null ? "" : attachment.description;
            ImageDescriptionTextBlock.UpdateLayout();
            DescriptionGrid.Height = ImageDescriptionTextBlock.Height + 20;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}

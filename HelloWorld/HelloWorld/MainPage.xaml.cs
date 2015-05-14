using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.
            Button myButton = new Button();
            myButton.Name = "CliqueNoBotao"; 
            myButton.Content = "Click Me"; 
            myButton.Width = 200; 
            myButton.Height = 100; 
            myButton.Margin = new Thickness(46, 102, 0, 0); 
            myButton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left; 
            myButton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top; 
            myButton.Background = new SolidColorBrush(Colors.Red);
            myButton.Click += Button_Click;
            //myLayoutGrid.Children.Add(myButton); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = "Olá mundo!";
        }
    }
}

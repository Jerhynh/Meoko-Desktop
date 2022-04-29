using NyaaNet;
using NyaaNet.Enums;
using NyaaNet.Enums.SortingParameters;
using NyaaNet.Enums.SubCategories;
using NyaaNet.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MeokoDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            APIClient client = new("http://127.0.0.1:8080/", "admin", "pass1234");
            URLBuilder builder = new("http://127.0.0.1:8080/");

            var url = builder.BuildSearchURL(RouteEndpoints.Anime, "", SortingMethods.size, 1, OrderMethods.Descending);
            
            string? resultPayload;
            try
            {
                resultPayload = await client.SendRequestPayloadAsync(url);
            }
            catch (HttpRequestException)
            {
                AddPostAreaPost(new NyaaPost() { title = "An error occurred whilst attempting to fetch results. ", size = "0", link = "N/A" });
                return;
            }
            
            var posts = JsonHelpers.DeserializeResults(resultPayload);
            if (posts == null)
            {
                AddPostAreaPost(new NyaaPost() { title = "No results found", size = "0", link = "N/A" });
                return;
            }
            foreach (var post in posts!)
            {
                AddPostAreaPost(post);
            }
        }

        private void AddPostAreaPost(object postItem)
        {
            Dispatcher.Invoke(() =>
            {
                postArea.Items.Add(postItem);
            });
        }
        
        private void ClearPostArea()
        {
            Dispatcher.Invoke(() =>
            {
                postArea.Items.Clear();
            });
        }

        private async void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearPostArea();
            APIClient client = new("http://127.0.0.1:8080/", "admin", "pass1234");
            URLBuilder builder = new("http://127.0.0.1:8080/");
            var url = builder.BuildSearchURL(RouteEndpoints.Anime, SearchBar.Text, SortingMethods.size, 1, OrderMethods.Descending);

            string? resultPayload;
            try
            {
                resultPayload = await client.SendRequestPayloadAsync(url);
            }
            catch (HttpRequestException)
            {
                AddPostAreaPost(new NyaaPost() { title = "An error occurred whilst attempting to fetch results. ", size = "0", link = "N/A" });
                return;
            }
            
            var posts = JsonHelpers.DeserializeResults(resultPayload);
            if (posts == null)
            {
                AddPostAreaPost(new NyaaPost() { title = "No results found", size = "0", link = "N/A" });
                return;
            }
            foreach (var post in posts)
            {
                AddPostAreaPost(post);
            }
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                SearchBtn_Click(this, new RoutedEventArgs());
            }
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
                var post = item.Content as NyaaPost;
                if ( post != null && post.link != null)
                {
                    post.link = post.link.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(post.link) { UseShellExecute = true });
                }
            }
        }
    }
}

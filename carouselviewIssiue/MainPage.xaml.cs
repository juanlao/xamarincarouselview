using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace carouselviewIssiue
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<string> ImageList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ImageList = new List<string>();
            ImageList.Add("xamarinstore.jpg");
            ImageList.Add("xamarinstore.jpg");
            ImageList.Add("xamarinstore.jpg");
            ImageList.Add("xamarinstore.jpg");

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.carousel.ItemsSource = ImageList;

            this.carouselGrid.ItemsSource = ImageList;
        }
    }
}

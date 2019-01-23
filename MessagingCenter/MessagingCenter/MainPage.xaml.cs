using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnClick(object sender, System.EventArgs e)
        {
            var page = new TargetPage();
            page.SliderValueChanged += OnSliderValueChanged;
            Navigation.PushAsync(page);
        }

        private void OnSliderValueChanged(object source, double newValue)
        {
            label.Text = newValue.ToString();
        }
    }
}

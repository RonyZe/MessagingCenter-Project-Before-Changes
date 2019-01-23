using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagingCenter
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TargetPage : ContentPage
    {
        public event EventHandler<double> SliderValueChanged;
		public TargetPage ()
		{
			InitializeComponent ();
		}

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValueChanged?.Invoke(this, e.NewValue);           
        }
    }
}
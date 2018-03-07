using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BunyanApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CompanyDetails : ContentPage
	{
		public CompanyDetails ()
		{
			InitializeComponent ();
		}

        private void mySlider_ValueChanged(object sender , ValueChangedEventArgs e)
        {
            txtResult.Text = "Value: " + mySlider.Value;
        }

    }
}
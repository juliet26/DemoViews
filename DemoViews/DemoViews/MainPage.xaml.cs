using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoViews
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
          
		}
        private void btnClicked(object sender, EventArgs e)
        {
            DisplayAlert("boton,", "evento desde Xaml", "Aceptar");
        }

    }
}

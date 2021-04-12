using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindTest2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            Data data = new Data
            {
                DataText = "Test1"
            };
            label.BindingContext = data;
            label.SetBinding(Label.TextProperty, "DataText");

            data.DataText = "Test2";
        }

        private void slider_Clicked(object sender, EventArgs e)
        {
            Data data = new Data();

            data.DataText = "Test3";
            label.BindingContext = data;
            label.SetBinding(Label.TextProperty, "DataText");

        }
    }
}

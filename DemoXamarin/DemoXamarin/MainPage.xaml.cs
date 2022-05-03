using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoXamarin
{
    public partial class MainPage : ContentPage
    {
        private int _numberClicked;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)

        {
            _numberClicked++;

            ClickCountLabel.Text = _numberClicked.ToString();
        }
    }
}

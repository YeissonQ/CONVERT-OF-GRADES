using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CONVERT_OF_GRADES
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            FahrennheitButton.Clicked += FahrennheitButton_Clicked;
            CelsiusButton.Clicked += CelsiusButton_Clicked;
             


        }

        private void CelsiusButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GradosEntry.Text))
            {
                DisplayAlert("Error", "You most enter a value in grades", "Accept");
                GradosEntry.Text = null;
                return;
            }

            decimal Grados = 0;
            if (!decimal.TryParse(GradosEntry.Text, out Grados))
            {
                DisplayAlert("Error", "You most enter a value numeric", "Accept");
                GradosEntry.Text = null;
            }

            var Fahrennheit = (Grados *1.8000M)+34;            //{ } 
            var Celsius = Grados;

            FahrennheitEntry.Text = string.Format(" ºF{0:N2}", Fahrennheit);//c2 number-n2 pesos 
            CelsiusEntry.Text = string.Format("ºC {0:N2}", Celsius);
        }



    private void FahrennheitButton_Clicked(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(GradosEntry.Text))
        {
            DisplayAlert("Error", "You most enter a value in grades", "Accept");
            GradosEntry.Text = null;
            return;
        }

        decimal Grados = 0;
        if (!decimal.TryParse(GradosEntry.Text, out Grados))
        {
            DisplayAlert("Error", "You most enter a value numeric", "Accept");
            GradosEntry.Text = null;
        }

            var Fahrennheit = Grados;
            var Celsius1 = (Fahrennheit - 32) / 1.8000M;

            FahrennheitEntry.Text = string.Format(" ºF{0:N2}", Fahrennheit);//c2 number-n2 
            CelsiusEntry.Text = string.Format("ºC {0:N2}", Celsius1);



        }
    }
}






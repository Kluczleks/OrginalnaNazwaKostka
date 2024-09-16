
using System.Security.Cryptography.X509Certificates;

namespace OrginalnaNazwaKostka
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void OnCounterClicked(object sender, EventArgs e)
        {

            if (K4.IsChecked)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 5);
                kostka.Text = randomNumber.ToString() + " to twój wynik";
                    
            }
            if (K6.IsChecked) 
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 7);
                kostka.Text = randomNumber.ToString() + " to twój wynik";
               
            }
            if (K10.IsChecked) 
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 11);
                kostka.Text = randomNumber.ToString() + " to twój wynik";
                
            }
            if (K12.IsChecked) 
            {   
                Random rand = new Random();
                int randomNumber = rand.Next(1, 13);
                kostka.Text = randomNumber.ToString() + " to twój wynik";
               
            }





            // kostka.Text = randomNumber.ToString() + " to twój wynik";
            //SemanticScreenReader.Announce(kostka.Text);
            // komenda taka

        }
    }


}
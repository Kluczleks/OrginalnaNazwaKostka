

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
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);
            kostka.Text = randomNumber.ToString()+ " to twój wynik";
            SemanticScreenReader.Announce(kostka.Text); 
            // komenda taka 
        }
    }
  

}

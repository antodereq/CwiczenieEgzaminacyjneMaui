namespace CwiczenieEgzaminacyjneMaui
{
    public partial class MainPage : ContentPage
    {
        private bool lampOn = false;
        private bool coolerOn = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void lampBtn_Clicked(object sender, EventArgs e)
        {
            lampOn = !lampOn;
            Button clickedButton = (Button)sender;
            if (lampOn)
            {
                clickedButton.Text = "Wyłącz";
                lampLabel.Text = "Lampka jest włączona";
            } else
            {
                clickedButton.Text = "Włącz";
                lampLabel.Text = "Lampka jest wyłączona";
            }
        }

        private void coolerBtn_Clicked(object sender, EventArgs e)
        {
            coolerOn = !coolerOn;
            Button clickedButton = (Button)sender;
            if (coolerOn)
            {
                clickedButton.Text = "Wyłącz";
                coolerLabel.Text = "Klimatyzacja jest włączona";
            } else
            {
                clickedButton.Text = "Włącz";
                coolerLabel.Text = "Klimatyzacja jest wyłączona";
            }
        }

        private void tempBtn_Clicked(object sender, EventArgs e)
        {
            tempLabel.Text = "";
            int temp;
            bool correctlyParsed = int.TryParse(tempEntry.Text, out temp);
            if(!correctlyParsed || (temp > 30 || temp < 16))
            {
                tempLabel.Text = "Błędna temperatura";
            } else
            {
                tempLabel.Text = $"{temp}°C";
            }
            tempEntry.Text = "";

        }
    }
}

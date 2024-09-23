namespace kalkulator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string dzialanie;
        string[] l1 = new string[2];
        double a=0,b=0;
        char znak;
        private void onClickB1(object sender, EventArgs e) {
            output.Text += "1";
            dzialanie += "1";
        }
        private void onClickB2(object sender, EventArgs e)
        {
            output.Text += "2";
            dzialanie += "2";
        }
        private void onClickB3(object sender, EventArgs e)
        {
            output.Text += "3";
            dzialanie += "3";
        }
        private void onClickB4(object sender, EventArgs e)
        {
            output.Text += "4";
            dzialanie += "4";
        }
        private void onClickB5(object sender, EventArgs e)
        {
            output.Text += "5";
            dzialanie += "5";
        }
        private void onClickB6(object sender, EventArgs e)
        {
            output.Text += "6";
            dzialanie += "6";
        }
        private void onClickB7(object sender, EventArgs e)
        {
            output.Text += "7";
            dzialanie += "7";
        }
        private void onClickB8(object sender, EventArgs e)
        {
            output.Text += "8";
            dzialanie += "8";
        }
        private void onClickB9(object sender, EventArgs e)
        {
            output.Text += "9";
            dzialanie += "9";
        }

        private void onClickB0(object sender, EventArgs e)
        {
            output.Text += "0";
            dzialanie += "0";
        }
        private void onClickBplus(object sender, EventArgs e)
        {
            output.Text += "+";
            a = Double.Parse(dzialanie);
            dzialanie += "+";
            znak = '+';
        }
        private void onClickBminus(object sender, EventArgs e)
        {
            output.Text += "-";
            dzialanie += "-";
            znak = '-';
        }
        private void onClickBmnoz(object sender, EventArgs e)
        {
            output.Text += "*";
            dzialanie += "*";
            znak = '*';
        }
        private void onClickBdziel(object sender, EventArgs e)
        {
            output.Text += "/";
            dzialanie += "/";
            znak = '/';
        }
        private void onClickBrowne(object sender, EventArgs e)
        { 
            output.Text += "=";
            string[] liczby = dzialanie.Split(znak);
            output.Text = liczby[0] +","+ liczby[1];
            
        }
    }

}

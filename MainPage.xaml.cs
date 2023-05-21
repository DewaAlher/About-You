using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DataDiriApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nama = txtNama.Text;
            string umur = txtUmur.Text;
            string alamat = txtAlamat.Text;
            string hobi = txtHobi.Text;
            string band = txtBand.Text;
            string lagu = txtLagu.Text;

            string output = "Data Diri:\n" +
                            "Nama: " + nama + "\n" +
                            "Umur: " + umur + "\n" +
                            "Alamat: " + alamat + "\n" +
                            "Hobi: " + hobi + "\n" +
                            "Band Favorit: " + band + "\n" +
                            "Lagu Favorit: " + lagu;

            txtOutput.Text = output;
        }
    }
}

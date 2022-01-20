
using PrimeNumbers.Services;
using PrimeNumbers.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeNumbers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimesPage7vm : ContentPage
    {
        PrimePageViewModel viewmodel => BindingContext as PrimePageViewModel;
        public PrimesPage7vm()
        {
            InitializeComponent();
            BindingContext = new PrimePageViewModel(DependencyService.Get<IPrimeNumerService>());
        }
        public PrimesPage7vm(int NrOfBatches) : this()
        {
            viewmodel.NrOfBatches = NrOfBatches;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainThread.BeginInvokeOnMainThread(async () => { await viewmodel.LoadPrimes(); });
        }
    }
}
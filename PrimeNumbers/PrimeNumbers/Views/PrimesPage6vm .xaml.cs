using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

using PrimeNumbers.Models;
using PrimeNumbers.Services;
using PrimeNumbers.ViewModels;

namespace PrimeNumbers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimesPage6vm : ContentPage
    {
        PrimePageViewModel viewmodel => BindingContext as PrimePageViewModel;
        public PrimesPage6vm()
        {
            
            InitializeComponent();
            BindingContext = new PrimePageViewModel(DependencyService.Get<IPrimeNumerService>());
        }
        public PrimesPage6vm(int NrOfBatches):this()
        {
            viewmodel.NrOfBatches = NrOfBatches;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await viewmodel.LoadPrimes();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainThread.BeginInvokeOnMainThread(async () => { await viewmodel.LoadPrimes(); });
        }
    }
}
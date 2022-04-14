using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PrimeNumbers.Services;
using PrimeNumbers.Models;

namespace PrimeNumbers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimesPage1 : ContentPage
    {
        PrimeNumberService _service;

        public PrimesPage1()
        {
            InitializeComponent();
            _service = new PrimeNumberService();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!int.TryParse(enNrBatches.Text, out int nrbatches)) return;

            lvPrimes.ItemsSource = await _service.GetPrimeBatchCountsAsync(nrbatches, null);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeNumbers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageFlyout : ContentPage
    {
        public ListView ListView;

        public MainPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MainPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageFlyoutViewModel
        {
            public ObservableCollection<MainPageFlyoutMenuItem<int?>> MenuItems { get; set; }

            public MainPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MainPageFlyoutMenuItem<int?>>(new[]
                {
                    new MainPageFlyoutMenuItem<int?> { Id = 0, Title = "About Primes", TargetType=typeof(AboutPage) },
                    new MainPageFlyoutMenuItem<int?> { Id = 1, Title = "Debug Console", TargetType=typeof(ConsolePage) },
                    new MainPageFlyoutMenuItem<int?> { Id = 2, Title = "Find Primenumbers 1", TargetType=typeof(PrimesPage1) },
                    new MainPageFlyoutMenuItem<int?> { Id = 3, Title = "Find Primenumbers 2", TargetType=typeof(PrimesPage2), Param = 5},
                    new MainPageFlyoutMenuItem<int?> { Id = 4, Title = "Find Primenumbers 3", TargetType=typeof(PrimesPage3), Param = 5},
                    new MainPageFlyoutMenuItem<int?> { Id = 5, Title = "Find Primenumbers 4", TargetType=typeof(PrimesPage4), Param = 5},
                    new MainPageFlyoutMenuItem<int?> { Id = 6, Title = "Find Primenumbers 5vm", TargetType=typeof(PrimesPage5vm), Param = 3},
                    new MainPageFlyoutMenuItem<int?> { Id = 7, Title = "Find Primenumbers 6vm", TargetType=typeof(PrimesPage6vm), Param = 3},
                    new MainPageFlyoutMenuItem<int?> { Id = 8, Title = "Find Primenumbers 7vm", TargetType=typeof(PrimesPage7vm), Param = 3},
                    new MainPageFlyoutMenuItem<int?> { Id = 9, Title = "Find Primenumbers 8vm", TargetType=typeof(PrimesPage8vm), Param = 3},
                });
            }
        }
    }
}
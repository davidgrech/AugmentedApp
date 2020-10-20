using System.ComponentModel;
using Xamarin.Forms;
using AugmentedApp.ViewModels;

namespace AugmentedApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
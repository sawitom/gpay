using gpay.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace gpay.Views
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
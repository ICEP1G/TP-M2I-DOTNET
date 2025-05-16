using System.Threading.Tasks;
using TP_M2I_DOTNET.ViewModels;

namespace TP_M2I_DOTNET
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadMainPageData();
        }
    }
}

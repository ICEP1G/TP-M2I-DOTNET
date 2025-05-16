using CSharpFunctionalExtensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TP_M2I_DOTNET.DTOs;
using TP_M2I_DOTNET.Services;
using TP_M2I_DOTNET.Views;

namespace TP_M2I_DOTNET.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region NotifyChanges declaration
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Variables declaration
        private readonly IPetService _petService;
        private readonly IOrderService _orderService;

        private ObservableCollection<PetDto> pets;
        private ObservableCollection<OrderDto> orders;
        private bool isLoadingMainPage;
        #endregion

        public ICommand GoToPetPageCommand { get; }

        public MainPageViewModel(IPetService petService, IOrderService orderService)
        {
            _petService = petService;
            _orderService = orderService;

            GoToPetPageCommand = new Command<PetDto>(async (pet) =>
            {
                if (pet != null)
                {
                    await AppShell.Current.GoToAsync($"{nameof(PetPage)}", new ShellNavigationQueryParameters { { "PetId", pet.Id } });
                }
            });

            pets = new();
            orders = new();
        }


        public ObservableCollection<PetDto> Pets
        {
            get { return pets; }
            set { pets = value; OnPropertyChanged(nameof(Pets)); }
        }

        public ObservableCollection<OrderDto> Orders
        {
            get { return orders; }
            set { orders = value; OnPropertyChanged(nameof(Orders)); }
        }


        public bool IsLoadingMainPage
        {
            get { return isLoadingMainPage; }
            set { isLoadingMainPage = value; OnPropertyChanged(nameof(IsLoadingMainPage)); }
        }



        public async Task LoadMainPageData()
        {
            IsLoadingMainPage = true;
            Result<List<PetDto>> pets = await _petService.GetAllPetsAsync();
            if (pets.IsSuccess)
            {
                foreach (PetDto pet in pets.Value)
                {
                    Pets.Add(pet);
                }
            }

            Result<List<OrderDto>> orders = await _orderService.GetAllOrdersAsync();
            if (orders.IsSuccess)
            {
                foreach (OrderDto order in orders.Value)
                {
                    Orders.Add(order);
                }
            }
            isLoadingMainPage = false;
        }

    }
}

using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_M2I_DOTNET.DTOs;

namespace TP_M2I_DOTNET.Services
{
    public class OrderFakeDataService : IOrderService
    {
        private readonly FakeDataService _fakeDataService;
        public OrderFakeDataService(FakeDataService fakeDataService)
        {
            _fakeDataService = fakeDataService;
        }


        public async Task<Result<List<OrderDto>>> GetAllOrdersAsync()
        {
            try
            {
                await Task.Delay(500);
                List<OrderDto>? orders = await _fakeDataService.GetAllOrdersAsync();
                if (orders is null)
                    return Result.Failure<List<OrderDto>>("No orders found");

                return Result.Success(orders);
            }
            catch (Exception ex)
            {
                return Result.Failure<List<OrderDto>>($"Unexpected error: {ex.Message}");
            }
        }
    }
}

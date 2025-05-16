using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_M2I_DOTNET.DTOs;

namespace TP_M2I_DOTNET.Services
{
    public interface IOrderService
    {
        Task<Result<List<OrderDto>>> GetAllOrdersAsync();
    }
}

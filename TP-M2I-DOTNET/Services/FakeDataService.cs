using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_M2I_DOTNET.DTOs;

namespace TP_M2I_DOTNET.Services
{
    public class FakeDataService
    {
        public async Task<List<PetDto>> GetAllPetsAsync()
        {
            List<PetDto> pets = new()
            {
                new PetDto()
                {
                    Id = 1354862465,
                    Name = "Medor",
                    Category = new CategoryDto() {Id = 1, Name = "Dog"},
                    PhotoUrls = { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/YellowLabradorLooking.jpg/640px-YellowLabradorLooking.jpg" },
                    Tags = new List<TagDto>()
                    {
                        new TagDto() { Id = 1, Name = "Labrador" },
                        new TagDto() { Id = 2, Name = "Ugly" }
                    }
                },
                new PetDto()
                {
                    Id = 213548465,
                    Name = "Rufus",
                    Category = new CategoryDto() {Id = 2, Name = "Chat"},
                    PhotoUrls = { "https://goodflair.com/app/uploads/2024/09/beautiful-bengal-cat.jpg" },
                    Tags = new List<TagDto>()
                    {
                        new TagDto() { Id = 1, Name = "Goutiere" },
                        new TagDto() { Id = 2, Name = "Pretty" }
                    }
                }
            };
            return pets;
        }


        public async Task<List<OrderDto>> GetAllOrdersAsync()
        {
            List<OrderDto> orders = new()
            {
                new OrderDto()
                {
                    Id = 1,
                    PetId = 1354862465,
                    Quantity = 1,
                    ShipDate = DateTime.Now.AddDays(-4),
                    Status = OrderStatus.Approved,
                    Complete = false
                },
                new OrderDto()
                {
                    Id = 2,
                    PetId = 213548465,
                    Quantity = 1,
                    ShipDate = DateTime.Now.AddDays(-13),
                    Status = OrderStatus.Delivered,
                    Complete = true
                }
            };
            return orders;
        }
    }
}

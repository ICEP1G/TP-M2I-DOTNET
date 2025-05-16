using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_M2I_DOTNET.DTOs
{
    public class OrderDto
    {
        public long Id { get; set; }
        public long PetId { get; set; }
        public int Quantity { get; set; }
        public DateTime ShipDate { get; set; }
        public OrderStatus Status { get; set; }
        public bool Complete { get; set; }
    }

    public enum OrderStatus
    {
        Placed,
        Approved,
        Delivered
    }
}

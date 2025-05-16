using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_M2I_DOTNET.DTOs
{
    public class PetDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public CategoryDto Category { get; set; }
        public List<string> PhotoUrls { get; set; } = new();
        public List<TagDto> Tags { get; set; } = new();
        public Status Status { get; set; }
    }

    public enum Status
    {
        Available,
        Pending,
        Sold
    }
}

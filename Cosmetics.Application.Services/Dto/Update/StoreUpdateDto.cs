using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Update
{
    public class StoreUpdateDto
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Email { get; set; }
        public string Tell { get; set; }
    }
}

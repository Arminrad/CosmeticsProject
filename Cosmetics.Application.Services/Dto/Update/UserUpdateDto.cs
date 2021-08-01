using Cosmetics.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Update
{
    public class UserUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}

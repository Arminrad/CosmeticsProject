using System;
using System.Collections.Generic;
using System.Text;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Dto.Input
{
    public class CommentInputDto
    {
        //public string Name { get; set; }
        //public string Family { get; set; }
        public String CommentText { get; set; }
        public DateTime RegisterDate { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }

    }
}

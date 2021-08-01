using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Update
{
   public class CommentUpdateDto
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string Family { get; set; }
        public String CommentText { get; set; }
        public DateTime RegisterDate { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}

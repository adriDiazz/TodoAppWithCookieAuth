using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DTOs
{
    public class UpdateTodoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        public bool IsComplete { get; set; }
    }
}
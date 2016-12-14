using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Entities
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Car> Cars { get; set; }
        public string MarkType { get; set; }
    }
}
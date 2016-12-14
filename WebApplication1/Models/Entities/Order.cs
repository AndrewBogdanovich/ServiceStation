using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [ForeignKey("Car")]
        public int? CarId { get; set; }
        public virtual Car Car { get; set; }
        public string Description { get; set; }
    }
}
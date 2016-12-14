using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Entities
{
    public class Car
    {
        public int Id { get; set; }
        [ForeignKey("Mark")]
        public int? IdMark { get; set; }
        public virtual Mark Mark { get; set; }
        public string GearBox { get; set; }
        public string Volume { get; set; }
        public string Transmission { get; set; }
        public string Description { get; set; }           
        
        public virtual ICollection<Order> Order { get; set; }
       
        public virtual ApplicationUser User { get; set; }

    }
}
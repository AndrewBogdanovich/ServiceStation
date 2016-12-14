using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Entities
{
    public class Detail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Mark")]
        public int? MarkId { get; set; }
        public virtual Mark Mark { get; set; }

        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Entities
{
    public class Wash
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
    }
}
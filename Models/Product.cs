using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerApiEx2.Models
{
    public class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public int PQty { get; set; }
        public decimal PPrice { get; set; }
    }
}

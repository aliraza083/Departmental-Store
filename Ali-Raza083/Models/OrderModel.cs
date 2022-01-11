using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ali_Raza083.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string descirption { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}

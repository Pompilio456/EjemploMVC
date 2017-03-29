using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjemploMVC.Controllers
{
    public class Product
    {
        [Key] //data notation key, que nos maneja el ID
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Lastbuy { get; set; }
        public float Stock { get; set; }

    }
}
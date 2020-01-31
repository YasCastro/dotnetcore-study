using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCoffee.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
        public string Grounds { get; set; }
        public decimal Roast { get; set; }
    }
}
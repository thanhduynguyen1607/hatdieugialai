using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace HatDieuGiaLai.Shared
{
    public class Dieu
    {
        public Dieu(int id, string name, decimal price,
        Loaisanpham loaisanpham)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Loaisanpham = loaisanpham;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Loaisanpham Loaisanpham { get; }
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}

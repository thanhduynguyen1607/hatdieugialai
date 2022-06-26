using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDieuGiaLai.Shared
{
    public class ShoppingBasket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; }
        public void Add(int dieuId)
        => Orders.Add(dieuId);
        public void RemoveAt(int pos)
       => Orders.RemoveAt(pos);
    }
}

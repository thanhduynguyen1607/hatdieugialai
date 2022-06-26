using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDieuGiaLai.Shared
{
    public interface IOrderService
    {
        ValueTask PlaceOrder(ShoppingBasket basket);
    }
}

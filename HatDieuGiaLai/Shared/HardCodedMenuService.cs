using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDieuGiaLai.Shared
{
    public class HardCodedMenuService : IMenuService
    {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu
            {
                Dieus = new List<Dieu> {
                    new Dieu(1, "Hạt điều tươi", 8.99M, Loaisanpham.Tuoi),
                    new Dieu(2, "Hạt điều rang muối", 7.99M, Loaisanpham.Rangmuoi),
                    new Dieu(3, "Hạt điều mật ong", 9.99M, Loaisanpham.Matong)
                }
            });
    }
}

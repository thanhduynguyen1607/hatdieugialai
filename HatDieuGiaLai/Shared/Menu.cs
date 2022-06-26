using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDieuGiaLai.Shared
{
    public class Menu
    {
        public List<Dieu> Dieus { get; set; }
           = new List<Dieu>();
        public void Add(Dieu dieu)
            => Dieus.Add(dieu);
        public Dieu? GetDieu(int id)
            => Dieus.SingleOrDefault(dieu => dieu.Id == id);
    }
}

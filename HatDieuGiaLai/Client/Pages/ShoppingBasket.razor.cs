using Microsoft.AspNetCore.Components;
using HatDieuGiaLai.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HatDieuGiaLai.Client.Pages {
    partial class ShoppingBasket {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Dieu> GetDieuFromId { get; set; }
        = default!;
        private IEnumerable<(Dieu dieu, int pos)> Dieus { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet() {
            Dieus = Orders.Select((id, pos)
            => (dieu: GetDieuFromId(id), pos: pos));
            TotalPrice = Dieus.Select(tuple
            => tuple.dieu.Price).Sum();
        }
    }
}

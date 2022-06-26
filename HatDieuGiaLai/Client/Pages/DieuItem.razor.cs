using Microsoft.AspNetCore.Components;
using HatDieuGiaLai.Shared;

namespace HatDieuGiaLai.Client.Pages {
    partial class DieuItem {
        [Parameter]
        public Dieu Dieu { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Dieu> Selected { get; set; }
        private string LoaisanphamImage(Loaisanpham loaisanpham)
        => $"images/{loaisanpham.ToString().ToLower()}.png";
    }
}

using Microsoft.AspNetCore.Components;
using HatDieuGiaLai.Shared;
using System.Collections.Generic;

namespace HatDieuGiaLai.Client.Pages {
    partial class DieuList {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Dieu> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Dieu> Selected { get; set; }
    }
}

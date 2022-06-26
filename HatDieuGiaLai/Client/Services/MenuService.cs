using System.Net.Http.Json;
using HatDieuGiaLai.Shared;

namespace HatDieuGiaLai.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu()
        {
            var dieus = await httpClient
                .GetFromJsonAsync<Dieu[]>("/dieus");
            return new Menu { Dieus = dieus!.ToList() };
        }
    }
}

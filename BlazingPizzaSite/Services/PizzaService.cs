using BlazingPizzaSite.Model;
using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace BlazingPizzaSite.Services
{
    public class PizzaService
    {
        private readonly HttpClient _httpClient;

        private readonly NavigationManager NavigationManager;
        public PizzaService(HttpClient httpClient, NavigationManager NavigationManager)
        {
            _httpClient = httpClient;
            this.NavigationManager = NavigationManager;
        }
        public async Task<List<PizzaSpecial>> GetPizzasAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<PizzaSpecial>>($"{NavigationManager.BaseUri}orders/specials");
        }
    }
}
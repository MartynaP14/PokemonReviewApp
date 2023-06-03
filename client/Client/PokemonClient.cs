using Microsoft.AspNetCore.Http;
using pokemonAppClient.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonAppClient.Client
{
    public class PokemonClient : IPokemonClient
    {

        private HttpClient _httpClient;
        private readonly string _url = "https://localhost:7107";



        public PokemonClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_url);
        }


        public async Task<HttpResponseMessage> GetCountriesAsync()
        {
            return await _httpClient.GetAsync("api/country");
           
        } 



        //HttpClient client = new HttpClient();

        //client.BaseAddress = new Uri("https://localhost:7107");


        //HttpResponseMessage response = await client.GetAsync("api/country");
        //var responseBody = await response.Content.ReadAsStringAsync();
        //Console.WriteLine(response);
        //Console.WriteLine(responseBody);
    }
}

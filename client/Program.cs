
using Microsoft.AspNetCore.Http;
using pokemonAppClient.Client;
using PokemonReviewApp.Dto;
using System.Text.Json;



var option = 0;
var httpClient = new HttpClient();
var pokemonClient = new PokemonClient(httpClient);

while (option != 7 )
{
    Console.WriteLine("Please enter the option");
    Console.WriteLine("Option one - Country list ");
    Console.WriteLine("Option two - Country by ID ");
    Console.WriteLine("Option three - Create Country ");
    Console.WriteLine("Option four - Delete Country ");
    Console.WriteLine("Option seven - Exit ");
    option = Int32.Parse(Console.ReadLine());

    if (option == 1)
    {

        HttpResponseMessage response= await pokemonClient.GetCountriesAsync();
        Console.WriteLine(response);
        var responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);

    }

    

}









//HttpClient client = new HttpClient();

//client.BaseAddress = new Uri("https://localhost:7107");


//HttpResponseMessage response = await client.GetAsync("api/country");
//var responseBody = await response.Content.ReadAsStringAsync();
//Console.WriteLine(response);
//Console.WriteLine(responseBody);



//HttpResponseMessage responseone = await client.GetAsync("api/country/2");
//var responseBodyone = await responseone.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodyone);



//var countryDto = new CountryDto() { Name = "UKkk" };
//string jsonPayLoad = JsonSerializer.Serialize(countryDto);
//HttpContent httpContent = new StringContent(jsonPayLoad, System.Text.Encoding.UTF8, "application/json");
//HttpResponseMessage responsetwo = await client.PostAsync("api/Country", httpContent);

//var responseBodytwo = await responsetwo.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodytwo);


//HttpResponseMessage responsethree = await client.DeleteAsync("api/country/2");
//var responseBodythree = await responsethree.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodythree);




//var countryDtotwo = new CountryDto() { Id = 1002, Name = "Spain2" };
//string jsonPayLoadtwo = JsonSerializer.Serialize(countryDtotwo);
//HttpContent httpContenttwo = new StringContent(jsonPayLoadtwo, System.Text.Encoding.UTF8, "application/json");
//HttpResponseMessage responsefour = await client.PutAsync("api/Country/1002", httpContenttwo);

//var responseBodyfour = await responsefour.Content.ReadAsStringAsync();
//Console.WriteLine("update result :" + responsefour);



//HttpResponseMessage responseOwnerOne = await client.GetAsync("api/Owner");
//var responseBodyOwnerOne = await responseOwnerOne.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodyOwnerOne);

//HttpResponseMessage responseOwnerOneById = await client.GetAsync("api/Owner/2004");
//var responseBodyOwnerOneById = await responseOwnerOneById.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodyOwnerOneById);


//var ownerDto = new OwnerDto() { Id=0, LastName = "Mate", FirstName = "Jade", Gym = "Chelsea stadium" };
//string jsonPayLoad = JsonSerializer.Serialize(ownerDto);
//HttpContent httpContent = new StringContent(jsonPayLoad, System.Text.Encoding.UTF8, "application/json");
//HttpResponseMessage responseOwnerTwo = await client.PostAsync("api/Owner?countryId=3", httpContent);

//var responseBodyOwnerTwo = await responseOwnerTwo.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodyOwnerTwo);


//HttpResponseMessage responseOwnerThree = await client.DeleteAsync("api/Owner/2");
//var responseBodyOwnerThree = await responseOwnerThree.Content.ReadAsStringAsync();
//Console.WriteLine(responseBodyOwnerThree);
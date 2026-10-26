using System;
using System.Net.Http;
using System.Text.Json;
using JokeFetcher.Dtos;

const string baseUrl = "https://official-joke-api.appspot.com/";

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var client = new HttpClient
{
    BaseAddress = new Uri(baseUrl)
};

try
{
    HttpResponseMessage response = client.GetAsync("jokes/random").Result;


    response.EnsureSuccessStatusCode();

    string responseBody = response.Content.ReadAsStringAsync().Result;

    var joke = JsonSerializer.Deserialize<Joke>(responseBody, options);

    if (joke != null)
    {
        Console.WriteLine("Here's a joke for you:");
        Console.WriteLine(joke.Setup);
        Console.WriteLine(joke.Punchline);
    }
    else
    {
        Console.WriteLine("Failed to fetch a joke.");
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine($"Request error: {e.Message}");
}
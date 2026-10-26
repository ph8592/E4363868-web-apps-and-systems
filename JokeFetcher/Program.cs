using System;
using System.Net.Http;
using System.Text.Json;
using JokeFetcher.Dtos;

#region Initialisation of HttpClient and JsonSerializerOptions - Exercise 1
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
#endregion

#region Exercise 2
// Start with an empty list
var jokes = new List<Joke>();
try
{
    // Send a GET request to the "jokes/{type}/ten" endpoint
    HttpResponseMessage response = client.GetAsync($"jokes/ten").Result;
    // Ensure the request was successful
    response.EnsureSuccessStatusCode();
    // Read the response content as a string
    string responseBody = response.Content.ReadAsStringAsync().Result;
    // Deserialize the JSON response into a list of Joke objects
    var jokeList = JsonSerializer.Deserialize<List<Joke>>(
    responseBody, options
    );
    // Add the jokes to the list if they are not null
    if (jokeList != null)
    {
        jokes.AddRange(jokeList);
    }
}
catch (HttpRequestException e)
{
    // Handle any HTTP request errors
    Console.WriteLine($"Request error: {e.Message}");
}
// Display list of jokes
Console.WriteLine("\n10 More Jokes");
Console.WriteLine("-------------");
foreach (var joke in jokes)
{
    Console.WriteLine(joke.Setup);
    Console.WriteLine(joke.Punchline);
    Console.WriteLine();
}

#endregion
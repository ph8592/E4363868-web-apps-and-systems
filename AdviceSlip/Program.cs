using System;
using System.Net.Http;
using System.Text.Json;
using AdviceSlip.Dtos;

const string baseUrl = "https://api.adviceslip.com/";

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
    HttpResponseMessage response = client.GetAsync("advice").Result;

    response.EnsureSuccessStatusCode();

    string responseBody = response.Content.ReadAsStringAsync().Result;

    var advice = JsonSerializer.Deserialize<AdviceSlipResponse>(responseBody, options);

    if (advice?.Slip is { } slip)
    {
        Console.WriteLine($"Advice: {slip.Advice}");
    }
    else
    {
        Console.WriteLine("Failed to retrieve advice.");
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine($"Request error: {e.Message}");
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text.Json;
using AdviceSlip.Dtos;

#region Program setup
const string baseUrl = "https://api.adviceslip.com/";

var options = new JsonSerializerOptions
{
PropertyNameCaseInsensitive = true
};

var client = new HttpClient
{
    BaseAddress = new Uri(baseUrl)
};
#endregion

FetchRandomAdvice(options, client);

var adviceSlips = new List<Slip>();

try
{
    using HttpResponseMessage response = await client.GetAsync("advice/search/work");

    response.EnsureSuccessStatusCode();

    string responseBody = await response.Content.ReadAsStringAsync();

    var result = JsonSerializer.Deserialize<AdviceSearchResponse>(
        responseBody, options);

    if (result?.Slips is { } slips)
    {
        adviceSlips.AddRange(slips);
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine($"Request error: {e.Message}");
}
catch (JsonException e)
{
    Console.WriteLine($"Could not read advice: {e.Message}");
}

Console.WriteLine("\nAdvice related to work:");
Console.WriteLine("-----------------------");

if (adviceSlips.Count == 0)
{
    Console.WriteLine("No advice to display.");
}

foreach (var advice in adviceSlips)
{
    Console.WriteLine($"{advice.SlipId}: {advice.Advice}");
}

#region Program methods
static void FetchRandomAdvice(JsonSerializerOptions options, HttpClient client)
{
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
}

#endregion
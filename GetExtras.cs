// This repository has example code for consuming the Buy me a coffee API

// first our needed usings
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

// Getting active members

// First you need to setup your ACCESS_TOKEN
// Go here and login to get your token
// https://developers.buymeacoffee.com/dashboard
private static string access_token = "change me to your token!";

/// <summary>
/// Return a list of extra transactions as a model
/// </summary>
private async Task<string> GetExtrasAsync()
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
    HttpResponseMessage response = await client.GetAsync("/api/v1/extras");
    if (response.IsSuccessStatusCode)
    {
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }
    return null;
}


//This line will give you a list of your extra packs
var result = await GetExtrasAsync();

// This repository has example code for consuming the Buy me a coffee API

// first our needed usings
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

// Getting a supporter by id

// First you need to setup your ACCESS_TOKEN
// Go here and login to get your token
// https://developers.buymeacoffee.com/dashboard
private static string access_token = "change me to your token!";

/// <summary>
/// Return a single Supporter by id as a model
/// </summary>
private async Task<string> GetSupporterAsync(int id)
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
    HttpResponseMessage response = await client.GetAsync($"/api/v1/supporters/{id}");
    if (response.IsSuccessStatusCode)
    {
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }
    return null;
}


//This line will give you the details of one of your supporters
var result = await GetSupporterAsync(id);

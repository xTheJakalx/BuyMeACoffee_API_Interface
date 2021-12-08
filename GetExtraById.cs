// This repository has example code for consuming the Buy me a coffee API

// first our needed usings
using System;
using System.Net.Http;
using System.Net.Http.Headers;

// Getting active members

// First you need to setup your ACCESS_TOKEN
// Go here and login to get your token
// https://developers.buymeacoffee.com/dashboard
private static string access_token = "change me to your token!";

/// <summary>
/// Return a single extra transaction by id as a model
/// </summary>
/// <param name="id">id of extra transaction to return</param>
private async Task<string> GetExtraByIdAsync(int id)
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
    HttpResponseMessage response = await client.GetAsync($"/api/v1/extras/{id}");
    if (response.IsSuccessStatusCode)
    {
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }
    return null;
}            


//This line will give you the details of one of your extras
var result = await GetExtraByIdAsync(id);

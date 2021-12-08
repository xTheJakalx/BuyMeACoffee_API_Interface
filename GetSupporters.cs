// This repository has example code for consuming the Buy me a coffee API

// first our needed usings
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

// Getting supporters

/// <summary>
/// Return a list of active Supporters as a model
/// </summary>
private async Task<string> GetSupportersAsync()
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
    HttpResponseMessage response = await client.GetAsync("/api/v1/supporters");
    if (response.IsSuccessStatusCode)
    {
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }
    return null;
}


//This line will give you a list of your supporters
var result = await GetSupportersAsync();

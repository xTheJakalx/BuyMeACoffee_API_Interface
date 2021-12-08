// This repository has example code for consuming the Buy me a coffee API

// Getting a member by id

// First you need to setup your ACCESS_TOKEN
// Go here and login to get your token
// https://developers.buymeacoffee.com/dashboard
private static string access_token = "change me to your token!";

/// <summary>
/// Return a single Members by id as a member model
/// </summary>
private async Task<string> GetMemberAsync(int id)
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
    HttpResponseMessage response = await client.GetAsync($"/api/v1/subscriptions/{id}");
    if (response.IsSuccessStatusCode)
    {
        var data = await response.Content.ReadAsStringAsync();
        return data;
    }
    return null;
}


//This line will give you the details of one of your members
var result = await GetMemberAsync(id);

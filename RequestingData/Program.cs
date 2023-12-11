var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpRequesModule");

Console.WriteLine("Inserisci Url:\n");

try
{
    var response = await httpClient.GetAsync(Console.ReadLine());
    Console.WriteLine($"Status: {(int)response.StatusCode} - {response.StatusCode}");
    Console.WriteLine(await response.Content.ReadAsStringAsync());
}
catch(HttpRequestException ex)
{
    Console.WriteLine($"Error Bad Request {ex.Message}" );
}
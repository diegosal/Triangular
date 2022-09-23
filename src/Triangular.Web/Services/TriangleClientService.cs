using System.Net.Http;
using System.Text.Json;
using System.Text;
using Triangular.Web.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace Triangular.Web.Services;

public class TriangleClientService<T, M> : ITriangleClient<T, M> where T : new() where M : class
{
    private readonly IHttpClientFactory _httpClientFactory;

    public TriangleClientService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

    public async Task<T?> GetPost(M model, string clientName, string path)
    {
        T? returnType = new();

        var httpClient = _httpClientFactory.CreateClient(clientName);

        var modelJson = new StringContent(
        JsonSerializer.Serialize(model),
        Encoding.UTF8,
        Application.Json);

        using var httpResponseMessage =
            await httpClient.PostAsync(path, modelJson);


        if (httpResponseMessage.IsSuccessStatusCode)
        {
            string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();

            returnType = JsonSerializer.Deserialize<T>(responseJson);
        }

        return returnType;
    }
}

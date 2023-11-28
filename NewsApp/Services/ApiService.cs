using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services;

public class ApiService
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?country=tw&category={categoryName.ToLower()}&apikey=b24cdceaa31973f087511d89cff6cd51");
		return JsonConvert.DeserializeObject<Root>(response);
	}
}
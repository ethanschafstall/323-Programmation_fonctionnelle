using Newtonsoft.Json;
using System.Linq;

static async Task<List<dynamic>> api(string uri) { 
    var client = new HttpClient();
    var endpoint = new Uri(uri);
    var response = client.GetAsync(endpoint).Result;
    var json = await response.Content.ReadAsStringAsync();

    dynamic reponseData = JsonConvert.DeserializeObject<dynamic>(json);

    var values = new List<dynamic> { };

    foreach (var item in reponseData.results)
    {
        values.Add(item);
    }
    return values;
}


/*EXO 1.*/
//var exo1 = await api("https://swapi.dev/api/films");
//var longestTitleMovie = exo1.Aggregate((a, b) => ((string)a.title).Length > ((string)b.title).Length ? a : b);
//Console.WriteLine(((string)longestTitleMovie.title).Length);

/*EXO 2.*/
var exo2 = await api("https://swapi.dev/api/people");

var inMostMovies = exo2.Select(a => ((List<dynamic>)a.films).Count);
Console.WriteLine(inMostMovies);
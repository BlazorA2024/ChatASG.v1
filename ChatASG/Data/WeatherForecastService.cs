using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace ChatASG.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }




        public class ScenarioResponse
        {
            [JsonProperty("seqtactic")]
            public string Seqtactic { get; set; }

            [JsonProperty("iduser")]
            public string IdUser { get; set; }

            [JsonProperty("seqtec")]
            public string Seqtec { get; set; }

            [JsonProperty("score")]
            public string Score { get; set; }
        }

        public class S2sApiClient : IDisposable
        {
            private readonly HttpClient _httpClient;
            private bool _disposed;

            public S2sApiClient()
            {
                _httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://wasmdashai-dash-asg.hf.space")
                };
            }

            public async Task<List<ScenarioResponse>> GetScenariosAsync(string inputText)
            {
                if (string.IsNullOrWhiteSpace(inputText))
                    throw new ArgumentException("Input text must not be empty.", nameof(inputText));

                // Step 1: Send POST
                var payload = new { data = new[] { inputText } };
                var jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var postResponse = await _httpClient.PostAsync("/call/s2s", content);
                postResponse.EnsureSuccessStatusCode();
                var postBody = await postResponse.Content.ReadAsStringAsync();

                var eventId = JObject.Parse(postBody)?["event_id"]?.ToString();
                if (string.IsNullOrWhiteSpace(eventId))
                    throw new Exception("Failed to retrieve event ID.");

                // Step 2: Get the SSE response
                var getResponse = await _httpClient.GetAsync($"/call/s2s/{eventId}");
                getResponse.EnsureSuccessStatusCode();
                var finalRaw = await getResponse.Content.ReadAsStringAsync();

                // Step 3: Extract JSON from SSE format (skip "event: complete")
                var prefix = "data: ";
                var dataStart = finalRaw.IndexOf(prefix);
                if (dataStart == -1)
                    throw new Exception("Invalid response format, 'data:' not found.");

                var jsonPart = finalRaw.Substring(dataStart + prefix.Length).Trim();

                // Step 4: Parse into list of ScenarioResponse
                return ParseScenarioList(jsonPart);
            }

            private List<ScenarioResponse> ParseScenarioList(string jsonData)
            {
                var result = new List<ScenarioResponse>();

                // ÇáÌÐÑ åæ ßÇÆä íÍÊæí Úáì headers æ data
                var rootArray = JArray.Parse(jsonData);
                if (rootArray.Count == 0) return result;

                var headers = rootArray[0]?["headers"]?.ToObject<List<string>>();
                var data = rootArray[0]?["data"]?.ToObject<List<List<string>>>();

                if (headers == null || data == null) return result;

                foreach (var row in data)
                {
                    var scenario = new ScenarioResponse();
                    for (int i = 0; i < headers.Count && i < row.Count; i++)
                    {
                        switch (headers[i].ToLower())
                        {
                            case "seqtactic": scenario.Seqtactic = row[i]; break;
                            case "iduser": scenario.IdUser = row[i]; break;
                            case "seqtec": scenario.Seqtec = row[i]; break;
                            case "score": scenario.Score = row[i]; break;
                        }
                    }
                    result.Add(scenario);
                }

                return result;
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    _httpClient.Dispose();
                    _disposed = true;
                }
            }
        }
    }


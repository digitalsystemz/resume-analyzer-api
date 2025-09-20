using ResumeAnalyzerApi.Interfaces;
using ResumeAnalyzerApi.Models;

namespace ResumeAnalyzerApi.Providers
{
    public class OpenRouterAiProvider : IAiProvider
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public OpenRouterAiProvider(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;

        }

        public async Task<ResumeAnalysisResult> AnalyzeResumeAsync(string resumeText)
        {
            throw new NotImplementedException();
        }
    }
}

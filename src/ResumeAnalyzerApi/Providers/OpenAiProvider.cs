using ResumeAnalyzerApi.Interfaces;
using ResumeAnalyzerApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace ResumeAnalyzerApi.Providers
{
    public class OpenAiProvider : IAiProvider
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public OpenAiProvider(HttpClient httpClient, IConfiguration config)
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

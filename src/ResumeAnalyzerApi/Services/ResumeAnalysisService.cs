using ResumeAnalyzerApi.Interfaces;
using ResumeAnalyzerApi.Models;

namespace ResumeAnalyzerApi.Services
{
    public class ResumeAnalysisService: IResumeAnalysisService
    {
        private readonly IAiProvider _aiProvider;

        public ResumeAnalysisService(IAiProvider aiProvider)
        {
            _aiProvider = aiProvider;
        }

        public async Task<ResumeAnalysisResult> AnalyzeResumeAsync(string resumeText)
        {
            var result = await _aiProvider.AnalyzeResumeAsync(resumeText);
            return result;
        }
    }
}

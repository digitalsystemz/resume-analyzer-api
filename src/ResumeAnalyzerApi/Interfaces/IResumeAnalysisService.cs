using ResumeAnalyzerApi.Models;

namespace ResumeAnalyzerApi.Interfaces
{
    public interface IResumeAnalysisService
    {
        Task<ResumeAnalysisResult> AnalyzeResumeAsync(string resumeText);
    }
}

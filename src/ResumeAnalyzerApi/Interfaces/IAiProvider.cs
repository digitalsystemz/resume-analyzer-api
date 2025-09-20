using ResumeAnalyzerApi.Models;

namespace ResumeAnalyzerApi.Interfaces
{
    public interface IAiProvider
    {
        Task<ResumeAnalysisResult> AnalyzeResumeAsync(string resumeText);
    }
}

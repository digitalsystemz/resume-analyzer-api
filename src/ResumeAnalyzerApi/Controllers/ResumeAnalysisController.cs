using Microsoft.AspNetCore.Mvc;
using ResumeAnalyzerApi.Interfaces;
using ResumeAnalyzerApi.Models;
using ResumeAnalyzerApi.Services;

namespace ResumeAnalyzerApi.Controllers
{
    [ApiController]
    [Route("api/resume")]
    public class ResumeAnalysisController : ControllerBase
    {
        private readonly IResumeAnalysisService _resumeAnalysisService;

        public ResumeAnalysisController(IResumeAnalysisService resumeAnalysisService)
        {
            _resumeAnalysisService = resumeAnalysisService;
        }

        [HttpPost("analyze")]
        public async Task<ActionResult<ResumeAnalysisResult>> Analyze([FromBody] string resumeText)
        {
            if (string.IsNullOrWhiteSpace(resumeText))
                return BadRequest("Resume text is required.");

            var result = await _resumeAnalysisService.AnalyzeResumeAsync(resumeText);
            return Ok(result);
        }
    }
}

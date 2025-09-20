# Resume Analyzer API

A simple **AI-powered Resume Analyzer API** built with **ASP.NET Core 8 Web API**.    
It is designed to be **extensible**. The AI provider is pluggable, you can switch AI providers with minimal effort.

---

## 🚀 Features

- Resume text analysis with AI
- Extracted insights: Summary, Skills, Sentiment, Experience, Suggested Roles, Strengths, Improvement Areas
- Provider abstraction (`IAiProvider`) for easily switching AI backends
- Current default provider: **Google Gemini API** 
- Extensible to OpenAI, OpenRouter, DeepSeek and others

---

## 📦 Providers

### 1. AI Provider Configuration (Google Gemini Default)

- Store the **API key** in an **environment variable**:

```bash
setx AiProvider__ApiKey "YOUR_API_KEY"
```

- Configure **provider name**, **model**, and **endpoint/base URL** in `appsettings.json` (or as env vars if you prefer):

```json
"AiProvider": {
  "ProviderName": "GoogleAiProvider",
  "Model": "gemini-1.5-flash-latest",
  "ApiBaseUrl": "https://generativelanguage.googleapis.com/v1beta"
}
```

---

## 🔧 How to Run

1. Clone the repo into Visual Studio or VS Code.
2. Update `appsettings.json` with your **Google API key**.
3. Run the project:

```bash
dotnet run
```

4. Test endpoint with Postman / curl:

```bash
POST https://localhost:5001/api/resume/analyze
Content-Type: application/json

{
  "resumeText": "John Doe is a software engineer with 8 years experience..."
}
```

5. Sample response:

```json
{
  "summary": "Experienced software engineer with 8 years in .NET, cloud computing, and AI.",
  "skills": ["C#", ".NET Core", "Azure", "AI Integration"],
  "sentiment": "Positive",
  "sentimentScore": 0.87,
  "yearsOfExperience": 8,
  "suggestedRoles": ["Senior Software Engineer", "Technical Lead"],
  "strengths": ["Strong technical expertise", "Leadership"],
  "improvementAreas": ["Add measurable project outcomes"]
}
```

---

## 📌 Roadmap

- ✅ Phase 1: Google Gemini Resume Analysis
- 🔜 Phase 2: Add Job Description input for job fit scoring
- 🔜 Phase 3: Extend to OpenAI, OpenRouter, DeepSeek and others

---

## 📄 License

MIT License

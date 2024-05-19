using CVFPServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CVFPApiPackage.Client
{
    public class CVFPApiClient
    {
        public JobTasksClient JobTasksClient { get; }
        public CandidateClient CandidateClient { get; }
        public CandidateHobbiesClient CandidateHobbiesClient { get; }
        public CandidateLanguagesClient CandidateLanguagesClient { get; }
        public CertificationsFormationsClient CertificationsFormationsClient { get; }
        public ExperiencesClient ExperiencesClient { get; }
        public ExperienceSkillsClient ExperienceSkillsClient { get; }
        public CandidateSkillsClient CandidateSkillsClient { get; }

        public CVFPApiClient(JobTasksClient jobTasksClient, CandidateClient candidateClient, CandidateHobbiesClient candidateHobbiesClient, CandidateLanguagesClient candidateLanguagesClient, CertificationsFormationsClient certificationsFormationsClient, ExperiencesClient experiencesClient, ExperienceSkillsClient experienceSkillsClient, CandidateSkillsClient candidateSkillsClient)
        {
            JobTasksClient = jobTasksClient;
            CandidateClient = candidateClient;
            CandidateHobbiesClient = candidateHobbiesClient;
            CandidateLanguagesClient = candidateLanguagesClient;
            CertificationsFormationsClient = certificationsFormationsClient;
            ExperiencesClient = experiencesClient;
            ExperienceSkillsClient = experienceSkillsClient;
            CandidateSkillsClient = candidateSkillsClient;
        }
    }
}
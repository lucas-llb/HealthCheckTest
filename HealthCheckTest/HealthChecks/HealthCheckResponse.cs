namespace HealthCheckTest.HealthChecks
{
    public class HealthCheckResponse
    {
        public HealthCheckResponse(string applicationStatus) =>
            ApplicationStatus = applicationStatus;

        public string ApplicationStatus { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Testing;

namespace HealthCheckTest.Test
{
    public class Application : WebApplicationFactory<Program>
    {
        public Application() { }
    }
}

namespace DependencyInjectionThroughAutofac.Controllers
{
    public interface IDummyService
    {
        bool IsServiceRunning();

        string GetServiceName();
    }
}
using DILifeTime.Service.Interface;

namespace DILifeTime.Service;

public class ScopeService : ITransientService, IScopedService, ISingletonService
{
    Guid id;
    public ScopeService() {
        id = Guid.NewGuid();
    }
    public Guid GetRandomId()
    {
        return id;
    }
}

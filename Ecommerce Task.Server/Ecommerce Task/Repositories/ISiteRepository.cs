using Ecommerce_Task.Entities;

namespace Ecommerce_Task.Repositories
{
    public interface ISiteRepository
    {
        IEnumerable<Site> GetSites();
    }
}

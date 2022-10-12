using Ecommerce_Task.Entities;
using Ecommerce_Task.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        private readonly ISiteRepository repository;

        public SiteController(ISiteRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Site> GetSitesAsync()
        {
            return repository.GetSites();
        }
    }
}

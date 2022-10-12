using Ecommerce_Task.Entities;

namespace Ecommerce_Task.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        private readonly List<Site> sites = new()
        {
            new Site { Id = 1, Name = "Google", Url = "http://www.google.com",SubData = new Site[] {
            new Site { Id = 2, Name = "Walla", Url = "http://www.walla.co.il" }, 
            new Site { Id = 3, Name = "Ynet", Url = "http://www.ynet.co.il", SubData = new Site[] {
            new Site { Id = 4, Name = "Mako", Url = "http://www.mako.co.il" },
            new Site { Id = 5, Name = "Google", Url = "http://www.google.com" },
            new Site { Id = 6, Name = "Walla", Url = "http://www.walla.co.il" },
                } },
            new Site { Id = 7, Name = "Google", Url = "http://www.google.com" },
            } },

            new Site { Id = 8, Name = "Ynet", Url = "http://www.ynet.co.il",SubData = new Site[] {
            new Site { Id = 9, Name = "Walla", Url = "http://www.walla.co.il" },
                } } ,

            new Site { Id = 10, Name = "Google", Url = "http://www.google.com", SubData = new Site[] {
            new Site { Id = 11, Name = "Ynet", Url = "http://www.ynet.co.il" , SubData = new Site[] {

            new Site { Id = 12, Name = "Walla", Url = "http://www.walla.co.il" },
            new Site { Id = 13, Name = "Google", Url = "http://www.google.com" },
            new Site { Id = 14, Name = "Mako", Url = "http://www.mako.co.il" },
                } }, 
            new Site { Id = 15, Name = "Google", Url = "http://www.google.com" },
            new Site { Id = 16, Name = "Mako", Url = "http://www.mako.co.il" },
            } },
            new Site { Id = 17, Name = "Walla", Url = "http://www.walla.co.il" ,SubData = new Site[] {

            new Site { Id = 18, Name = "Ynet", Url = "http://www.ynet.co.il" },
            new Site { Id = 19, Name = "Google", Url = "http://www.google.com" },
            new Site { Id = 20, Name = "Walla", Url = "http://www.walla.co.il" },
                } },
            new Site { Id = 21, Name = "Mako", Url = "http://www.mako.co.il" },
        };
        
        public IEnumerable<Site> GetSites()
        {
            return sites;
        }
    }
}

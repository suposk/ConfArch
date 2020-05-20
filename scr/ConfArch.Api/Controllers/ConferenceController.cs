using System.Collections.Generic;
using System.Threading.Tasks;
using ConfArch.Data.Models;
using ConfArch.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ConfArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConferenceController : Controller
    {
        private readonly IConferenceRepository repo;

        public ConferenceController(IConferenceRepository repo)
        {

            this.repo = repo;
        }

        public async Task<IEnumerable<ConferenceModel>> GetAll()
        {
            try
            {
                var all = await repo.GetAll();
                return all;
            }
            catch (System.Exception ex)
            {

                //throw;
            }
            return null;
        }

        [HttpPost]
        public void Add(ConferenceModel conference)
        {
            repo.Add(conference);
        }
    }
}

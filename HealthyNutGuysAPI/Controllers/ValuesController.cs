using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthyNutGuysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        public ValuesController(IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            this._configuration = configuration;
            this._userManager = userManager;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            ApplicationUser user = _userManager.Users.Single(u => u.FirstName.Contains("Oskar"));
            UserSubscription sub = user.Subscription;
            // check if user has any valid special offers
            if (sub.SpecialOffers.Any(o => o.ExpireDate < DateTime.Now))
            {
                foreach (SpecialOffer offer in sub.SpecialOffers.Where(o => o.ExpireDate < DateTime.Now))
                {
                    if(offer.AppliesNextOrder != true)
                    {

                    }
                }
            };
            string vaultValue = this._configuration["KeyToSecret"];
            if (vaultValue == null)
            {
                return new string[] { "VaultValueWasNull" };
            }
            return new string[] { "value1", "value2", "NewValue99", $"{vaultValue}" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

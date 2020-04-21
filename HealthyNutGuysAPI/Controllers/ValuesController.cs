﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthyNutGuysAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly IConfiguration _configuration;
    public ValuesController(IConfiguration configuration)
    {
      this._configuration = configuration;
    }
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
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

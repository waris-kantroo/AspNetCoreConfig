using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreConfig.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace AspNetCoreConfig.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
       
        // to read the config values 
        private IConfiguration configuration; //***

        // to read the config values better way
        private readonly IOptions<Settings> appSettings;

        public ValuesController(IConfiguration iConfig,IOptions<Settings> iOptions)  //**
        {  
            configuration = iConfig;
            appSettings = iOptions;
        }

        // GET api/values
        [Produces("application/json")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string dbConnOneWay = configuration.GetSection("Settings").GetSection("DbConnection").Value; //**
            string dbConnTwoWay = configuration.GetValue<string>("Settings:DbConnection"); //**

            string dbConnBetterWay = appSettings.Value.DbConnection;

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

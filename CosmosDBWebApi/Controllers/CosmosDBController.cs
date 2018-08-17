using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CosmosDBWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmosDBController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DocumentClient _client;
        private const string _dbName = "BlopDB";
        private const string _collectionName = "BlopCollection";

        public CosmosDBController(IConfiguration configuration)
        {
            _configuration = configuration;
            var endpointUri = _configuration[];
            var key = _configuration[];
            
        }

    }
}
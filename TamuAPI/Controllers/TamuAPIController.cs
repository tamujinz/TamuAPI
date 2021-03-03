using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using TamuAPI.Model;

namespace TamuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamuAPIController : ControllerBase
    {
        // The Azure Cosmos DB endpoint for running this sample.
        private static readonly string EndpointUri = "https://tamuapi.documents.azure.com:443/";
        // The primary key for the Azure Cosmos account.
        private static readonly string PrimaryKey = "QccUuy6p9kFAjeagbgX5TGz6tYvEnvWnVDkofeE9dQ7VcYUDVH0x6a8NRqSUcePEhKSvfqxYIkQ6MoDG4sF9Fg==";
        private CosmosClient cosmosClient;

        // The database we will create
        private Database database;

        // The container we will create.
        private Container container;

        // The name of the database and container we will create
        private string databaseId = "TamuAPIDatabase";
        private string containerId = "LineMessageContainer";
        [HttpPost]
        public async void PostLineMessage(WebHookEventRequest lineEvent)
        {
            //this.cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
            //this.database = await this.cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
            //this.container = await this.database.CreateContainerIfNotExistsAsync(containerId, "/destination");
            //ItemResponse<WebHookEventRequest> WebHookEventResponse = await this.container.CreateItemAsync<WebHookEventRequest>(lineEvent, new PartitionKey(lineEvent.destination));
        }
    }
}

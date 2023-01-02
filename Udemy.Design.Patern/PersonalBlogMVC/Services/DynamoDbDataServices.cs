using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.Extensions.Options;
using PersonalBlogMVC.Interface;
using PersonalBlogMVC.Models;
using PersonalBlogMVC.Settings;
using System.Text.Json;

namespace PersonalBlogMVC.Services
{
    public class DynamoDbDataServices : IDataService
    {
        private readonly IAmazonDynamoDB _dynamoDb;
        private readonly IOptions<DatabaseSettings> _databaseSettings;

        public DynamoDbDataServices(IAmazonDynamoDB dynamoDb,
        IOptions<DatabaseSettings> databaseSettings)
        {
            _dynamoDb = dynamoDb;
            _databaseSettings = databaseSettings;
        }

        public async Task CreateAsync(Post model)
        {
            var customerAsJson = JsonSerializer.Serialize(model);
            var itemAsDocument = Document.FromJson(customerAsJson);
            var itemAsAttributes = itemAsDocument.ToAttributeMap();

            var createItemRequest = new PutItemRequest
            {
                TableName = _databaseSettings.Value.TableName,
                Item = itemAsAttributes
            };

            await _dynamoDb.PutItemAsync(createItemRequest);
        }

        //public async Task<List<Post>> GetPostsAsync()
        //{
        //    return await _dynamoDb.ScanAsync<Post>( new List<ScanCondition>()).GetRemainingAsync();
        //}
    }
}

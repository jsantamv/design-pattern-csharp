using Amazon.DynamoDBv2.DataModel;
using PersonalBlog.Interface;
using PersonalBlog.Models;

namespace PersonalBlog.Strategies
{
    public class DynamoDbDataServices : IDataService
    {
        private readonly IDynamoDBContext _context;


        public DynamoDbDataServices(IDynamoDBContext context)
        {
            _context = context;
        }

        public async Task Create(Post model)
        {
            await _context.SaveAsync(model);  
        }

        public async Task<List<Post>> GetPosts()
        {
           return await _context.ScanAsync<Post>(new List<ScanCondition>()).GetRemainingAsync();
        }
    }
}

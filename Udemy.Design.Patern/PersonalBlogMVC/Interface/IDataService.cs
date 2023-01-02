using PersonalBlogMVC.Models;

namespace PersonalBlogMVC.Interface
{
    public interface IDataService
    {
        Task Create(Post model);
        Task<List<Post>> GetPosts();
    }
}

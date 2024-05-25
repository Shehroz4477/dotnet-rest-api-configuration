using dotnet_rest_api_configuration.Models;

namespace dotnet_rest_api_configuration.Interfaces;
public interface IPostService
{
    public Task CreatePost(Post post);
    public Task<Post?> UpdatePost(int id, Post post);
    public Task<Post?> GetPost(int id);
    public Task<List<Post>> GetAllPosts();
    public Task<Post?> DeletePost(int id);
}
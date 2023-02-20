using System;
using PostsService.Domain;

namespace PostsService.Services
{
    public interface IPostService
    {
        Task<List<PostEntity>> GetAllPostsAsync();

        Task<PostEntity> GetPostByIdAsync(Guid postId);

        Task<bool> CreatePostAsync(PostEntity newPost);

        Task<bool> UpdatePostAsync(PostEntity postToUpdate);

        Task<bool> DeletePostAsync(Guid postId);
    }
}


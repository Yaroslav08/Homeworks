using System;
using TestLaba.Repositories.Imlp;
using TestLaba.Models;
using System.Threading.Tasks;

namespace TestLaba
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var userRepos = CreateUserRepos();
            var postRepos = CreatePostRepos();

            var user1 = await userRepos.CreateAsync(new User
            {
                Username = "Yarik",
                Fullname = "Yaroslav Mudryk"
            });

            var user2 = await userRepos.CreateAsync(new User
            {
                Username = "Misha",
                Fullname = "Mykhailo Brekhov"
            });

            var postu11 = await postRepos.CreateAsync(new Post
            {
                Text = "Test post 1",
                UserId = user1.Id
            });

            var postu12 = await postRepos.CreateAsync(new Post
            {
                Text = "Test post 2",
                UserId = user1.Id
            });

            var postu21 = await postRepos.CreateAsync(new Post
            {
                Text = "Test post 3",
                UserId = user2.Id
            });

            var postu22 = await postRepos.CreateAsync(new Post
            {
                Text = "Test post 4",
                UserId = user2.Id
            });

            var allUsers = await userRepos.GetAllAsync();

            var allPosts = await postRepos.GetAllAsync();

            var posts1 = await postRepos.GetPostsByUserIdAsync(1);

            var posts2 = await postRepos.GetPostsByUserIdAsync(2);
        }

        static UserRepository CreateUserRepos()
        {
            return new UserRepository();
        }

        static PostRepository CreatePostRepos()
        {
            return new PostRepository();
        }
    }
}

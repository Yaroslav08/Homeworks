using System;
using TestLaba.Repositories.Imlp;
using TestLaba.Models;
using System.Threading.Tasks;
using System.Linq;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace TestLaba
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //var userRepos = CreateUserRepos();
            //var postRepos = CreatePostRepos();

            //var user1 = await userRepos.CreateAsync(new User
            //{
            //    Username = "Yarik",
            //    Fullname = "Yaroslav Mudryk"
            //});

            //var user2 = await userRepos.CreateAsync(new User
            //{
            //    Username = "Misha",
            //    Fullname = "Mykhailo Brekhov"
            //});

            //var postu11 = await postRepos.CreateAsync(new Post
            //{
            //    Text = "Test post 1",
            //    UserId = user1.Id
            //});

            //var postu12 = await postRepos.CreateAsync(new Post
            //{
            //    Text = "Test post 2",
            //    UserId = user1.Id
            //});

            //var postu21 = await postRepos.CreateAsync(new Post
            //{
            //    Text = "Test post 3",
            //    UserId = user2.Id
            //});

            //var postu22 = await postRepos.CreateAsync(new Post
            //{
            //    Text = "Test post 4",
            //    UserId = user2.Id
            //});

            //var allUsers = await userRepos.GetAllAsync();

            //var allPosts = await postRepos.GetAllAsync();

            //var posts1 = await postRepos.GetPostsByUserIdAsync(1);

            //var posts2 = await postRepos.GetPostsByUserIdAsync(2);
            var youtube = new YoutubeClient();
            IYoutubeConverter _youtubeConverter = new YoutubeConverter();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtu.be/2zToEPpFEN8");
            var audioStreamInfo = streamManifest.GetAudio().WithHighestBitrate();
            var videoStreamInfo = streamManifest.GetVideo().FirstOrDefault(s => s.VideoQuality == VideoQuality.High1080);
            var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
            await _youtubeConverter.DownloadAndProcessMediaStreamsAsync(streamInfos, $"D://Downloads//fg.mp4", videoStreamInfo.Container.Name);
            //await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, $"D://Downloads//video.mp4");
            //var builder = new ConversionRequestBuilder("video.mp4").Build();
            //await youtube.Videos.DownloadAsync(streamInfos, builder);
            Console.WriteLine("Video was downloaded");
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

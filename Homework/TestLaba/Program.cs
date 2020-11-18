using System;
using TestLaba.Repositories.Imlp;
using TestLaba.Models;
using System.Threading.Tasks;
using System.Linq;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using TestLaba.Koatuu;
using System.Text;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestLaba
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
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










            //var youtube = new YoutubeClient();
            //IYoutubeConverter _youtubeConverter = new YoutubeConverter();
            //var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtu.be/2zToEPpFEN8");
            //var audioStreamInfo = streamManifest.GetAudio().WithHighestBitrate();
            //var videoStreamInfo = streamManifest.GetVideo().FirstOrDefault(s => s.VideoQuality == VideoQuality.High1080);
            //var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
            //await _youtubeConverter.DownloadAndProcessMediaStreamsAsync(streamInfos, $"D://Downloads//fg.mp4", videoStreamInfo.Container.Name);
            //await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, $"D://Downloads//video.mp4");
            //var builder = new ConversionRequestBuilder("video.mp4").Build();
            //await youtube.Videos.DownloadAsync(streamInfos, builder);
            //Console.WriteLine("Video was downloaded");










            //KoatuuManager manager = new KoatuuManager();
            //await manager.LoadData();
            //var cities = manager.GetCitiesByName("М.Київ").OrderBy(d=>d.Name);
            //Console.WriteLine($"Founded {cities.Count()} cities");
            //foreach (var city in cities)
            //{
            //    Console.WriteLine($"Id: {city.Id}, Name: {city.Name}");
            //}












            var spotify = new SpotifyClient("BQDrSdRsQKYrW3z28pyhmP2YLWfv-Ibe_wPrlAGPtFo8D2-hKLvbHQO8C59ZR-km3QaEhHaIhO-XKv-iCTV1x3h7zolXvXSaqKzkV6cM3ucGv2Yw5z_80tfi1rDVNujR21a5nL-XEyXcW7oa7mmCAiXx5i57e61gGTLuWBa7tcygkyLJlg");
            var search = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.All, "Roses"));
            var tracks = search.Tracks.Items;
            var firstTrack = tracks.FirstOrDefault();
            Process.Start(new ProcessStartInfo(firstTrack.PreviewUrl) { UseShellExecute = true });





            //var loginRequest = new LoginRequest(
            //  new Uri("http://localhost:5000/callback"),
            //  "913a4b9d961f4ea39d3f94e71afe065e",
            //  LoginRequest.ResponseType.Code)
            //{
            //    Scope = new[] { Scopes.PlaylistReadPrivate, Scopes.PlaylistReadCollaborative }
            //};
            //var uri = loginRequest.ToUri();

            //_server = new EmbedIOAuthServer(new Uri("http://localhost:5000/callback"), 5000);
            //await _server.Start();

            //_server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;

            //var request = new LoginRequest(_server.BaseUri, "913a4b9d961f4ea39d3f94e71afe065e", LoginRequest.ResponseType.Code)
            //{
            //    Scope = new List<string> { Scopes.UserReadEmail }
            //};
            //BrowserUtil.Open(uri);

            //Console.ReadKey();
        }
        //private static EmbedIOAuthServer _server;
        //private static async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
        //{
        //    await _server.Stop();

        //    var config = SpotifyClientConfig.CreateDefault();
        //    var tokenResponse = await new OAuthClient(config).RequestToken(
        //      new AuthorizationCodeTokenRequest(
        //        "913a4b9d961f4ea39d3f94e71afe065e", "f16b272b37164b09a95cfc4aade536d1", response.Code, new Uri("http://localhost:5000/callback")
        //      )
        //    );

        //    var spotify = new SpotifyClient(tokenResponse.AccessToken);
        //    var user = await spotify.UserProfile.Current();
        //    Console.WriteLine(user.Email);
        //}


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

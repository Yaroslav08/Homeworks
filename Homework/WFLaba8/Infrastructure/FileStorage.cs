using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
namespace WFLaba8.Infrastructure
{
    public class FileStorage : IStorage
    {
        private const string Path = "settings.json";

        public Task DownloadAsync(Content content)
        {
            var json = JsonSerializer.Serialize(content);
            using var sw = new StreamWriter(Path);
            sw.WriteLineAsync(json);
            sw.Dispose();
            return Task.CompletedTask;
        }

        public async Task<Content> UploadAsync()
        {
            if (!File.Exists(Path))
                return null;
            using var sr = new StreamReader(Path);
            var json = await sr.ReadToEndAsync();
            var content = JsonSerializer.Deserialize<Content>(json);
            return content;
        }
    }
}
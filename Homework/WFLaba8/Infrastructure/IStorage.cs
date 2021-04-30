using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLaba8.Infrastructure
{
    public interface IStorage
    {
        Task<Content> UploadAsync();
        Task DownloadAsync(Content content);
    }
}

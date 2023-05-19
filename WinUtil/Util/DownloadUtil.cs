using Serilog;
using WinUtil.Model;

namespace WinUtil.Util
{
    public static class DownloadUtil
    {
        public static async Task DownloadUrlsAsync(List<DownloadFileInfo> urls, int limit)
        {
            using (var client = new HttpClient())
            {
                using (var semaphore = new SemaphoreSlim(limit, limit))
                {
                    var tasks = urls.Select(url => DownloadUrlHelperAsync(url.URL, url.FilePath, semaphore, client)).ToArray();
                    await Task.WhenAll(tasks).ConfigureAwait(false);
                }
            }
        }

        static async Task DownloadUrlHelperAsync(string url, string filePath, SemaphoreSlim semaphore, HttpClient client)
        {
            await semaphore.WaitAsync().ConfigureAwait(false);

            try
            {
                using (var response = await client.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] data = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                        using var stream = File.Create(filePath);
                        stream.Write(data);
                        Log.Information("Successfully downloaded '" + url + "' to '" + filePath + "'.");
                    }
                    else
                    {
                        Log.Error("Failed to download '" + url + "'. Status code of the http response: '" + response.StatusCode + "'.");
                    }
                }
            }
            finally
            {
                semaphore.Release();
            }
        }

        public static async Task<ICollection<(string url, byte[] data)>> DownloadUrlsAsync(IEnumerable<string> urls, int limit)
        {
            using (var client = new HttpClient())
            {
                using (var semaphore = new SemaphoreSlim(limit, limit))
                {
                    var tasks = urls.Select(url => DownloadUrlHelperAsync(url, semaphore, client)).ToArray();
                    await Task.WhenAll(tasks).ConfigureAwait(false);
                    return tasks.Select(x => x.Result).ToArray();
                }
            }
        }

        static async Task<(string url, byte[] data)> DownloadUrlHelperAsync(string url, SemaphoreSlim semaphore, HttpClient client)
        {
            await semaphore.WaitAsync().ConfigureAwait(false);

            try
            {
                using (var response = await client.GetAsync(url).ConfigureAwait(false))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] data = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                        return (url, data);
                    }
                    else
                    {
                        return (url, null);
                    }
                }
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}

using Serilog;
using WinUtil.Model;

namespace WinUtil.Util
{
    /// <summary>
    /// Utility class with functions for downloading files
    /// </summary>
    public static class DownloadUtil
    {
        public static string[] FileExtensionList = {"jpg", "jpeg", "bmp", "png", "gif", "ico", "svg",
                                    "mp4", "webm", "avi", "mpg", "mpeg", "wmv", "mkv", "flv",
                                    "mp3", "flac", "wav", "mv4",
                                    "txt","xml", "bin", "dat", "csv", "mdb", "log",
                                    "doc", "xls", "ppt", "odp", "ods", "odt",
                                    "zip","7z", "rar", "tar",
                                    "msi", "exe",
                                    "pdf",
                                    "html", "htm", "php"};

        /// <summary>
        /// asyncronously downloads a list of files
        /// </summary>
        /// <param name="urls">list of files</param>
        /// <param name="limit">max. number of simultaneous downloads</param>
        /// <returns></returns>
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

        /// <summary>
        /// downloads a specific file
        /// </summary>
        /// <param name="url">the url of the file</param>
        /// <param name="filePath">the absolute filepath / where the file is supposed to be saved</param>
        /// <param name="semaphore"></param>
        /// <param name="client">the web client to be used for downloading the data</param>
        /// <returns></returns>
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
                        return (url, new byte[0]);
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

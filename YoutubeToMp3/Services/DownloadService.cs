using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeToMp3.Models;

namespace YoutubeToMp3.Services;

internal class DownloadService
{
    private readonly YoutubeClient _youtubeClient;
    public DownloadService()
    {
        _youtubeClient = new YoutubeClient();
    }

    /// <summary>
    /// Downloads video from YouTube to provided save path.
    /// </summary>
    /// <param name="url">YouTube video url.</param>
    /// <param name="savePath">Save path for downloaded video.</param>
    /// <param name="progress">Progress object for reporting progress.</param>
    /// <returns><see cref="VideoDownloadResult"/> object with download result data.</returns>
    public async Task<VideoDownloadResult> DownloadYouTubeVideoAsync(string url, string savePath, IProgress<int> progress)
    {
        try
        {
            progress.Report(10);

            var videoMetadata = await _youtubeClient.Videos.GetAsync(url).ConfigureAwait(false);

            progress.Report(20);

            if (videoMetadata == null)
            {
                return new VideoDownloadResult(false, "", "", "", "There was an error while trying to download YouTube video! Please check video Url and try again!");
            }

            var videoSavePath = $@"{savePath}\{videoMetadata.Title}.mp4";

            var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(url).ConfigureAwait(false);

            progress.Report(30);

            var audioStream = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

            var realStream = await _youtubeClient.Videos.Streams.GetAsync(audioStream).ConfigureAwait(false);

            progress.Report(40);

            await _youtubeClient.Videos.Streams.DownloadAsync(audioStream, videoSavePath).ConfigureAwait(false);

            progress.Report(50);

            bool fileExists = File.Exists(videoSavePath);

            // Getting additional metadata.
            var bestThumbnailUrl = videoMetadata.Thumbnails.Where(vm => !vm.Url.Contains(".webp")).OrderByDescending(thumb => thumb.Resolution.Area).FirstOrDefault()?.Url;

            return new VideoDownloadResult(DownloadSuccessful: fileExists, VideoTitle: videoMetadata.Title, VideoPath: videoSavePath, VideoThumbnailUrl: bestThumbnailUrl, ErrorMessage: !fileExists ? "There was an error while trying to download video!" : "");
        }
        catch (Exception ex)
        {
            return new VideoDownloadResult(false, "", "", "", $"There was an error while trying to download video! Additional info: {ex.Message}.");
        }
    }
}

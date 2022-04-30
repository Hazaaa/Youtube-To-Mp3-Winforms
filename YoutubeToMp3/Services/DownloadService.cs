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
    /// <returns><see cref="VideoDownloadResult"/> object with download result data.</returns>
    public async Task<VideoDownloadResult> DownloadYouTubeVideoAsync(string url, string savePath)
    {
        try
        {
            var videoMetadata = await _youtubeClient.Videos.GetAsync(url);

            if (videoMetadata == null)
            {
                return new VideoDownloadResult(false, "", "", "There was an error while trying to download YouTube video! Please check video Url and try again!");
            }

            var videoSavePath = $@"{savePath}\{videoMetadata.Title}.mp4";

            var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(url);

            var audioStream = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

            var realStream = await _youtubeClient.Videos.Streams.GetAsync(audioStream);

            await _youtubeClient.Videos.Streams.DownloadAsync(audioStream, videoSavePath);

            bool fileExists = File.Exists(videoSavePath);

            return new VideoDownloadResult(DownloadSuccessful: fileExists, VideoTitle: videoMetadata.Title, VideoPath: videoSavePath, ErrorMessage: !fileExists ? "There was an error while trying to download video!" : "");
        }
        catch (Exception ex)
        {
            return new VideoDownloadResult(false, "", "", $"There was an error while trying to download video! Additional info: {ex.Message}.");
        }
    }
}

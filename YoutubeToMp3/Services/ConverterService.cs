using System.Diagnostics;
using YoutubeToMp3.Models;

namespace YoutubeToMp3.Services;

public class ConverterService
{
    private readonly DownloadService _downloadService;
    private const string FFMPEGPath = @".\Resources\ffmpeg.exe";
    public ConverterService()
    {
        _downloadService = new DownloadService();
    }

    /// <summary>
    /// Converts YouTube video to mp3 and saves it to provided save path.
    /// </summary>
    /// <param name="videoUrl">Url of YouTube video.</param>
    /// <param name="savePath">Save path for mp3.</param>
    /// <returns><see cref="VideoConvertResult"/> object with convert result data.</returns>
    public async Task<VideoConvertResult> ConvertYouTubeVideoToMp3Async(string videoUrl, string savePath)
    {
        try
        {
            var videoDownloadResult = await _downloadService.DownloadYouTubeVideoAsync(videoUrl, savePath);

            if (!videoDownloadResult.DownloadSuccessful)
            {
                return new VideoConvertResult(false, "", "", ErrorMessage: videoDownloadResult.ErrorMessage);
            }

            var mp3SavePath = $@"{savePath}\{videoDownloadResult.VideoTitle}.mp3";

            ConvertMp4ToMp3File(videoDownloadResult.VideoPath, mp3SavePath);

            if (!File.Exists(mp3SavePath))
            {
                DeleteDownloadedVideo(videoDownloadResult.VideoPath);
                return new VideoConvertResult(false, "", "", "There was an error while trying to convert YouTube video! Please check video Url and try again!");
            }

            DeleteDownloadedVideo(videoDownloadResult.VideoPath);

            return new VideoConvertResult(true, FilePath: mp3SavePath, FileThumbnailUrl: videoDownloadResult.VideoThumbnailUrl, "");
        }
        catch (Exception ex)
        {
            return new VideoConvertResult(false, "", "", $"There was an error while trying to convert YouTube video to mp3! Additional info: {ex.Message}");
        }
    }

    /// <summary>
    /// Converts Mp4 file to Mp3 file using FFMPEG. It will overwrite existing file.
    /// </summary>
    /// <returns>True if convert is successful, otherwise false.</returns>
    private static void ConvertMp4ToMp3File(string mp4Path, string mp3SavePath)
    {
        if (File.Exists(mp3SavePath))
        {
            File.Delete(mp3SavePath);
        }

        var ffmpeg = new Process
        {
            StartInfo = { UseShellExecute = false, RedirectStandardError = true, FileName = FFMPEGPath, CreateNoWindow = true },
        };

        var arguments =
            String.Format(
                @"-i ""{0}"" -vn -ac 2 -b:a 192k ""{1}""",
                mp4Path, mp3SavePath);

        ffmpeg.StartInfo.Arguments = arguments;

        try
        {
            if (!ffmpeg.Start())
            {
                Debug.WriteLine("Error starting ffmpeg script!");
                return;
            }
            var reader = ffmpeg.StandardError;
            string line;
            while ((line = reader.ReadLine()!) != null)
            {
                Debug.WriteLine(line);
            }
        }
        catch (Exception exception)
        {
            Debug.WriteLine(exception.ToString());
            return;
        }

        ffmpeg.Close();
    }

    /// <summary>
    /// Deletes temporary downloaded video.
    /// </summary>
    /// <param name="videoPath">Path to downloaded video.</param>
    private void DeleteDownloadedVideo(string videoPath)
    {
        if (File.Exists(videoPath))
        {
            File.Delete(videoPath);
        }
    }
}

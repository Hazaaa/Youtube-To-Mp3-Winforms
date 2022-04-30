namespace YoutubeToMp3.Models;

public record VideoDownloadResult(bool DownloadSuccessful, string VideoTitle, string VideoPath, string ErrorMessage);

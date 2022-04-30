namespace YoutubeToMp3.Models;

public record VideoConvertResult(bool ConvertSuccessful, string FilePath, string ErrorMessage);

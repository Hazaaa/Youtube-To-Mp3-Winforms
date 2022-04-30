namespace YoutubeToMp3.Helpers;

public static class TimeHelpers
{
    public static string ConvertSecondToMinutes(int seconds)
    {
        int minutes = seconds / 60;
        int leftSeconds = seconds - (minutes * 60);

        return $"{(minutes < 10 ? '0' : "")}{minutes}:{(leftSeconds < 10 ? '0' : "")}{leftSeconds}";
    }
}

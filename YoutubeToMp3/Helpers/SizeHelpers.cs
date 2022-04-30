namespace YoutubeToMp3.Helpers;

/// <summary>
/// Helper class for Size conversion.
/// </summary>
public static class SizeHelpers
{
    /// <summary>
    /// Converts bytes to megabytes.
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns>Value in megabytes.</returns>
    public static double ConvertBytesToMegabytes(long bytes)
    {
        return (bytes / 1024f) / 1024f;
    }
}

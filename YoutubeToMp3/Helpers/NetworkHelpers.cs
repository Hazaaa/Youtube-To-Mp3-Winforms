using System.Net.NetworkInformation;

namespace YoutubeToMp3.Helpers;

public static class NetworkHelpers
{
    public static async Task<bool> CheckInternetConnectionAsync()
    {
        using var ping = new Ping();
        var reply = await ping.SendPingAsync("www.google.com");
        return reply != null && reply.Status == IPStatus.Success;
    }
}

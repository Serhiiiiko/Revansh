namespace RevMVC.Security;
// Middleware for Anti-DDoS
public class RateLimitingMiddleware
{
    private readonly RequestDelegate _next;
    private static readonly Dictionary<string, DateTime> RequestTimestamps = new Dictionary<string, DateTime>();

    public RateLimitingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var ipAddress = context.Connection.RemoteIpAddress?.ToString();
        if (ipAddress != null)
        {
            if (RequestTimestamps.TryGetValue(ipAddress, out var lastRequest))
            {
                if (DateTime.Now.Subtract(lastRequest).TotalMilliseconds < 4000)
                {
                    context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                    return;
                }
            }
            RequestTimestamps[ipAddress] = DateTime.Now;
        }
        await _next(context);
    }
}
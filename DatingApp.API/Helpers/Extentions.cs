using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extentions
    {
       public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("ApplicationError", message);
            response.Headers.Add("Access-Control-Message-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}
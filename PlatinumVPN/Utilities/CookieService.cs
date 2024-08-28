using System;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;

namespace PlatinumVPN.Utilities
{
    public partial class CookieService
    {
        [JSImport("setCookie", "test.js")]
        public static partial Task SetCookie(string name, string value, int days);
        [JSImport("getCookie", "test.js")]
        public static partial Task<string> GetCookie(string name);
        public async Task SetUserCookie()
        {
            // Set a cookie with the name "username", value "JohnDoe", and expiration of 7 days
            await SetCookie("username", "JohnDoe", 7);
        }
        //private readonly IJSRuntime _jsRuntime;

        //public CookieService(IJSRuntime jsRuntime)
        //{
        //    _jsRuntime = jsRuntime;
        //}

        //public async Task<string> GetCookie(string key)
        //{
        //    return await _jsRuntime.InvokeAsync<string>("getCookie", key);
        //}

        //public async Task SetCookie(string key, string value, int expirationDays)
        //{
        //    await _jsRuntime.InvokeVoidAsync("setCookie", key, value, expirationDays);
        //}
    }
}

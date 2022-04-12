using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net.Http;

namespace Utilities.Extensions
{
    public static class HttpClientExtensions
    {
        public static string GetSynchronously(this HttpClient httpClient, Uri uri)
        {
            return httpClient.GetStringAsync(uri).Result;
        }
    }
}

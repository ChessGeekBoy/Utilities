using System;
using System.Management.Automation;
using System.Net.Http;

namespace Utilities.Cmdlets
{
    [Cmdlet(VerbsLifecycle.Invoke, "RestMethodAsync")]
    public class InvokeRestMethodAsyncCommand : PSCmdlet
    {
        [Parameter(Position = 0,
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "The URI for the HTTP request to be sent to.")]
        public Uri Uri { get; set; }

        [Parameter(Position = 1,
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "The REST method to be invoked.")]
        public HttpMethod Method { get; set; } = HttpMethod.Get;

        [Parameter(Position = 2,
            ValueFromPipeline = true,
            Mandatory = false,
            HelpMessage = "The content of the HTTP request.")]
        public HttpContent HttpContent { get; set; }

        protected override async void ProcessRecord()
        {
            HttpClient httpClient = new HttpClient();

            switch (this.Method)
            {
                case HttpMethod.Get:
                    WriteObject(await httpClient.GetAsync(this.Uri));
                    break;
                case HttpMethod.Post:
                    await httpClient.PostAsync(this.Uri, this.HttpContent);
                    break;
                case HttpMethod.Patch:
                    await httpClient.PatchAsync(this.Uri, this.HttpContent);
                    break;
                case HttpMethod.Put:
                    await httpClient.PutAsync(this.Uri, this.HttpContent);
                    break;
                default:
                    break;
            }
        }
    }

    public enum HttpMethod
    {
        Get,
        Post,
        Patch,
        Put,
        Delete
    }
}



using DeliverEatRevamp.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace DeliverEatRevamp.Controllers
{
    public class WebHookApiController : ApiController
    {

        [HttpPost]
        public void CheckStatusV3(CyberSourceHook data)
        {
            string strTemp = HttpContext.Current.Server.MapPath("~/");
            // Get JSON from WebHook
            string path = String.Format("{0}\\{1}", strTemp, "log1.txt");
            StreamWriter sw = new StreamWriter(path, true);
            foreach (var prop in data.GetType().GetProperties())
            {
                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(data, null));
                sw.WriteLine(prop.Name+ " " + prop.GetValue(data, null));
            }
            sw.Flush();
            sw.Close();
        }
            //public  async Task<IHttpActionResult> Receive()
            //{
            //    await th
            //}
            //private  IHttpActionResult Index ()
            //{
            //    var httpResponse = await httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

            //    httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299

            //    if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            //    {
            //        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

            //         var streamReader = new StreamReader(contentStream);
            //         var jsonReader = new JsonTextReader(streamReader);

            //        JsonSerializer serializer = new JsonSerializer();

            //        try
            //        {
            //            return serializer.Deserialize<IHttpActionResult>(jsonReader);
            //        }
            //        catch (JsonReaderException)
            //        {
            //            Debug.WriteLine("Invalid JSON.");
            //        }
            //    }
            //    else
            //    {
            //        Debug.WriteLine("HTTP Response was invalid and cannot be deserialised.");
            //    }

            //    return null;
            //}

            //private Task<IHttpActionResult> StreamWithNewtonsoftJson1(string uri, HttpClient httpClient)
            //{
            //    var httpResponse = await httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

            //    httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299

            //    if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            //    {
            //        var contentStream = await httpResponse.Content.ReadAsStreamAsync();

            //        var streamReader = new StreamReader(contentStream);
            //        var jsonReader = new JsonTextReader(streamReader);

            //        JsonSerializer serializer = new JsonSerializer();

            //        try
            //        {
            //            return serializer.Deserialize<IHttpActionResult>(jsonReader);
            //        }
            //        catch (JsonReaderException)
            //        {
            //            Debug.WriteLine("Invalid JSON.");
            //        }
            //    }
            //    else
            //    {
            //        Debug.WriteLine("HTTP Response was invalid and cannot be deserialised.");
            //    }

            //    return null;
            //}

        }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

using System.Web.Configuration;
using System.Web.Http;

using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

using Newtonsoft.Json;
using Microsoft.AspNet.WebHooks;

namespace DeliverEatRevamp
{
    public class MyWebHookHandler : WebHookHandler
    {
        public static string dataReceived;
        public MyWebHookHandler()
        {
            this.Receiver = "genericjson";
        }

        [HttpPost]
        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            try
            {
                // Get JSON from WebHook
           //     CyberSourceHook test = new CyberSourceHook();
                JObject data = context.GetDataOrDefault<JObject>();
                StreamWriter sw = new StreamWriter("log1.txt", true);
                sw.WriteLine(data);
           //     CyberSourceHook request = JsonConvert.DeserializeObject<CyberSourceHook>(data.Root.ToString());
                if (context.Id == "i")
                {
                    // do stuff
                }
                else if (context.Id == "z")
                {
                    // do more stuff
                   // dataReceived = request.data;


                    sw.WriteLine(dataReceived);
                    sw.Flush();
                    sw.Close();
                }


            }
            catch (Exception ex)
            {

            }
            return Task.FromResult(true);
        }

    }
}

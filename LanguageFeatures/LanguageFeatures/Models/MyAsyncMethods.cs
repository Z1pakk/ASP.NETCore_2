using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLenght()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://google.com.ua");

            return httpMessage.Content.Headers.ContentLength;
        }
    }
}

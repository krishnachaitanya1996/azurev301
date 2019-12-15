using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace MyStayMVC.Utility
{
    public class HelperClass
    {
        public static async Task<T> httpGetTAsync<T>(string URL) where T : new()
        {
            T lst = new T();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Constants.API_URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseMessage = client.GetAsync(URL).Result;

                    if(responseMessage.IsSuccessStatusCode)
                    {
                        var result = await responseMessage.Content.ReadAsStringAsync();

                        if (result != null)
                        {
                            lst = JsonConvert.DeserializeObject<T>(result);
                        }
                    }

                    else if (responseMessage.StatusCode.Equals(HttpStatusCode.NotFound)) { };

                    return lst;
                }
            }
            catch (Exception ex)
            {
                return lst;
                throw ex;
            }
        }

        public static async Task<int> httpPostAysnc<T>(T oOjbect, string url)
        {
            int response = 0;
            try
            {
                using (var client = new HttpClient())
                {
                    string JSON = JsonConvert.SerializeObject(oOjbect);
                    HttpContent httpContent = new StringContent(JSON, UnicodeEncoding.UTF8, "application/json"); ;
                    client.BaseAddress = new Uri(Constants.API_URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseCheckIn = client.PostAsync(url, httpContent).Result;

                    if (responseCheckIn.IsSuccessStatusCode)
                    {
                        var checkinResult =await responseCheckIn.Content.ReadAsStringAsync();

                        if (checkinResult != null)
                        {
                            response = JsonConvert.DeserializeObject<int>(checkinResult);
                        }
                    }
                    else if (responseCheckIn.StatusCode == HttpStatusCode.NotFound) { }

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<T> httpGetAsyncFilter<T>(object oObject, string url) where T : new()
        {
            T lst = new T();
            try
            {

                using (var client = new HttpClient())
                {
                    string JSON = JsonConvert.SerializeObject(oObject);
                    HttpContent httpContent = new StringContent(JSON, UnicodeEncoding.UTF8, "application/json"); ;
                    client.BaseAddress = new Uri(Constants.API_URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseCheckIn = client.PostAsync(url, httpContent).Result;

                    if (responseCheckIn.IsSuccessStatusCode)
                    {
                        var result = await responseCheckIn.Content.ReadAsStringAsync();

                        if (result != null)
                        {
                            lst = JsonConvert.DeserializeObject<T>(result.ToString());
                        }
                    }
                    else if (responseCheckIn.StatusCode == HttpStatusCode.NotFound) { }

                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<int> httpAzurePostAysnc<T>(T oOjbect, string url)
        {
            int response = 0;
            try
            {
                using (var client = new HttpClient())
                {
                    string JSON = JsonConvert.SerializeObject(oOjbect);
                    HttpContent httpContent = new StringContent(JSON, UnicodeEncoding.UTF8, "application/json"); ;
                    client.BaseAddress = new Uri(Constants.AzureFunctions_URL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseCheckIn = client.PostAsync(url, httpContent).Result;

                    if (responseCheckIn.IsSuccessStatusCode)
                    {
                        var checkinResult = await responseCheckIn.Content.ReadAsStringAsync();

                        if (checkinResult != null)
                        {
                            response = JsonConvert.DeserializeObject<int>(checkinResult);
                        }
                    }
                    else if (responseCheckIn.StatusCode == HttpStatusCode.NotFound) { }

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

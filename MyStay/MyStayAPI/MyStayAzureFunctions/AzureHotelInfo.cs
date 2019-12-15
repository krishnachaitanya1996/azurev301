using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MyStayAzureFunctions
{
    public static class AzureHotelInfo
    {
        [FunctionName("AzureHotelInfo")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var rows = 0;
            dynamic body = await req.Content.ReadAsStringAsync();
            HotelInfo hotelInfo = JsonConvert.DeserializeObject<HotelInfo>(body as string);

            // Get the connection string from app settings and use it to create a connection.
            var ConnectionString = Environment.GetEnvironmentVariable("HotelDatabase", EnvironmentVariableTarget.Process);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var text = string.Format("INSERT INTO HOTELINFO VALUES('{0}','{1}')", hotelInfo.Name, hotelInfo.Address);

                using (SqlCommand cmd = new SqlCommand(text, conn))
                {
                    // Execute the command and log the # rows affected.
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return rows == 0
                ? req.CreateResponse(HttpStatusCode.BadRequest, 0)
                : req.CreateResponse(HttpStatusCode.OK, 1);
        }
    }

    public class HotelInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assignment
{
    public class AssignmentService
    {
        private readonly HttpClient client = new HttpClient();
        public AssignmentService()
        {
            client.BaseAddress = new Uri("https://api.fda.gov/food/enforcement.json?search=report_date:%5b20040101+TO+20131231%5d&limit=1");
        }


        public async Task<string> GetResponse()
        {
            HttpResponseMessage response = await client.GetAsync(string.Empty);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            return string.Empty;
        }
    }
}

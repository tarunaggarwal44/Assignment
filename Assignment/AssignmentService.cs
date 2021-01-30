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
            client.BaseAddress = new Uri("https://api.fda.gov/food/");
        }


        public async Task<string> GetResponse(string startDate, string endDate)
        {
            var formatUrl = @"enforcement.json?search=report_date:%5b" + startDate + "+TO+" + endDate + "%5d&limit=1";
            HttpResponseMessage response = await client.GetAsync(formatUrl);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            return string.Empty;
        }
    }
}

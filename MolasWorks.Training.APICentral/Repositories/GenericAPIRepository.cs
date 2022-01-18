using MolasWorks.Training.APICentral.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.Repositories
{
    public class GenericAPIRepository : BaseRepository
    {
        private readonly RestClient _restClient;

        public GenericAPIRepository(RestClient restClient) : base(restClient)
        {
            _restClient = restClient;
        }

        public async Task<string> GetResponse(string url)
        {
            var request = new RestRequest(url);
            var response = await _restClient.ExecuteAsync(request);
            return response.Content;
        }
    }
}

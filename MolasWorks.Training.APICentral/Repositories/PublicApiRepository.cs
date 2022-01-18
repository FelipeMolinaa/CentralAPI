using MolasWorks.Training.APICentral.Models;
using RestSharp;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.Repositories
{
    public class PublicApiRepository : BaseRepository
    {
        

        private readonly RestClient _restClient;

        public PublicApiRepository(RestClient restClient) : base(restClient)
        {
            _restClient = restClient;
        }

        public async Task<PublicAPIResponse> GetAll() {
            var request = new RestRequest("entries");
            var response = await _restClient.GetAsync<PublicAPIResponse>(request);
            return response;
        }
    }
}

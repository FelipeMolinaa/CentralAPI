using MolasWorks.Training.APICentral.AppServices.Interfaces;
using MolasWorks.Training.APICentral.ConsumingApi;
using MolasWorks.Training.APICentral.Services.Interfaces;
using Refit;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.AppServices
{
    public class PublicAPIAppService
    {
        private readonly RestClient _restClient;

        public PublicAPIAppService(string url)
        {
            _restClient = new RestClient(url);
        }

        public async Task<PublicAPIResponse> GetAll() {
            var request = new RestRequest("/entries");
            var response = await _restClient.GetAsync<PublicAPIResponse>(request);
            return response;
        }
    }
}

using RestSharp;
using System.Net.Http;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.Repositories
{
    public class BaseRepository
    {
        private readonly RestClient _restClient;

        public BaseRepository(RestClient restClient)
        {
            _restClient = restClient;

        }
    }
}
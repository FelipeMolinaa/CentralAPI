using MolasWorks.Training.APICentral.ConsumingApi;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.Services.Interfaces
{
    public interface IPublicApiService
    {
        [Get("/entries")]
        Task<PublicAPIResponse> GetAll();
    }
}

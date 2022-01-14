using MolasWorks.Training.APICentral.ConsumingApi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MolasWorks.Training.APICentral.AppServices.Interfaces
{
    public interface IPublicAPIAppService
    {
        Task<PublicAPIResponse> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MolasWorks.Training.APICentral.Services.Interfaces
{
    public interface IHTTPClientHandlerCreationService
    {
        HttpClientHandler GetInsecureHandler();
    }
}

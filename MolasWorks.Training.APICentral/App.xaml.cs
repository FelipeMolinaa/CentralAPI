using MolasWorks.Training.APICentral.Repositories;
using MolasWorks.Training.APICentral.Controls;
using MolasWorks.Training.APICentral.DAO;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Xamarin.Forms;
using RestSharp;

namespace MolasWorks.Training.APICentral
{
    public partial class App : Application
    {
        

        private static PublicApiDAORepository publicApiDAORepository;
        public static PublicApiDAORepository PublicApiDAORepository { 
            get {
                if (publicApiDAORepository == null) {
                    publicApiDAORepository = new PublicApiDAORepository(
                        Path.Combine(Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData), "PublicAPI.db3"));
                }
                return publicApiDAORepository;
            } 
        }

        public static HttpClient HttpClient {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android: return new HttpClient(
                        DependencyService.Get<Services.Interfaces.IHTTPClientHandlerCreationService>()
                            .GetInsecureHandler());
                    default:
                        ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicy) => true;
                        return new HttpClient(new HttpClientHandler());
                }
            }
        }

        private static string _publicApiRepositoryUrl = "https://api.publicapis.org";
        private static PublicApiRepository _publicApiRepository;
        public static PublicApiRepository PublicApiRepository
        {
            get
            {
                if (_publicApiRepository == null)
                {
                    var restClient = new RestClient(HttpClient, new RestClientOptions(_publicApiRepositoryUrl));
                    _publicApiRepository = new PublicApiRepository(restClient);
                }
                return _publicApiRepository;
            }
        }

        private static GenericAPIRepository _genericAPIRepository;
        public static GenericAPIRepository GenericAPIRepository
        {
            get
            {
                if (_genericAPIRepository == null)
                {
                    var restClient = new RestClient(HttpClient);
                    _genericAPIRepository = new GenericAPIRepository(restClient);
                }
                return _genericAPIRepository;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MenuPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

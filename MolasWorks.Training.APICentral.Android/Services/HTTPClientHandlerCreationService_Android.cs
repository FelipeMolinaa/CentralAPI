using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Javax.Net.Ssl;
using MolasWorks.Training.APICentral.Droid.Services;
using MolasWorks.Training.APICentral.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Android.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(HTTPClientHandlerCreationService_Android))]
namespace MolasWorks.Training.APICentral.Droid.Services
{
    class HTTPClientHandlerCreationService_Android : IHTTPClientHandlerCreationService
    {
        public HttpClientHandler GetInsecureHandler()
        {
            return new IgnoreSSLClientHandler();
        }
    }

    public class IgnoreSSLClientHandler : AndroidClientHandler
    {
        protected override SSLSocketFactory ConfigureCustomSSLSocketFactory(HttpsURLConnection connection)
        {
            return SSLCertificateSocketFactory.GetInsecure(1000, null);
        }

        protected override IHostnameVerifier GetSSLHostnameVerifier(HttpsURLConnection connection)
        {
            return new IgnoreSSLHostNameVerifier();
        }
    }

    internal class IgnoreSSLHostNameVerifier : Java.Lang.Object, IHostnameVerifier
    {
        public bool Verify(string hostname, ISSLSession session)
        {
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Foundation;
using UIKit;

namespace MolasWorks.Training.APICentral.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}

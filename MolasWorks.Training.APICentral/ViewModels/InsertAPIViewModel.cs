using FreshMvvm;
using MolasWorks.Training.APICentral.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MolasWorks.Training.APICentral.ViewModels
{
    sealed class InsertAPIViewModel : BaseViewModel
    {
        public string FormMessages { get; set; }
        public string APIName { get; set; }
        public string AuthType { get; set; }
        public string ConnectionURL { get; set; }
        public string Description { get; set; }
        public bool CORS { get; set; }
        public bool HTTPS { get; set; }

        public ICommand InsertPublicAPI
        {
            get => new Command(() => HandleSubmitAPI());
        }

        public async void HandleSubmitAPI() {

            App.PublicApiDAORepository.Add(new APIEntity() { 
                API = APIName,
                Cors = CORS ? "yes" : "no",
                Auth = AuthType,
                Description = Description,
                HTTPS = HTTPS,
                Link = ConnectionURL
            });
            await Shell.Current.GoToAsync("..");
        }
    }
}

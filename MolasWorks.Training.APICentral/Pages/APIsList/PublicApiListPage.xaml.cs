using MolasWorks.Training.APICentral.AppServices;
using MolasWorks.Training.APICentral.AppServices.Interfaces;
using MolasWorks.Training.APICentral.ConsumingApi;
using MolasWorks.Training.APICentral.Services.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolasWorks.Training.APICentral.Pages.APIsList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublicApiList : ContentPage
    {
        private readonly PublicAPIAppService _PublicAPIAppService;

        public PublicAPIResponse PublicAPIs { get; set; }

        public PublicApiList()
        {
            InitializeComponent();
            _PublicAPIAppService = new PublicAPIAppService("https://api.publicapis.org");
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            //PublicAPIs = await _PublicAPIAppService.GetAll();

            base.OnAppearing();
        }

        private async void ListView_Refreshing(object sender, EventArgs e)
        {
            //PublicAPIs = await _PublicAPIAppService.GetAll();
        }
    }
}
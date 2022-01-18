using MolasWorks.Training.APICentral.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolasWorks.Training.APICentral.Pages.APIsList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(APIName), "APIName")]
    public partial class ApiDetailPage : ContentPage
    {
        private readonly ApiDetailViewModel _apiDetailViewModel;

        public string APIName {
            get => _apiDetailViewModel.APIName;
            set {
                _apiDetailViewModel.APIName = value;
            } 
        }

        public ApiDetailPage()
        {
            InitializeComponent();
            _apiDetailViewModel = new ApiDetailViewModel();
            BindingContext = _apiDetailViewModel;
        }
    }
}
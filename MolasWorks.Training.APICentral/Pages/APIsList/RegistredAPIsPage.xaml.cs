using MolasWorks.Training.APICentral.Models;
using MolasWorks.Training.APICentral.ViewModels;
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
    public partial class RegistredAPIsPage : ContentPage
    {
        private readonly RegistredAPIsViewModel _registredAPIsPageModel;

        public RegistredAPIsPage()
        {
            InitializeComponent();

            _registredAPIsPageModel = new RegistredAPIsViewModel();
            BindingContext = _registredAPIsPageModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _registredAPIsPageModel.APIsCadastradas = 
                new ObservableCollection<APIEntity>(App.PublicApiDAORepository.GetAll().Result);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var api = e.Item as APIEntity;
            Shell.Current.GoToAsync($"{nameof(ApiDetailPage)}?APIName={api.API}");
            if (sender is ListView lv) lv.SelectedItem = null;
        }
    }
}
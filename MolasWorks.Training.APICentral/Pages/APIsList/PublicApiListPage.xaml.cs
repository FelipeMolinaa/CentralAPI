using MolasWorks.Training.APICentral.Models;
using MolasWorks.Training.APICentral.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolasWorks.Training.APICentral.Pages.APIsList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublicApiListPage : ContentPage
    {
        private PublicApiListViewModel _publicApiListViewModel;

        public PublicApiListPage()
        {
            InitializeComponent();
            _publicApiListViewModel = new PublicApiListViewModel();
            BindingContext = _publicApiListViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _publicApiListViewModel.ListIsRefreshing = true;
            _publicApiListViewModel.PublicAPIs = await _publicApiListViewModel.PublicAPIRepository.GetAll();
            _publicApiListViewModel.ListIsRefreshing = false;
            //TODO Adicionar Toast
        }

        private async void ListView_Refreshing(object sender, EventArgs e)
        {
            _publicApiListViewModel.PublicAPIs = await _publicApiListViewModel.PublicAPIRepository.GetAll();
            _publicApiListViewModel.ListIsRefreshing = false;
            //TODO Adicionar Toast
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
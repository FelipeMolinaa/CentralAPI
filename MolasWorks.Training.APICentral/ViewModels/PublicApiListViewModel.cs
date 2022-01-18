using FreshMvvm;
using MolasWorks.Training.APICentral.Repositories;
using MolasWorks.Training.APICentral.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MolasWorks.Training.APICentral.ViewModels
{
    sealed class PublicApiListViewModel : BaseViewModel
    {

        public PublicApiRepository PublicAPIRepository;

        private bool _listIsRefreshing;
        public bool ListIsRefreshing 
        {
            get => _listIsRefreshing;
            set 
            {
                _listIsRefreshing = value;
                OnPropertyChanged("ListIsRefreshing");
            } 
        }

        private PublicAPIResponse _publicAPIs;
        public PublicAPIResponse PublicAPIs 
        { 
            get => _publicAPIs; 
            set { 
                _publicAPIs = value;
                OnPropertyChanged("PublicAPIs");
            } 
        }

        public PublicApiListViewModel()
        {
            PublicAPIRepository = App.PublicApiRepository;
        }
    }
}

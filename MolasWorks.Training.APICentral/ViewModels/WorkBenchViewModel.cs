using MolasWorks.Training.APICentral.Extensions;
using MolasWorks.Training.APICentral.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MolasWorks.Training.APICentral.ViewModels
{
    sealed class WorkBenchViewModel : BaseViewModel
    {
        public GenericAPIRepository _genericApiRepository;
        public string URLEntry { get; set; }

        public string _responseLabel { get; set; }
        public string ResponseLabel {
            get => _responseLabel;
            set {
                _responseLabel = JsonExtension.JsonFormat(value);
                OnPropertyChanged(nameof(ResponseLabel));
            } 
        }

        public ICommand InsertPublicAPI
        {
            get => new Command(() => HandleMakeConsult());
        }

        private async void HandleMakeConsult()
        {
            ResponseLabel = await _genericApiRepository.GetResponse(URLEntry);
        }
    }
}

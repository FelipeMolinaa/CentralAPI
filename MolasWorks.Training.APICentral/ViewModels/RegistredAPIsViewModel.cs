using FreshMvvm;
using MolasWorks.Training.APICentral.Models;
using MolasWorks.Training.APICentral.Pages.APIsList;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MolasWorks.Training.APICentral.ViewModels
{
    sealed class RegistredAPIsViewModel : BaseViewModel
    {
        public ObservableCollection<APIEntity> _APIsCadastradas;

        public ObservableCollection<APIEntity> APIsCadastradas {
            get { return _APIsCadastradas; }
            set {
                _APIsCadastradas = value;
                OnPropertyChanged("APIsCadastradas");
            }
        }

        public RegistredAPIsViewModel()
        {

        }

        public ICommand GotoInsertAPIPage
        {
            get => new Command(async ()=> await Shell.Current.GoToAsync(nameof(InsertApiPage)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MolasWorks.Training.APICentral.ViewModels
{
    public class ApiDetailViewModel : BaseViewModel
    {
        public string _apiName;
        public string APIName {
            get => _apiName;
            set 
            {
                _apiName = value;
                OnPropertyChanged("APIName");
            } 
        }
    }
}

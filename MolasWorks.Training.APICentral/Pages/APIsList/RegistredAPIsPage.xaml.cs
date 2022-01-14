using MolasWorks.Training.APICentral.ConsumingApi;
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
        public ObservableCollection<APIEntity> APIsCadastradas { get; set; }
        public RegistredAPIsPage()
        {
            InitializeComponent();

            APIsCadastradas = new ObservableCollection<APIEntity>();

            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(InsertApiPage));
        }
    }
}